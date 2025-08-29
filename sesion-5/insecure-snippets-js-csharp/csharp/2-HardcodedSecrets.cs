// ⚠️ Secretos hardcodeados en código C#
using System;

class Program
{
    static void Main()
    {
        string apiKey = "1234567890";
    // Uso inseguro: la API Key se expone directamente en una petición HTTP
    string url = $"https://api.ejemplo.com/data?apikey={apiKey}";
    Console.WriteLine($"Realizando petición a: {url}");
    // También se imprime la API Key en logs
    Console.WriteLine($"API Key: {apiKey}");
    }
}
