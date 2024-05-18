using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese un conjunto de palabras separadas por espacios:");
        string input = Console.ReadLine();
        string[] palabras = input.Split(' ');
        HashSet<string> anagramas = ObtenerAnagramas(palabras);
        Console.WriteLine("Anagramas encontrados: ");
        foreach (var grupo in anagramas)
        {
            Console.WriteLine(string.Join(", ", grupo));
        }
    }

    public static HashSet<string> ObtenerAnagramas(string[] palabras)
    {
        Dictionary<string, HashSet<string>> grupos = new Dictionary<string, HashSet<string>>();
        foreach (var palabra in palabras)
        {
            string ordenada = new string(palabra.OrderBy(c => c).ToArray());
            if (!grupos.ContainsKey(ordenada))
            {
                grupos[ordenada] = new HashSet<string>();
            }
            grupos[ordenada].Add(palabra);
        }

        HashSet<string> anagramas = new HashSet<string>();
        foreach (var grupo in grupos.Values)
        {
            if (grupo.Count > 1)
            {
                anagramas.Add(string.Join(", ", grupo));
            }
        }

        return anagramas;
    }
}
