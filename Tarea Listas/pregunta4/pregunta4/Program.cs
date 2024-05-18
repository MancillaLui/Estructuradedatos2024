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
        HashSet<int> interseccion = ObtenerInterseccion(conjunto1, conjunto2);

        Console.WriteLine("Números que están en ambos conjuntos: " + string.Join(", ", interseccion));
    }

    public static HashSet<int> ObtenerInterseccion(HashSet<int> conjunto1, HashSet<int> conjunto2)
    {
        HashSet<int> interseccion = new HashSet<int>(conjunto1);
        interseccion.IntersectWith(conjunto2);

        return interseccion;
    }
}
