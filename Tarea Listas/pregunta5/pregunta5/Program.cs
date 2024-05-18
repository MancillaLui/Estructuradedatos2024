using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese el primer conjunto de números separados por espacios:");
        string input1 = Console.ReadLine();
        HashSet<int> conjunto1 = new HashSet<int>(input1.Split(' ').Select(int.Parse));
        Console.WriteLine("Ingrese el segundo conjunto de números separados por espacios:");
        string input2 = Console.ReadLine();
        HashSet<int> conjunto2 = new HashSet<int>(input2.Split(' ').Select(int.Parse));
        HashSet<int> diferencia = ObtenerDiferencia(conjunto1, conjunto2);
        Console.WriteLine("Números en el primer conjunto pero no en el segundo: " + string.Join(", ", diferencia));
    }

    public static HashSet<int> ObtenerDiferencia(HashSet<int> conjunto1, HashSet<int> conjunto2)
    {
        HashSet<int> diferencia = new HashSet<int>(conjunto1);
        diferencia.ExceptWith(conjunto2);

        return diferencia;
    }
}
