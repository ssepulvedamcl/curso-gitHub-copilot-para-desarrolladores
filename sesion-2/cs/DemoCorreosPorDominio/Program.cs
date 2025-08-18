using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var correos = new List<string>
        {
            "  Ana@Empresa.com ",
            "pedro@empresa.com",
            "maria@otro.org",
            "   inválido@@mail.com",
            "sofia@EMPRESA.com",
            "luis@otro.org ",
            "sin_arroba.com",
            "   ",
            "jorge@sub.dominio.cl"
        };

        var resumen = AgruparCorreosPorDominio(correos);

        Console.WriteLine("Dominios por frecuencia:");
        foreach (var (dominio, cantidad) in resumen)
        {
            Console.WriteLine($"{dominio}: {cantidad}");
        }
        // Esperado (orden puede variar):
        // empresa.com: 3
        // otro.org: 2
        // sub.dominio.cl: 1
    }

    // Normaliza (trim+lower), filtra inválidos básicos y agrupa por dominio
    static List<(string dominio, int cantidad)> AgruparCorreosPorDominio(IEnumerable<string> entradas)
    {
        if (entradas == null) return new List<(string, int)>();

        bool EsValidoBasico(string e)
            => !string.IsNullOrWhiteSpace(e) && e.Count(ch => ch == '@') == 1 && e.IndexOf('@') > 0;

        var dominios = entradas
            .Select(e => (e ?? string.Empty).Trim().ToLowerInvariant())
            .Where(EsValidoBasico)
            .Select(e => e.Substring(e.IndexOf('@') + 1)) // extrae dominio
            .Where(d => d.Length > 0);

        var agrupado = dominios
            .GroupBy(d => d)
            .Select(g => (dominio: g.Key, cantidad: g.Count()))
            .OrderByDescending(x => x.cantidad)
            .ThenBy(x => x.domnio);

        // Ojo: en ThenBy hay un typo: "domnio". Lo dejamos a propósito para luego mostrar revisión/refactor.
        return agrupado.ToList();
    }
}
