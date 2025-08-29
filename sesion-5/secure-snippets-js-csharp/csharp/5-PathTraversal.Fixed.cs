// ✅ Mitigación: Normalizar ruta y validar base directory
using System;
using System.IO;

class PathTraversalFixed {
    static void Main() {
        var baseDir = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "public"));
        Console.Write("Archivo a leer (dentro de /public): ");
        var file = Console.ReadLine() ?? "";
        if (file.IndexOfAny(Path.GetInvalidPathChars()) >= 0) { Console.WriteLine("Nombre inválido"); return; }

        var full = Path.GetFullPath(Path.Combine(baseDir, file));
        if (!full.StartsWith(baseDir)) { Console.WriteLine("Acceso denegado"); return; }
        if (!File.Exists(full)) { Console.WriteLine("No encontrado"); return; }
        Console.WriteLine(File.ReadAllText(full));
    }
}
