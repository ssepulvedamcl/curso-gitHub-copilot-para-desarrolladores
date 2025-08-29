// ✅ SEGURO: Uso de parámetros SqlParameter
using System;
using System.Data.SqlClient;

class SqlSafeDemo {
    static void Main() {
        Console.Write("Usuario: ");
        var user = Console.ReadLine();

        using var conn = new SqlConnection("Server=.;Database=Demo;Trusted_Connection=True;");
        conn.Open();
        var sql = "SELECT * FROM Users WHERE Username = @username";
        var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@username", user);
        var reader = cmd.ExecuteReader();
        while (reader.Read()) {
            Console.WriteLine(reader["Username"]);
        }
    }
}
