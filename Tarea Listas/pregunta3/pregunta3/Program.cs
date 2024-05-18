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

        Console.WriteLine("Ingrese el número por el cual deben ser divisibles los otros números:");
        int divisor = int.Parse(Console.ReadLine());

        HashSet<int> numerosDivisibles = ObtenerNumerosDivisibles(numeros, divisor);
        Console.WriteLine("Números divisibles por " + divisor + ": " + string.Join(", ", numerosDivisibles));
    }

    public static HashSet<int> ObtenerNumerosDivisibles(HashSet<int> numeros, int divisor)
    {
        HashSet<int> numerosDivisibles = new HashSet<int>();

        foreach (int numero in numeros)
        {
            if (numero % divisor == 0)
            {
                numerosDivisibles.Add(numero);
            }
        }

        return numerosDivisibles;
    }
}
