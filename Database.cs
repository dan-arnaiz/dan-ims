using System;
using System.Data;
using System.Data.SqlClient;

public class Database
{
    private readonly string connectionString;

    public Database()
    {
        connectionString = @"Server=localhost;Database=dan-ims;Integrated Security=True;";
    }

    public DataTable GetAllComputerParts()
    {
        DataTable dataTable = new DataTable();
        string query = "SELECT ID, Name, Brand, Category, Price, Quantity, Supplier, Description FROM computerparts";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }
        }

        return dataTable;
    }

    public bool AddComputerPart(string name, string brand, string category, decimal price, int quantity, string supplier, string description)
    {
        string query = "INSERT INTO computerparts (Name, Brand, Category, Price, Quantity, Supplier, Description) VALUES (@Name, @Brand, @Category, @Price, @Quantity, @Supplier, @Description)";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Brand", brand);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Supplier", supplier);
                cmd.Parameters.AddWithValue("@Description", description);

                conn.Open();
                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        }
    }

    // Add more methods as needed for updating, deleting, etc.
}