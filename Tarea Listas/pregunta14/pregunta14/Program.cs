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
        HashSet<int> numerosNoDuplicados = ObtenerNumerosNoDuplicados(numeros);
        Console.WriteLine("Números que no están duplicados:");
        foreach (int num in numerosNoDuplicados)
        {
            Console.Write(num + " ");
        }
    }

    public static HashSet<int> ObtenerNumerosNoDuplicados(List<int> numeros)
    {
        Dictionary<int, int> frecuencia = new Dictionary<int, int>();
        foreach (int num in numeros)
        {
            if (frecuencia.ContainsKey(num))
            {
                frecuencia[num]++;
            }
            else
            {
                frecuencia[num] = 1;
            }
        }
        HashSet<int> numerosNoDuplicados = new HashSet<int>();
        foreach (var kvp in frecuencia)
        {
            if (kvp.Value == 1)
            {
                numerosNoDuplicados.Add(kvp.Key);
            }
        }

        return numerosNoDuplicados;
    }
}
