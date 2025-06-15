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

//ejercicio 2 calculadora V1
int op;
string s, entrada;
bool esvalidonum1, esvalidonum2;

do {
    Console.WriteLine("Menu:\nopcion 1: Sumar\nopcion 2: Restar\nopcion 3: Multiplicar\nopcion 4: Dividir\nopcion elegida:");
    s = Console.ReadLine();
    op = Convert.ToInt32(s);

    Console.WriteLine("operando 1:");
    entrada = Console.ReadLine();
    esvalidonum1 = double.TryParse(entrada, out double operando1);

    Console.WriteLine("operando 2:");
    entrada =Console.ReadLine();
    esvalidonum2 = double.TryParse(entrada, out double operando2);

    if (esvalidonum1 && esvalidonum2 && !(op==4 && operando2==0))
    {
        switch (op)
        {
            case 1:
                Console.WriteLine("Resultado=" + (operando1 + operando2));
                break;
            case 2:
                Console.WriteLine("Resultado=" + (operando1 - operando2));
                break;
            case 3:
                Console.WriteLine("Resultado=" + (operando1 * operando2));
                break;
            case 4:
                Console.WriteLine("Resultado=" + (operando1 / operando2));
                break;
            default:
                Console.WriteLine("Opcion invalida!");
                break;
        }
    }
    else
    {
        Console.WriteLine("Error");
    }
    Console.WriteLine("¿Desea realizar otro calculo?: si(marque 1)/no(marque 0)");
} while (Convert.ToInt32(Console.ReadLine())==1);

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

