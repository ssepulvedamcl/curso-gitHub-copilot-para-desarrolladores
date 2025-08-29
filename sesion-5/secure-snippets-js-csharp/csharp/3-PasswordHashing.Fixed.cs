// ✅ Mitigación: PBKDF2 (Rfc2898DeriveBytes) con salt e iteraciones
using System;
using System.Security.Cryptography;
using System.Text;

class PasswordHashingFixed {
    static (byte[] salt, byte[] hash) HashPassword(string password, int iterations = 100_000) {
        var salt = RandomNumberGenerator.GetBytes(16);
        using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256);
        var hash = pbkdf2.GetBytes(32);
        return (salt, hash);
    }

    static bool Verify(string password, byte[] salt, byte[] hash, int iterations = 100_000) {
        using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256);
        var test = pbkdf2.GetBytes(32);
        return CryptographicOperations.FixedTimeEquals(test, hash);
    }

    static void Main() {
        Console.Write("Password: ");
        var pass = Console.ReadLine();
        var (salt, hash) = HashPassword(pass);
        Console.WriteLine($"Guardado: salt={Convert.ToBase64String(salt)} hash={Convert.ToBase64String(hash)}");
        Console.WriteLine("Verificación: " + Verify(pass, salt, hash));
    }
}
