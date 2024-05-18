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
        HashSet<int> numerosOrdenadosNoDuplicados = ObtenerNumerosOrdenadosNoDuplicados(numeros);
        Console.WriteLine("Números ordenados de menor a mayor y no duplicados:");
        foreach (int num in numerosOrdenadosNoDuplicados)
        {
            Console.Write(num + " ");
        }
    }

    public static HashSet<int> ObtenerNumerosOrdenadosNoDuplicados(List<int> numeros)
    {
        HashSet<int> numerosUnicos = new HashSet<int>(numeros);
        List<int> numerosOrdenados = numerosUnicos.ToList();
        numerosOrdenados.Sort();
        return new HashSet<int>(numerosOrdenados);
    }
}
