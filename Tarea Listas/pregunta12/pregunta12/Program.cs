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
        HashSet<int> numerosOrdenados = ObtenerNumerosOrdenados(numeros);
        Console.WriteLine("Números ordenados de mayor a menor:");
        foreach (int num in numerosOrdenados)
        {
            Console.Write(num + " ");
        }
    }

    public static HashSet<int> ObtenerNumerosOrdenados(List<int> numeros)
    {
        numeros.Sort((a, b) => b.CompareTo(a));
        HashSet<int> numerosOrdenados = new HashSet<int>(numeros);
        return numerosOrdenados;
    }
}
