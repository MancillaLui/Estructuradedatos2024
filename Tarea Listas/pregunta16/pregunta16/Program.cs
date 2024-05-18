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
        HashSet<string> palindromasOrdenadas = ObtenerPalindromasOrdenadas(palabras);
        Console.WriteLine("Palabras palíndromas ordenadas de menor a mayor:");
        foreach (string palindroma in palindromasOrdenadas)
        {
            Console.WriteLine(palindroma);
        }
    }

    public static HashSet<string> ObtenerPalindromasOrdenadas(string[] palabras)
    {
        HashSet<string> palindromas = new HashSet<string>();
        foreach (string palabra in palabras)
        {
            if (EsPalindromo(palabra))
            {
                palindromas.Add(palabra);
            }
        }
        List<string> palindromasOrdenadas = palindromas.ToList();
        palindromasOrdenadas.Sort();

        return new HashSet<string>(palindromasOrdenadas);
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
