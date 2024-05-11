using System;

class Program
{
    static void Main(string[] args)
    {
        // Ejercicio 1
        Console.WriteLine("Ejercicio 1:");
        int[,] matriz = GenerarMatrizAleatoria(100, 100);

        // Ejercicio 2
        Console.WriteLine("\nEjercicio 2:");
        double media = CalcularMedia(matriz);
        double mediana = CalcularMediana(matriz);
        double desviacionEstandar = CalcularDesviacionEstandar(matriz);
        Console.WriteLine("Media: " + media);
        Console.WriteLine("Mediana: " + mediana);
        Console.WriteLine("Desviación estándar: " + desviacionEstandar);

        // Ejercicio 3
        Console.WriteLine("\nEjercicio 3:");
        int maximo = EncontrarMaximo(matriz);
        Console.WriteLine("El máximo elemento de la matriz es: " + maximo);

        // Ejercicio 4
        Console.WriteLine("\nEjercicio 4:");
        int[,] submatrizMaxima = EncontrarSubmatrizMaxima(matriz);
        Console.WriteLine("La submatriz de mayor suma es:");
        ImprimirMatriz(submatrizMaxima);

    }

    // Ejercicio 1: Crear una matriz de números aleatorios de tamaño 100x100
    static int[,] GenerarMatrizAleatoria(int filas, int columnas)
    {
        Random rand = new Random();
        int[,] matriz = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = rand.Next(1, 1000); // Números aleatorios entre 1 y 1000
            }
        }

        return matriz;
    }

    // Ejercicio 2: Calcular la media de una matriz
    static double CalcularMedia(int[,] matriz)
    {
        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);
        double suma = 0;

        foreach (int elemento in matriz)
        {
            suma += elemento;
        }

        return suma / totalElementos;
    }

    // Ejercicio 2: Calcular la mediana de una matriz
    static double CalcularMediana(int[,] matriz)
    {
        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);
        int[] elementos = new int[totalElementos];
        int indice = 0;

        foreach (int elemento in matriz)
        {
            elementos[indice++] = elemento;
        }

        Array.Sort(elementos);

        if (totalElementos % 2 == 0)
        {
            return (elementos[totalElementos / 2 - 1] + elementos[totalElementos / 2]) / 2.0;
        }
        else
        {
            return elementos[totalElementos / 2];
        }
    }

    // Ejercicio 2: Calcular la desviación estándar de una matriz
    static double CalcularDesviacionEstandar(int[,] matriz)
    {
        double media = CalcularMedia(matriz);
        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);
        double sumaCuadrados = 0;

        foreach (int elemento in matriz)
        {
            sumaCuadrados += Math.Pow(elemento - media, 2);
        }

        return Math.Sqrt(sumaCuadrados / totalElementos);
    }

    // Ejercicio 3: Encontrar el máximo elemento de una matriz
    static int EncontrarMaximo(int[,] matriz)
    {
        int maximo = matriz[0, 0];

        foreach (int elemento in matriz)
        {
            if (elemento > maximo)
            {
                maximo = elemento;
            }
        }

        return maximo;
    }

    // Ejercicio 4: Encontrar la submatriz de mayor suma de una matriz
    static int[,] EncontrarSubmatrizMaxima(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int maxSuma = int.MinValue;
        int[,] submatrizMaxima = new int[2, 2]; // Suponemos una submatriz de 2x2

        for (int i = 0; i < filas - 1; i++)
        {
            for (int j = 0; j < columnas - 1; j++)
            {
                int suma = matriz[i, j] + matriz[i, j + 1] + matriz[i + 1, j] + matriz[i + 1, j + 1];

                if (suma > maxSuma)
                {
                    maxSuma = suma;
                    submatrizMaxima[0, 0] = matriz[i, j];
                    submatrizMaxima[0, 1] = matriz[i, j + 1];
                    submatrizMaxima[1, 0] = matriz[i + 1, j];
                    submatrizMaxima[1, 1] = matriz[i + 1, j + 1];
                }
            }
        }

        return submatrizMaxima;
    }

    // Método para imprimir una matriz en la consola
    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
