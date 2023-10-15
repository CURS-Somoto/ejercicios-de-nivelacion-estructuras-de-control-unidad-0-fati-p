/*
Ejercicio 10: Determinar si un Número es
Positivo, Negativo o Cero


Escribe un programa en C# que determine si
un número entero dado es positivo, negativo o cero.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, introduce un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("El numero es positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El numero es negativo.");
        }
        else
        {
            Console.WriteLine("El numero es cero.");
        }
    }
}

