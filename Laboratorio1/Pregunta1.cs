using System;

class Programa
{
    static void Main(string[] args)
    {
        double num1, num2;

        // Solicitar al usuario que ingrese el primer número
        Console.Write("Ingresa el primer número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        // Solicitar al usuario que ingrese el segundo número
        Console.Write("Ingresa el segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Suma
        double suma = num1 + num2;
        Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");

        // Resta
        double resta = num1 - num2;
        Console.WriteLine($"La resta de {num1} y {num2} es: {resta}");

        // Multiplicación
        double multiplicacion = num1 * num2;
        Console.WriteLine($"La multiplicación de {num1} y {num2} es: {multiplicacion}");

        // División (asegurándose de no dividir por cero)
        if (num2 != 0)
        {
            double division = num1 / num2;
            Console.WriteLine($"La división de {num1} entre {num2} es: {division}");
        }
        else
        {
            Console.WriteLine("No se puede dividir entre cero.");
        }

        Console.ReadLine();
    }
}
