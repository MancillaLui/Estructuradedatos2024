using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese un conjunto de palabras separadas por espacios:");
        string input = Console.ReadLine();
        string[] palabras = input.Split(' ');
        HashSet<string> palindromos = ObtenerPalindromos(palabras);
        Console.WriteLine("Palíndromos encontrados: ");
        foreach (var palindromo in palindromos)
        {
            Console.WriteLine(palindromo);
        }
    }

    public static HashSet<string> ObtenerPalindromos(string[] palabras)
    {
        HashSet<string> palindromos = new HashSet<string>();
        foreach (var palabra in palabras)
        {
            if (EsPalindromo(palabra))
            {
                palindromos.Add(palabra);
            }
        }

        return palindromos;
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
