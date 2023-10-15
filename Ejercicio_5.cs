/*Ejercicio 5: Positivo o negativo


Escribe un programa en C# que determine si
un número entero dado es positivo, negativo o cero.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, introduce un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("El número es positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El número es negativo.");
        }
        else
        {
            Console.WriteLine("El número es cero.");
        }
    }
}
