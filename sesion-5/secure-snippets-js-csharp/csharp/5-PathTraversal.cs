// ✅ SEGURO: Validación de rutas
using System;
using System.IO;

class PathSafe {
    static void Main() {
        Console.Write("Archivo a leer: ");
        var file = Path.GetFileName(Console.ReadLine()); // sanitizar input
        var baseDir = Path.Combine(Directory.GetCurrentDirectory(), "files");
        var path = Path.Combine(baseDir, file);
        if (File.Exists(path)) {
            Console.WriteLine(File.ReadAllText(path));
        } else {
            Console.WriteLine("No encontrado");
        }
    }
}
