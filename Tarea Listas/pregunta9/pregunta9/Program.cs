using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese un conjunto de palabras separadas por espacios:");
        string input = Console.ReadLine();
        string[] palabras = input.Split(' ');
        Console.WriteLine("Ingrese la longitud deseada:");
        int longitudDeseada;
        while (!int.TryParse(Console.ReadLine(), out longitudDeseada) || longitudDeseada < 0)
        {
            Console.WriteLine("Por favor, ingrese una longitud válida (un número entero positivo):");
        }
        HashSet<string> palabrasConLongitud = ObtenerPalabrasConLongitud(palabras, longitudDeseada);
        Console.WriteLine($"Palabras de longitud {longitudDeseada}: ");
        foreach (var palabra in palabrasConLongitud)
        {
            Console.WriteLine(palabra);
        }
    }

    public static HashSet<string> ObtenerPalabrasConLongitud(string[] palabras, int longitudDeseada)
    {
        HashSet<string> palabrasConLongitud = new HashSet<string>();
        foreach (var palabra in palabras)
        {
            if (palabra.Length == longitudDeseada)
            {
                palabrasConLongitud.Add(palabra);
            }
        }

        return palabrasConLongitud;
    }
}
