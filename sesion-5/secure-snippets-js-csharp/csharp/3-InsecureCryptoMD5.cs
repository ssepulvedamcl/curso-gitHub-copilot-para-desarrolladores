// ✅ SEGURO: Usar Rfc2898DeriveBytes (PBKDF2)
using System;
using System.Security.Cryptography;
using System.Text;

class SecureCrypto {
    static void Main() {
        Console.Write("Password: ");
        var pass = Console.ReadLine();
        var salt = new byte[16];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(salt);
        using var pbkdf2 = new Rfc2898DeriveBytes(pass, salt, 10000);
        var hash = pbkdf2.GetBytes(20);
        Console.WriteLine("PBKDF2 Hash generado.");
    }
}
