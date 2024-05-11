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

long factorial = CalcularFactorial(numero);

Console.WriteLine($"El factorial de {numero} es: {factorial}");

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

//5
Console.WriteLine("______Verificación de Número Primo_____");

int num5;

Console.Write("Ingresa un número para verificar si es primo: ");
numero = int.Parse(Console.ReadLine());

bool esPrimo = EsPrimo(numero);

if (esPrimo)
{
    Console.WriteLine($"{numero} es un número primo.");
}
else
{
    Console.WriteLine($"{numero} no es un número primo.");
}

Console.ReadLine();

bool EsPrimo(int n)
{
    if (n <= 1)
    {
        return false;
    }

    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }

    return true;
}
//6
Console.WriteLine("______Inversión de una Cadena de Texto_____");

string texto;

Console.Write("Ingresa una cadena de texto: ");
texto = Console.ReadLine();

string textoInvertido = InvertirTexto(texto);

Console.WriteLine($"La inversión de \"{texto}\" es: \"{textoInvertido}\"");

Console.ReadLine();

string InvertirTexto(string input)
{
    char[] caracteres = input.ToCharArray();
    Array.Reverse(caracteres);
    return new string(caracteres);
}
//7
Console.WriteLine("______Suma de Números Pares en un Rango_____");

int inicio, fin;

Console.Write("Ingresa el inicio del rango: ");
inicio = int.Parse(Console.ReadLine());

Console.Write("Ingresa el fin del rango: ");
fin = int.Parse(Console.ReadLine());

int sumaPares = SumarNumerosParesEnRango(inicio, fin);

Console.WriteLine($"La suma de los números pares en el rango [{inicio}, {fin}] es: {sumaPares}");

Console.ReadLine();

int SumarNumerosParesEnRango(int inicio, int fin)
{
    int suma = 0;
    for (int i = inicio; i <= fin; i++)
    {
        if (i % 2 == 0)
        {
            suma += i;
        }
    }
    return suma;
}
//8
Console.WriteLine("______Lista de Cuadrados de los Primeros 10 Números Naturales_____");

List<int> cuadrados = CalcularCuadradosPrimerosDiezNaturales();

Console.WriteLine("Los cuadrados de los primeros 10 números naturales son:");
foreach (int cuadrado in cuadrados)
{
    Console.WriteLine(cuadrado);
}

Console.ReadLine();

List<int> CalcularCuadradosPrimerosDiezNaturales()
{
    List<int> cuadrados = new List<int>();
    for (int i = 1; i <= 10; i++)
    {
        cuadrados.Add(i * i);
    }
    return cuadrados;
}
//9
Console.WriteLine("______Contador de Vocales en una Cadena de Texto_____");

string texto9;
Console.Write("Ingresa una cadena de texto: ");
texto = Console.ReadLine();

int contadorVocales = ContarVocales(texto);

Console.WriteLine($"El número de vocales en \"{texto}\" es: {contadorVocales}");

Console.ReadLine();

int ContarVocales(string texto)
{
    int contador = 0;
    foreach (char caracter in texto.ToLower())
    {
        if ("aeiou".Contains(caracter))
        {
            contador++;
        }
    }
    return contador;
}
//10
Console.WriteLine("______Primeros 10 Números de la Serie Fibonacci_____");

List<int> fibonacci = GenerarFibonacci(10);

Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
foreach (int numero9 in fibonacci)
{
    Console.WriteLine(numero9);
}

Console.ReadLine();

List<int> GenerarFibonacci(int n)
{
    List<int> fibonacci = new List<int>();

    int a = 0;
    int b = 1;

    for (int i = 0; i < n; i++)
    {
        fibonacci.Add(a);
        int temp = a;
        a = b;
        b = temp + b;
    }

    return fibonacci;
}
//11
Console.WriteLine("______Ordenar una Lista de Números_____");

List<int> numeros = new List<int>();

Console.WriteLine("Ingresa una serie de números (ingresa 'fin' para finalizar):");

string entrada;
do
{
    entrada = Console.ReadLine();
    if (entrada.ToLower() != "fin")
    {
        if (int.TryParse(entrada, out int numero11))
        {
            numeros.Add(numero);
        }
        else
        {
            Console.WriteLine("Entrada inválida. Ingresa un número válido o 'fin' para finalizar.");
        }
    }
} while (entrada.ToLower() != "fin");

numeros.Sort();

Console.WriteLine("Lista de números ordenados de menor a mayor:");
foreach (int num in numeros)
{
    Console.WriteLine(num);
}

Console.ReadLine();
//12
Console.WriteLine("______Verificar si una Palabra es un Palíndromo_____");

Console.Write("Ingresa una palabra: ");
string palabra = Console.ReadLine().ToLower();

bool esPalindromo = EsPalindromo(palabra);

if (esPalindromo)
{
    Console.WriteLine($"\"{palabra}\" es un palíndromo.");
}
else
{
    Console.WriteLine($"\"{palabra}\" no es un palíndromo.");
}

Console.ReadLine();

bool EsPalindromo(string palabra)
{
    int longitud = palabra.Length;
    for (int i = 0; i < longitud / 2; i++)
    {
        if (palabra[i] != palabra[longitud - i - 1])
        {
            return false;
        }
    }
    return true;
}
//13
Console.WriteLine("______Tabla de Multiplicar_____");

Console.Write("Ingresa un número para generar su tabla de multiplicar: ");
int numero13 = int.Parse(Console.ReadLine());

Console.WriteLine($"Tabla de multiplicar del número {numero}:");
for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}

Console.ReadLine();
//14
Console.WriteLine("______Cálculo del Área de un Círculo_____");

Console.Write("Ingresa el radio del círculo: ");
double radio = double.Parse(Console.ReadLine());

double area = Math.PI * radio * radio;

Console.WriteLine($"El área del círculo con radio {radio} es: {area}");

Console.ReadLine();
//15
Console.WriteLine("______Suma de los Dígitos de un Número Entero_____");

Console.Write("Ingresa un número entero: ");
int numero15 = int.Parse(Console.ReadLine());

int sumaDigitos = 0;
int numeroAbsoluto = Math.Abs(numero15);

while (numeroAbsoluto > 0)
{
    int digito = numeroAbsoluto % 10; 
    sumaDigitos += digito; 
    numeroAbsoluto /= 10;
}

Console.WriteLine($"La suma de los dígitos de {numero15} es: {sumaDigitos}");

Console.ReadLine();
