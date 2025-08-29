// ⚠️ Inyección de comandos con Process.Start

using System;
using System.Diagnostics;

class InsecureCommandInjectionExample
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del archivo a listar:");
        string userInput = Console.ReadLine();

        // ⚠️ Vulnerable a inyección de comandos
        Process.Start("bash", $"-c \"ls {userInput}\"");
    }
}
