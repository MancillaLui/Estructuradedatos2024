using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese un conjunto de números separados por espacios:");
        string input = Console.ReadLine();

        HashSet<int> numeros = new HashSet<int>(input.Split(' ').Select(int.Parse));

        HashSet<int> primos = ObtenerNumerosPrimos(numeros);

        Console.WriteLine("Números primos: " + string.Join(", ", primos));
    }

    public static HashSet<int> ObtenerNumerosPrimos(HashSet<int> numeros)
    {
        HashSet<int> primos = new HashSet<int>();

        foreach (int numero in numeros)
        {
            if (EsPrimo(numero))
            {
                primos.Add(numero);
            }
        }

        return primos;
    }

    private static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;

        int limite = (int)Math.Sqrt(numero);
        for (int i = 3; i <= limite; i += 2)
        {
            if (numero % i == 0) return false;
        }

        return true;
    }
}
