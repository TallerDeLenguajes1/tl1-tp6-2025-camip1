// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;
using System.Runtime.InteropServices;

/*
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:" + b);
*/

//ejercicio 1 invertir numero
/*int n;
string s;

do{
    Console.WriteLine("Ingrese un entero mayor a cero");
    s = Console.ReadLine();
} while (!int.TryParse(s, out n));

Console.WriteLine("El numero ingresado es "+n);

if (n > 0)
{
    int dig;
    int invertido = 0;
    while (n > 0)
    {
        dig = n % 10;
        invertido = invertido * 10 + dig;
        n = n / 10;
    }
    Console.WriteLine("El numero invertido es:" + invertido);
}
else
{
    Console.WriteLine("El numero debe ser mayor a 0");
}*/

//ejercicio 3
string input;
bool esNumValido;
double numero;
do
{
    Console.WriteLine("Ingrese un numero:");
    input = Console.ReadLine();
    esNumValido = double.TryParse(input, out numero);
    if (!esNumValido)
    {
        Console.WriteLine("Numero invalido!");
    }
} while (!esNumValido);

double valorAbs = Math.Abs(numero);
double cuadrado = numero*numero;
double raizCuadrada = Math.Sqrt(numero);
double cos = Math.Cos(numero);
double sin = Math.Sin(numero);
int parteEntera = (int)numero;

Console.WriteLine($"El valor absoluto de {numero} es:{valorAbs}");
Console.WriteLine($"El cuadrado del numero ingresado es:{cuadrado:F2}");
Console.WriteLine($"La raiz cuadrada del numero ingresado es:{raizCuadrada:F2}");
Console.WriteLine($"El coseno del numero ingresado (en radianes) es:{cos:F4}");
Console.WriteLine($"El seno del numero ingresado (en radianes) es:{sin:F4}");
Console.WriteLine($"La parte entera del numero ingresado es:{parteEntera}");

Console.WriteLine("Ingrese un numero:");
input = Console.ReadLine();
esvalidonum1 = double.TryParse(input, out double num1);

Console.WriteLine("Ingrese otro numero:");    
input = Console.ReadLine();
esvalidonum2= double.TryParse(input, out double num2);

if (esvalidonum1 && esvalidonum2){
    if (num1 > num2){
        Console.WriteLine($"{num1} es el maximo");
        Console.WriteLine($"{num2} es el minimo");
    }
    else if (num2 > num1){
        Console.WriteLine($"{num2} es el maximo");
        Console.WriteLine($"{num1} es el minimo");
    }
    else{
        Console.WriteLine("Los numeros ingresados son iguales. No hay maximo ni minimo");
    }
}
else{
    Console.WriteLine("Se ingresan numeros invalidos");
}

