// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola clase, estrucutura de dato");

//Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 

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

//2) Solicita un número al usuario y determina si es par o impar. 

Console.WriteLine("______Área de un Triángulo_____");

double baseTriangulo, alturaTriangulo, areaTriangulo;

Console.Write("Base del triángulo: ");
baseTriangulo = double.Parse(Console.ReadLine());

Console.Write("Altura del triángulo: ");
alturaTriangulo = double.Parse(Console.ReadLine());

areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

Console.WriteLine("El área del triángulo es: " + areaTriangulo);

Console.ReadLine();
