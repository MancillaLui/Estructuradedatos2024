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
        Console.WriteLine("Ingrese la longitud deseada para las palabras:");
        int longitudDeseada;
        while (!int.TryParse(Console.ReadLine(), out longitudDeseada) || longitudDeseada < 0)
        {
            Console.WriteLine("Por favor, ingrese una longitud válida (un número entero positivo):");
        }
        HashSet<string> palabrasOrdenadas = ObtenerPalabrasConLongitudOrdenadas(palabras, longitudDeseada);
        Console.WriteLine($"Palabras de longitud {longitudDeseada} ordenadas de menor a mayor:");
        foreach (string palabra in palabrasOrdenadas)
        {
            Console.WriteLine(palabra);
        }
    }
    public static HashSet<string> ObtenerPalabrasConLongitudOrdenadas(string[] palabras, int longitudDeseada)
    {
        HashSet<string> palabrasConLongitud = new HashSet<string>();
        foreach (string palabra in palabras)
        {
            if (palabra.Length == longitudDeseada)
            {
                palabrasConLongitud.Add(palabra);
            }
        }
        List<string> palabrasOrdenadas = palabrasConLongitud.ToList();
        palabrasOrdenadas.Sort();
        return new HashSet<string>(palabrasOrdenadas);
    }
}
