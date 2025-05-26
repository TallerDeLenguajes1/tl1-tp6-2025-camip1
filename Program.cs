// See https://aka.ms/new-console-template for more information
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
do {
    Console.WriteLine("Menu:\nopcion 1: Sumar\nopcion 2: Restar\nopcion 3: Multiplicar\nopcion 4: Dividir\nopcion elegida:");
    string s = Console.ReadLine();
    op = Convert.ToInt32(s);

    double num1;
    double num2;

    Console.WriteLine("operando 1:");
    string entrada = Console.ReadLine();
    bool esvalidonum1 = double.TryParse(entrada, out num1);
    
    Console.WriteLine("operando 2:");
    entrada=Console.ReadLine();
    bool esvalidonum2 = double.TryParse(entrada, out num2);

    if (esvalidonum1 && esvalidonum2 && !(op==4 && num2==0))
    {
        switch (op)
        {
            case 1:
                Console.WriteLine("Resultado=" + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("Resultado=" + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("Resultado=" + (num1 * num2));
                break;
            case 4:
                Console.WriteLine("Resultado=" + (num1 / num2));
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
