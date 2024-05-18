using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese un conjunto de números separados por espacios:");
        string input = Console.ReadLine();
        string[] numerosStr = input.Split(' ');
        List<int> numeros = new List<int>();

        foreach (string numStr in numerosStr)
        {
            int num;
            if (int.TryParse(numStr, out num))
            {
                numeros.Add(num);
            }
        }
        HashSet<int> numerosDuplicados = ObtenerNumerosDuplicados(numeros);
        Console.WriteLine("Números duplicados:");
        foreach (int num in numerosDuplicados)
        {
            Console.Write(num + " ");
        }
    }
    public static HashSet<int> ObtenerNumerosDuplicados(List<int> numeros)
    {
        HashSet<int> numerosVistos = new HashSet<int>();
        HashSet<int> numerosDuplicados = new HashSet<int>();

        foreach (int num in numeros)
        {
            if (!numerosVistos.Add(num))
            {
                numerosDuplicados.Add(num);
            }
        }

        return numerosDuplicados;
    }
}
