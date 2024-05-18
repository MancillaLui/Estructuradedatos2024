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
        HashSet<string> palabrasOrdenadas = ObtenerPalindromosOrdenadosConLongitud(palabras, longitudDeseada);
        Console.WriteLine($"Palabras palíndromos de longitud {longitudDeseada} ordenadas de menor a mayor:");
        foreach (string palabra in palabrasOrdenadas)
        {
            Console.WriteLine(palabra);
        }
    }
    public static HashSet<string> ObtenerPalindromosOrdenadosConLongitud(string[] palabras, int longitudDeseada)
    {
        HashSet<string> palabrasConLongitudYOrdenadas = new HashSet<string>();
        foreach (string palabra in palabras)
        {
            if (palabra.Length == longitudDeseada && EsPalindromo(palabra))
            {
                palabrasConLongitudYOrdenadas.Add(palabra);
            }
        }
        List<string> palabrasOrdenadas = palabrasConLongitudYOrdenadas.ToList();
        palabrasOrdenadas.Sort();

        return new HashSet<string>(palabrasOrdenadas);
    }
    public static bool EsPalindromo(string palabra)
    {
        int izquierda = 0;
        int derecha = palabra.Length - 1;

        while (izquierda < derecha)
        {
            if (palabra[izquierda] != palabra[derecha])
            {
                return false;
            }
            izquierda++;
            derecha--;
        }

        return true;
    }
}
