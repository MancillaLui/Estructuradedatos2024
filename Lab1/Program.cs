// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 1
Console.WriteLine("______Operaciones Básicas_____");

double num1, num2, suma, resta, multiplicar, dividir;

Console.Write("Primer número: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Segundo número: ");
num2 = int.Parse(Console.ReadLine());

suma = num1 + num2;
resta = num1 - num2;
multiplicar = num1 * num2;

if (num2 != 0)
{
    dividir = num1 / num2;
}
else
{
    Console.WriteLine("NO SE PUEDE DIVIDIR ENTRE 0");
    dividir = 0;
}


Console.WriteLine("Suma: " + suma);
Console.WriteLine("Resta:" + resta);
Console.WriteLine("Multiplicación: " + multiplicar);
Console.WriteLine("División: " + Math.Round(dividir, 2));

Console.ReadLine();
//2
Console.WriteLine("______Par o Impar_____");

int numero;

Console.Write("Ingresa un número: ");
numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine(numero + " es un número par.");
}
else
{
    Console.WriteLine(numero + " es un número impar.");
}

Console.ReadLine();

//3
Console.WriteLine("______Área de un Triángulo_____");

double baseTriangulo, alturaTriangulo, areaTriangulo;

Console.Write("Base del triángulo: ");
baseTriangulo = double.Parse(Console.ReadLine());

Console.Write("Altura del triángulo: ");
alturaTriangulo = double.Parse(Console.ReadLine());

areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

Console.WriteLine("El área del triángulo es: " + areaTriangulo);

Console.ReadLine();
//4
Console.WriteLine("______Cálculo del Factorial_____");

int num4;

Console.Write("Ingresa un número para calcular su factorial: ");
numero = int.Parse(Console.ReadLine());

long factorial = CalcularFactorial(num4);

Console.WriteLine($"El factorial de {num4} es: {factorial}");

Console.ReadLine();

long CalcularFactorial(int n)
{
    if (n < 0)
    {
        throw new ArgumentException("El número no puede ser negativo.");
    }
    else if (n == 0 || n == 1)
    {
        return 1;
    }
    else
    {
        long resultado = 1;
        for (int i = 2; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}
