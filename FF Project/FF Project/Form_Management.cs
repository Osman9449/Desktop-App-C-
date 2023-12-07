using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF_Project
{
    public partial class Form_Management : Form
    {
        public Form_Management()
        {
            InitializeComponent();
        }
        DbConnector connector = new DbConnector();

        private const string ConnectionString = "Host=localhost;Username=postgres;Password=root;Database=postgres";

        public NpgsqlConnection GetDbConnection()
        {
            NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connected to the database");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to the database: {ex.Message}");
            }

            return connection;
        }
        public DataTable SearchCars(string searchTerm)
        {
            string searchQuery = "SELECT * FROM cars_table_for_desktop_app " +
                                 "WHERE brand ILIKE @SearchTerm OR " +
                                 "model ILIKE @SearchTerm OR " +
                                 "color ILIKE @SearchTerm OR " +
                                 "engine_type ILIKE @SearchTerm OR " +
                                 "CAST(year AS TEXT) ILIKE @SearchTerm;";

            DataTable resultTable = new DataTable();

            using (NpgsqlConnection connection = GetDbConnection())
            {
                if (connection.State == ConnectionState.Open)
                {
                    using (NpgsqlCommand command = new NpgsqlCommand(searchQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            adapter.Fill(resultTable);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Unable to search. Database connection is closed.");
                }
            }

            return resultTable;
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                // Replace 'your_query' with your actual SQL query to retrieve data
                string query = "SELECT * FROM cars_table_for_desktop_app";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                {
                    // Fill the DataTable with data from the database
                    adapter.Fill(dataTable);
                }
            }

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void buttonSearchItem_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSeachItem.Text;


            DataTable searchResults = SearchCars(searchTerm);


            dataGridView1.DataSource = searchResults;


            if (searchResults.Rows.Count == 0)
            {
                MessageBox.Show("No matching cars found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxDeleteItem.Text);

            if (connector.DoesIdExist(id))
            {
                connector.DeleteCar(id);
                MessageBox.Show("The car with ID " + id + " was deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is no car with " + id + " ID !", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        bool IsValidYear(string text)
        {
            // Allow only 4 digits for the year.
            return Regex.IsMatch(text, @"^\d{4}$");
        }
        public bool isCarFieldsRequired(string brand, string model, string color, string engineType, string year)
        {

            if (string.IsNullOrWhiteSpace(brand) ||
                string.IsNullOrWhiteSpace(model) ||
                string.IsNullOrWhiteSpace(color) ||
                string.IsNullOrWhiteSpace(engineType) ||
                string.IsNullOrWhiteSpace(year))
            {
                MessageBox.Show("Please fill in all the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsValidYear(year))
            {
                MessageBox.Show("Invaid year ! minimum 4 characters", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else { return true; }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string brand = textBoxBrand.Text;
            string model = textBoxModel.Text;
            string color = textBoxColor.Text;
            string? engineType = comboBoxEngine.SelectedItem?.ToString();
            string yearString = textBoxYear.Text;

            if (isCarFieldsRequired(brand, model, color, engineType, yearString))
            {
                connector.AddCar(brand, model, color, engineType, int.Parse(yearString));
                MessageBox.Show("Car added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            int id = int.Parse(textBoxUpdateID.Text);
            string? selectedColumnName = comboBoxUpdate.SelectedItem?.ToString();
            string newValue = textBoxNewName.Text;

            if (string.IsNullOrWhiteSpace(selectedColumnName) ||
               string.IsNullOrWhiteSpace(newValue))
            {
                MessageBox.Show("Please fill in all the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!connector.DoesIdExist(id))
            {
                MessageBox.Show("There is no car with " + id + " ID !", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connector.UpdateColumn(id, selectedColumnName, newValue);
                MessageBox.Show("The car with ID " + id + " was updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
