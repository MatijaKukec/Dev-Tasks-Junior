using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "...; "; 
        string query = "SELECT * FROM CountryPopulation WHERE population > (SELECT population FROM CountryPopulation WHERE countryId = '001')";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string countryId = reader["countryId"].ToString();
                        int population = Convert.ToInt32(reader["population"]);

                        Console.WriteLine($"CountryId: {countryId}, Population: {population}");
                    }
                }
            }
        }
    }
}
