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

//--------------------------------------------------------------------------------------------------
//ejercicio 2 calculadora V1

// int op;
// string s, entrada;
// bool esvalidonum1, esvalidonum2;

// do {
//     Console.WriteLine("Menu:\nopcion 1: Sumar\nopcion 2: Restar\nopcion 3: Multiplicar\nopcion 4: Dividir\nopcion elegida:");
//     s = Console.ReadLine();
//     op = Convert.ToInt32(s);
    
//     Console.WriteLine("operando 1:");
//     entrada = Console.ReadLine();
//     esvalidonum1 = double.TryParse(entrada, out double operando1);

//     Console.WriteLine("operando 2:");
//     entrada = Console.ReadLine();
//     esvalidonum2 = double.TryParse(entrada, out double operando2);

//     if (esvalidonum1 && esvalidonum2 && !(op == 4 && operando2 == 0))
//     {
//         switch (op)
//         {
//             case 1:
//                 double suma = operando1 + operando2;
//                 Console.WriteLine("La suma de " + operando1.ToString() + " y de " + operando2.ToString() + " es " + suma.ToString());
//                 break;
//             case 2:
//                 double resta = operando1 - operando2;
//                 Console.WriteLine("La diferencia entre " + operando1.ToString() + " y " + operando2.ToString() + " es " + resta.ToString());
//                 break;
//             case 3:            
//                 double producto = operando1 * operando2;
//                 Console.WriteLine("El producto de " + operando1.ToString() + " por " + operando2.ToString() + " es " + producto.ToString());
//                 break;
//             case 4:
//                 if (operando2 != 0)
//                 {
//                     double cociente = operando1 / operando2;
//                     Console.WriteLine("El cocientre entre " + operando1.ToString() + " y " + operando2.ToString() + " es " + cociente.ToString());
//                 }
//                 else
//                 {
//                     Console.WriteLine("Error: division por cero");
//                 }
//                 break;
//             default:
//                 Console.WriteLine("Opcion invalida!");
//                 break;
//         }
//     }
//     Console.WriteLine("¿Desea realizar otro calculo?: si(marque 1)/no(marque 0)");
// } while (Convert.ToInt32(Console.ReadLine()) == 1);


//--------------------------------------------------------------------------------------------------
//ejercicio 3
// string input;
// bool esNumValido;
// double numero;
// do
// {
//     Console.WriteLine("Ingrese un numero:");
//     input = Console.ReadLine();
//     esNumValido = double.TryParse(input, out numero);
//     if (!esNumValido)
//     {
//         Console.WriteLine("Numero invalido!");
//     }
// } while (!esNumValido);

// double valorAbs = Math.Abs(numero);
// double cuadrado = numero*numero;
// double raizCuadrada = Math.Sqrt(numero);
// double cos = Math.Cos(numero);
// double sin = Math.Sin(numero);
// int parteEntera = (int)numero;

// Console.WriteLine($"El valor absoluto de {numero} es:{valorAbs}");
// Console.WriteLine($"El cuadrado del numero ingresado es:{cuadrado:F2}");
// Console.WriteLine($"La raiz cuadrada del numero ingresado es:{raizCuadrada:F2}");
// Console.WriteLine($"El coseno del numero ingresado (en radianes) es:{cos:F4}");
// Console.WriteLine($"El seno del numero ingresado (en radianes) es:{sin:F4}");
// Console.WriteLine($"La parte entera del numero ingresado es:{parteEntera}");

// Console.WriteLine("Ingrese un numero:");
// input = Console.ReadLine();
// esvalidonum1 = double.TryParse(input, out double num1);

// Console.WriteLine("Ingrese otro numero:");    
// input = Console.ReadLine();
// esvalidonum2= double.TryParse(input, out double num2);

// if (esvalidonum1 && esvalidonum2){
//     if (num1 > num2){
//         Console.WriteLine($"{num1} es el maximo");
//         Console.WriteLine($"{num2} es el minimo");
//     }
//     else if (num2 > num1){
//         Console.WriteLine($"{num2} es el maximo");
//         Console.WriteLine($"{num1} es el minimo");
//     }
//     else{
//         Console.WriteLine("Los numeros ingresados son iguales. No hay maximo ni minimo");
//     }
// }
// else{
//     Console.WriteLine("Se ingresan numeros invalidos");
// }



//ejercicio 4
// string cadena1, cadena2;

// Console.WriteLine("Ingrese una cadena:");
// cadena1 = Console.ReadLine();
// Console.WriteLine($"La cadena ingresada es: {cadena1}");

// int longitud = cadena1.Length;
// Console.WriteLine($"Longitud:{longitud}");

// Console.WriteLine("\nIngrese otra cadena:");
// cadena2 = Console.ReadLine();
// Console.WriteLine($"La cadena ingresada es: {cadena2}");

// string concatenada = String.Concat(cadena1, cadena2);
// Console.WriteLine($"Cadenas concatenadas: {concatenada}");

// string subcadena = cadena1.Substring(1, 3);
// Console.WriteLine($"Una subcadena de \"{cadena1}\" es \"{subcadena}\"");

// Console.WriteLine("Elementos de la cadena:");
// foreach (char letra in cadena1)
// {
//     Console.WriteLine(letra);
// }

// Console.WriteLine("Ingrese la palabra a buscar en la cadena:");
// string palabra = Console.ReadLine();
// int indice = cadena1.IndexOf(palabra);
// if (indice != -1)
// {
//     Console.WriteLine($"La palabra \"{palabra}\" se encuentra en la posicion {indice} de la cadena \"{cadena1}\"");
// }
// else
// {
//     Console.WriteLine($"No se encontro la palabra {palabra} en la cadena ingresada");
// }

// string mayuscula = cadena1.ToUpper();
// Console.WriteLine($"Cadena en mayusculas: {mayuscula}");
// Console.WriteLine($"Cadena en minuscula: {mayuscula.ToLower()}");

// Console.WriteLine("Ingrese un texto:");
// string texto = Console.ReadLine();
// string[] palabras = texto.Split(" ");
// foreach (string elemento in palabras)
// {
//     Console.WriteLine(elemento);
// }


Console.WriteLine("Ingrese una ecuacion simple (por ejemplo, 582 + 2): ");
string ecuacion = Console.ReadLine();
string[] elementos = ecuacion.Split(" ");

if (int.TryParse(elementos[0], out int a) && int.TryParse(elementos[2], out int b))
{
    switch (elementos[1]) //operador
    {
        case "+":
            Console.WriteLine($"La suma de {a} y {b} es {a + b}");
            break;
        case "-":
            Console.WriteLine($"La diferencia entre {a} y {b} es {a - b}");
            break;
        case "*":
            Console.WriteLine($"El producto de {a} por {b} es {a * b}");
            break;
        case "/":
            if (b != 0)
            {
                Console.WriteLine($"EL cociente entre {a} y {b} es {a / b}");
            }
            else
            {
                Console.WriteLine("Error. Division por cero");
            }
            break;
    }
}