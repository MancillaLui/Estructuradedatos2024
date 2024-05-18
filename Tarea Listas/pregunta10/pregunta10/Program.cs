using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese un conjunto de palabras separadas por espacios:");
        string input = Console.ReadLine();
        string[] palabras = input.Split(' ');
        Console.WriteLine("Ingrese la letra que deben contener las palabras:");
        char letra;
        while (!char.TryParse(Console.ReadLine(), out letra))
        {
            Console.WriteLine("Por favor, ingrese una letra válida:");
        }

        HashSet<string> palabrasConLetra = ObtenerPalabrasConLetra(palabras, letra);
        Console.WriteLine($"Palabras que contienen la letra '{letra}':");
        foreach (var palabra in palabrasConLetra)
        {
            Console.WriteLine(palabra);
        }
    }

    public static HashSet<string> ObtenerPalabrasConLetra(string[] palabras, char letra)
    {
        HashSet<string> palabrasConLetra = new HashSet<string>();
        foreach (var palabra in palabras)
        {
            if (palabra.Contains(letra))
            {
                palabrasConLetra.Add(palabra);
            }
        }

        return palabrasConLetra;
    }
}
