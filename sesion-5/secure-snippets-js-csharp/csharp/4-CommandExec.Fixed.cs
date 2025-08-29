// ✅ Mitigación: Evitar shell; usar APIs del sistema y whitelists
using System;
using System.IO;

class CommandExecFixed {
    static void Main() {
        Console.Write("Directorio a listar (nombre simple): ");
        var name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name) || name.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0) {
            Console.WriteLine("Nombre inválido"); return;
        }
        // En vez de Process.Start, usamos APIs seguras:
        var baseDir = Directory.GetCurrentDirectory();
        var path = Path.GetFullPath(Path.Combine(baseDir, name));
        if (!path.StartsWith(baseDir)) { Console.WriteLine("Acceso denegado"); return; }
        if (!Directory.Exists(path)) { Console.WriteLine("No existe"); return; }
        foreach (var f in Directory.EnumerateFileSystemEntries(path)) Console.WriteLine(f);
    }
}
