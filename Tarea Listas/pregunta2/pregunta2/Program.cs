using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese un conjunto de palabras separadas por espacios:");
        string input = Console.ReadLine();

        HashSet<string> palabras = new HashSet<string>(input.Split(' '));

        Console.WriteLine("Ingrese la letra con la que deben comenzar las palabras:");
        char letra = Console.ReadLine()[0];

        HashSet<string> palabrasConLetra = ObtenerPalabrasConLetra(palabras, letra);

        Console.WriteLine("Palabras que comienzan con la letra '" + letra + "': " + string.Join(", ", palabrasConLetra));
    }

    public static HashSet<string> ObtenerPalabrasConLetra(HashSet<string> palabras, char letra)
    {
        HashSet<string> palabrasConLetra = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (!string.IsNullOrEmpty(palabra) && palabra[0] == letra)
            {
                palabrasConLetra.Add(palabra);
            }
        }

        return palabrasConLetra;
    }
}
