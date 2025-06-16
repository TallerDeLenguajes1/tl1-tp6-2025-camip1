# Respuestas ejercicio 4

## ¿String es una tipo por valor o un tipo por referencia?
En **C#**, la cadena (string) es un tipo de referencia, aunque se comporte de manera similar a un tipo de valor en muchos casos. 

En C#, string es una clase que representa una secuencia de caracteres Unicode. string es un alias para la clase System.String. La clase string es de tipo referencia, lo que significa que las variables de tipo cadena almacenan una referencia a un objeto en la memoria, en lugar de almacenar directamente el valor de la cadena. 

## ¿Qué secuencias de escape tiene el tipo string?
En el tipo string, las secuencias de escape se utilizan para representar caracteres especiales que no pueden ser introducidos directamente en una cadena. Estas secuencias comienzan con una barra invertida **(\)** seguida de un carácter específico, que indica la acción a realizar. 
Algunas secuencias de escape son: 
- \\: Representa una única barra invertida.
- \': Representa una comilla simple.
- \": Representa una comilla doble.
- \n: Representa una nueva línea.
- \r: Representa un retorno de carro.
- \t: Representa una tabulación horizontal.
- \b: Representa un retroceso.
- \f: Representa un salto de página.
- \v: Representa una tabulación vertical.
- \a: Representa una alerta o timbre.
- \0: Representa el carácter nulo.

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
**@ (Literal String):**
Cuando se utiliza antes de una cadena, el carácter **@** indica que la cadena es un literal de cadena. Esto significa que las secuencias de escape (como \n para nueva línea o \t para tabulación) no se interpretarán como tales y se tratarán literalmente, incluyendo las barras invertidas. 

**$ (String Interpolation):**
El carácter $ indica que la cadena es una cadena interpolada. Esto permite insertar expresiones dentro de la cadena, que serán evaluadas y convertidas a texto en tiempo de ejecución.

[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)
