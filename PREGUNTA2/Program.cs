using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        // 6) Crea una matriz de números reales.
        double[,] matrizReales = new double[3, 3] { { 1.5, 2.5, 3.5 }, { 4.5, 5.5, 6.5 }, { 7.5, 8.5, 9.5 } };
        Console.WriteLine("Matriz de números reales:");
        ImprimirMatriz(matrizReales);

        // 7) Crea una matriz de números complejos.
        Complex[,] matrizComplejos = new Complex[2, 2] { { new Complex(1, 2), new Complex(3, 4) }, { new Complex(5, 6), new Complex(7, 8) } };
        Console.WriteLine("\nMatriz de números complejos:");
        ImprimirMatriz(matrizComplejos);

        // 8) Crea una matriz de matrices.
        int[][][] matrizDeMatrices = new int[2][][];
        matrizDeMatrices[0] = new int[2][];
        matrizDeMatrices[1] = new int[3][];
        matrizDeMatrices[0][0] = new int[2] { 1, 2 };
        matrizDeMatrices[0][1] = new int[2] { 3, 4 };
        matrizDeMatrices[1][0] = new int[3] { 5, 6, 7 };
        matrizDeMatrices[1][1] = new int[3] { 8, 9, 10 };
        matrizDeMatrices[1][2] = new int[3] { 11, 12, 13 };
        Console.WriteLine("\nMatriz de matrices:");
        ImprimirMatriz(matrizDeMatrices);

        // 9) Accede al elemento central de una matriz.
        int[,] matrizCentral = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
        int filaCentral = matrizCentral.GetLength(0) / 2;
        int columnaCentral = matrizCentral.GetLength(1) / 2;
        int elementoCentral = matrizCentral[filaCentral, columnaCentral];
        Console.WriteLine("\nElemento central de la matriz: " + elementoCentral);

        // 10) Suma dos matrices de diferentes tamaños.
        int[,] matrizA = new int[2, 2] { { 1, 2 }, { 3, 4 } };
        int[,] matrizB = new int[2, 3] { { 5, 6, 7 }, { 8, 9, 10 } };
        int[,] matrizSuma = SumarMatrices(matrizA, matrizB);
        Console.WriteLine("\nResultado de la suma de matrices:");
        ImprimirMatriz(matrizSuma);

        // 11) Multiplica una matriz por un número.
        int[,] matrizOriginal = new int[2, 2] { { 1, 2 }, { 3, 4 } };
        int escalar = 2;
        int[,] matrizMultiplicada = MultiplicarMatrizPorEscalar(matrizOriginal, escalar);
        Console.WriteLine("\nResultado de la multiplicación de la matriz por un número:");
        ImprimirMatriz(matrizMultiplicada);

        // 12) Calcula la media de los elementos de una matriz.
        int[,] matrizParaMedia = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double media = CalcularMedia(matrizParaMedia);
        Console.WriteLine("\nLa media de los elementos de la matriz es: " + media);
    }

    static void ImprimirMatriz<T>(T[,] matriz)
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

    static void ImprimirMatriz<T>(T[][][] matriz)
    {
        for (int i = 0; i < matriz.Length; i++)
        {
            for (int j = 0; j < matriz[i].Length; j++)
            {
                for (int k = 0; k < matriz[i][j].Length; k++)
                {
                    Console.Write(matriz[i][j][k] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

    static int[,] SumarMatrices(int[,] matrizA, int[,] matrizB)
    {
        int filas = matrizA.GetLength(0);
        int columnas = matrizA.GetLength(1);
        int[,] resultado = new int[filas, columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }
        return resultado;
    }

    static int[,] MultiplicarMatrizPorEscalar(int[,] matriz, int escalar)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int[,] resultado = new int[filas, columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matriz[i, j] * escalar;
            }
        }
        return resultado;
    }

    static double CalcularMedia(int[,] matriz)
    {
        double suma = 0;
        int elementos = matriz.GetLength(0) * matriz.GetLength(1);
        foreach (int elemento in matriz)
        {
            suma += elemento;
        }
        return suma / elementos;
    }
}
