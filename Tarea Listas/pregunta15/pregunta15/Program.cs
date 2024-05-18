using System;
using System.Collections.Generic;


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
        HashSet<int> primos = ObtenerNumerosPrimos(numeros);
        Console.WriteLine("Números primos ordenados de menor a mayor:");
        foreach (int primo in primos)
        {
            Console.Write(primo + " ");
        }
    }
    public static HashSet<int> ObtenerNumerosPrimos(List<int> numeros)
    {
        HashSet<int> primos = new HashSet<int>();

        foreach (int num in numeros)
        {
            if (EsPrimo(num))
            {
                primos.Add(num);
            }
        }
        return primos;
    }
    public static bool EsPrimo(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
