// ⚠️ SQL Injection inseguro: concatenación/interpolación de strings
using System;
using System.Data.SqlClient;

string userInput = "1; DROP TABLE Users;";
string query = $"SELECT * FROM Users WHERE Id = {userInput}";

using (SqlConnection connection = new SqlConnection("connection_string"))
{
    SqlCommand command = new SqlCommand(query, connection);
    connection.Open();
    SqlDataReader reader = command.ExecuteReader();
}
