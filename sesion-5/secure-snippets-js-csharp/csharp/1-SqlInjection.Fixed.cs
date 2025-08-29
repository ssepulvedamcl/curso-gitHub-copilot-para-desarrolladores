// ✅ Mitigación: Parámetros en SqlCommand
using System;
using System.Data;
using System.Data.SqlClient;

class SqlInjectionFixed {
    static void Main() {
        Console.Write("Usuario: ");
        var user = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(user) || user.Length > 50) {
            Console.WriteLine("Usuario inválido"); return;
        }

        using var conn = new SqlConnection(Environment.GetEnvironmentVariable("DB_CONN"));
        conn.Open();
        using var cmd = new SqlCommand("SELECT * FROM Users WHERE Username = @u", conn);
        cmd.Parameters.Add(new SqlParameter("@u", SqlDbType.NVarChar, 50) { Value = user });
        using var reader = cmd.ExecuteReader();
        while (reader.Read()) {
            Console.WriteLine(reader["Username"]);
        }
    }
}
