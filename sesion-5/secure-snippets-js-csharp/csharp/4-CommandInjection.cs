// ✅ SEGURO: Evitar concatenar input en comandos
using System;
using System.IO;

class CommandSafe {
    static void Main() {
        Console.Write("Directorio a listar: ");
        var name = Console.ReadLine();
        if (Directory.Exists(name)) {
            foreach (var file in Directory.GetFiles(name)) {
                Console.WriteLine(file);
            }
        } else {
            Console.WriteLine("Directorio no válido.");
        }
    }
}
