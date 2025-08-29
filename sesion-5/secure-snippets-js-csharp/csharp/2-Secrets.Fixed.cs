// ✅ Mitigación: Secretos desde variables de entorno o secretos de usuario
using System;

class SecretsFixed {
    static void Main() {
        var apiKey = Environment.GetEnvironmentVariable("API_KEY");
        var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
        if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(dbPassword)) {
            Console.Error.WriteLine("Faltan secretos. Configure API_KEY y DB_PASSWORD.");
            Environment.Exit(1);
        }
        Console.WriteLine("API Key cargada (****)");
        // Usar dbPassword sin imprimirla nunca
    }
}
