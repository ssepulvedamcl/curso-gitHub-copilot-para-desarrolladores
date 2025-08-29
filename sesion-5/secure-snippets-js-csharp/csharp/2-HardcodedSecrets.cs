// ✅ SEGURO: Usar variables de entorno
using System;

class SecretsSafe {
    static void Main() {
        var apiKey = Environment.GetEnvironmentVariable("API_KEY");
        var dbPass = Environment.GetEnvironmentVariable("DB_PASSWORD");
        Console.WriteLine(apiKey != null ? "API Key OK" : "API Key no definida");
    }
}
