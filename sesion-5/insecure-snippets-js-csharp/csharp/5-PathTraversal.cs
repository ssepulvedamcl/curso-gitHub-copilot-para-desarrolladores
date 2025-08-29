// ⚠️ Path Traversal: componer rutas con entrada externa

using System;
using System.IO;

class InsecurePathTraversalExample
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del archivo a leer:");
        string userInput = Console.ReadLine();

        // ⚠️ Vulnerable a path traversal
        string filePath = "/home/ssepulvedacl/archivos/" + userInput;

        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("Contenido del archivo:");
            Console.WriteLine(content);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo: " + ex.Message);
        }
    }
}
