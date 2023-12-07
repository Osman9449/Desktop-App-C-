using Npgsql;
using System.Data; 

public class DbConnector
{
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
    
    public bool DoesUserNameExist(string userName)
    {
        string selectQuery = "SELECT COUNT(*) FROM users_table_for_desktop_app WHERE user_name = @UserName;";

        using (NpgsqlConnection connection = GetDbConnection())
        {
            if (connection.State == ConnectionState.Open)
            {
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);

                    try
                    {
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error checking if user exists: {ex.Message}");
                        return false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Unable to check user existence. Database connection is closed.");
                return false;
            }
        }
    }

    public void AddUser(string fullName, string userName, string password, string phoneNumber)
    {

        string insertQuery = "INSERT INTO users_table_for_desktop_app (full_name, user_name, password, phone_number) " +
                             "VALUES (@FullName, @UserName, @Password, @PhoneNumber);";

        using (NpgsqlConnection connection = GetDbConnection())
        {
            if (connection.State == ConnectionState.Open)
            {
                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@PhoneNumber","+944"+phoneNumber);

                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("User added successfully");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error adding user: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Unable to add user. Database connection is closed.");
            }
        }
    }
    
    public string GetStoredPassword(string userName)
    {

        string selectQuery = "SELECT password FROM users_table_for_desktop_app WHERE user_name = @UserName;";

        using (NpgsqlConnection connection = GetDbConnection())
        {
            if (connection.State == ConnectionState.Open)
            {
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {

                    command.Parameters.AddWithValue("@UserName", userName);

                    try
                    { 
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            Console.WriteLine("User not found.");
                            return null; 
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error retrieving password: {ex.Message}");
                        return null; 
                    }
                }
            }
            else
            {
                Console.WriteLine("Unable to retrieve password. Database connection is closed.");
                return null;
            }
        }
    }
    
    public void AddCar(string brand, string model, string color, string engineType, int year)
    {
        // SQL query to insert data into the 'cars' table
        string insertQuery = "INSERT INTO cars_table_for_desktop_app (brand, model, color, engine_type, year) " +
                             "VALUES (@Brand, @Model, @Color, @EngineType, @Year);";

        using (NpgsqlConnection connection = GetDbConnection())
        {
            if (connection.State == ConnectionState.Open)
            {
                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    // Add parameters to the query to prevent SQL injection
                    command.Parameters.AddWithValue("@Brand", brand);
                    command.Parameters.AddWithValue("@Model", model);
                    command.Parameters.AddWithValue("@Color", color);
                    command.Parameters.AddWithValue("@EngineType", engineType);
                    command.Parameters.AddWithValue("@Year", year);

                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Car added successfully");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error adding car: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Unable to add car. Database connection is closed.");
            }
        }
    }
    
    public void DeleteCar(int carId)
    {
        // SQL query to delete a row from the 'cars' table based on the ID
        string deleteQuery = "DELETE FROM cars_table_for_desktop_app WHERE id = @CarId;";

        using (NpgsqlConnection connection = GetDbConnection())
        {
            if (connection.State == ConnectionState.Open)
            {
                using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, connection))
                {
                    // Add parameter to the query to specify the ID to delete
                    command.Parameters.AddWithValue("@CarId", carId);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Car with ID {carId} deleted successfully");
                        }
                        else
                        {
                            Console.WriteLine($"No car found with ID {carId}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error deleting car: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Unable to delete car. Database connection is closed.");
            }
        }
    }
    
    public bool DoesIdExist(int carId)
    {
        // SQL query to check if the ID exists in the 'cars' table
        string checkQuery = "SELECT COUNT(*) FROM cars_table_for_desktop_app WHERE id = @CarId;";

        using (NpgsqlConnection connection = GetDbConnection())
        {
            if (connection.State == ConnectionState.Open)
            {
                using (NpgsqlCommand command = new NpgsqlCommand(checkQuery, connection))
                {
                    // Add parameter to the query to specify the ID to check
                    command.Parameters.AddWithValue("@CarId", carId);

                    try
                    {
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // If count is greater than 0, the ID exists
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error checking ID existence: {ex.Message}");
                        return false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Unable to check ID existence. Database connection is closed.");
                return false;
            }
        }
    }

    public void UpdateColumn(int id, string selectedColumnName, string newValue)
    {
        // SQL query to update a specific column in the 'cars' table based on the ID
        string updateQuery = $"UPDATE cars_table_for_desktop_app SET {selectedColumnName} = @NewValue WHERE id = @CarId;";

        using (NpgsqlConnection connection = GetDbConnection())
        {
            if (connection.State == ConnectionState.Open)
            {
                using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, connection))
                {
                    // Add parameters to the query to specify the ID, selected column name, and new value
                    command.Parameters.AddWithValue("@CarId", id);
                    command.Parameters.AddWithValue("@NewValue", newValue);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Column '{selectedColumnName}' updated successfully for car with ID {id}");
                        }
                        else
                        {
                            Console.WriteLine($"No car found with ID {id}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error updating column: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Unable to update column. Database connection is closed.");
            }
        }
    }


}
