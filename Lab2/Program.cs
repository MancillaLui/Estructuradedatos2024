using System;

class Program
{
    // Ejercicio 1: Imprimir números pares del 1 al 100
    static void ImprimirPares(int numero)
    {
        if (numero <= 100)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine($"Número par: {numero}");
            }
            ImprimirPares(numero + 1);
        }
    }

    // Ejercicio 2: Imprimir suma de números del 1 al n
    static int SumaNumeros(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n + SumaNumeros(n - 1);
        }
    }

    // Ejercicio 3: Imprimir pirámide de números del 1 al n
    static void ImprimirPiramide(int n, int current = 1)
    {
        if (current <= n)
        {
            for (int i = 1; i <= current; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            ImprimirPiramide(n, current + 1);
        }
    }

    // Ejercicio 4: Imprimir pirámide de números invertidos del 1 al n
    static void ImprimirPiramideInvertida(int n)
    {
        if (n >= 1)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            ImprimirPiramideInvertida(n - 1);
        }
    }

    // Ejercicio 5: Imprimir tabla de multiplicar del n
    static void TablaMultiplicar(int n, int multiplicador = 1)
    {
        if (multiplicador <= 10)
        {
            Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");
            TablaMultiplicar(n, multiplicador + 1);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 1: Imprimir números pares del 1 al 100");
        ImprimirPares(1);
        Console.WriteLine();

        Console.WriteLine("Ejercicio 2: Imprimir suma de números del 1 al n");
        Console.Write("Ingresa un número entero positivo para calcular su suma: ");
        int numeroSuma = int.Parse(Console.ReadLine());
        int suma = SumaNumeros(numeroSuma);
        Console.WriteLine($"La suma de los números del 1 al {numeroSuma} es: {suma}");
        Console.WriteLine();

        Console.WriteLine("Ejercicio 3: Imprimir pirámide de números del 1 al n");
        Console.Write("Ingresa un número entero positivo para la altura de la pirámide: ");
        int altura = int.Parse(Console.ReadLine());
        ImprimirPiramide(altura);
        Console.WriteLine();

        Console.WriteLine("Ejercicio 4: Imprimir pirámide de números invertidos del 1 al n");
        Console.Write("Ingresa un número entero positivo para la altura de la pirámide invertida: ");
        int alturaInvertida = int.Parse(Console.ReadLine());
        ImprimirPiramideInvertida(alturaInvertida);
        Console.WriteLine();

        Console.WriteLine("Ejercicio 5: Imprimir tabla de multiplicar del n");
        Console.Write("Ingresa un número entero para la tabla de multiplicar: ");
        int numeroTabla = int.Parse(Console.ReadLine());
        TablaMultiplicar(numeroTabla);
    }
}

