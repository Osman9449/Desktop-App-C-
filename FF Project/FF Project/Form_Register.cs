using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_App
{
    public partial class Form_Register : Form
    {

        DbConnector connector = new DbConnector();
        public Form_Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        bool IsValidPhoneNumber(string text)
        {
            return Regex.IsMatch(text, @"^\(\d{2}\)-\d{3}-\d{2}-\d{2}$");
        }
        bool IsValidPassword(string password)
        {
            // Minimum 8 characters, at least 1 digit, and excluding ?, !, \, |, and ,
            return Regex.IsMatch(password, @"^(?=.*\d)(?!.*[?!,\\|,]).{8,}$");
        }

        public bool isFieldsRequired(string fullName, string userName, string password, string againPassword, string phoneNumber) {

            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(againPassword))
            {
                MessageBox.Show("Please fill in all the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (password != againPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!IsValidPassword(password))
            {
                MessageBox.Show("Minimum 8 characters, at least 1 digit, and excluding ?, !, \\, |, and ,", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Phone number isn't correct", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else { return true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text;
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string againPassword = textBoxAgainPassword.Text;
            string phoneNumber = maskedTextBoxPhoneNumber.Text;



            if (isFieldsRequired(fullName, userName, password, againPassword, phoneNumber)) {
                if (connector.DoesUserNameExist(userName)==false)
                {
                    connector.AddUser(fullName, userName, password, phoneNumber);
                    MessageBox.Show("User register succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("This username has already registered ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
       
        }

    }
}