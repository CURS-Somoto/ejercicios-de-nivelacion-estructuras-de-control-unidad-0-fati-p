/* Ejercicio 6: Pare e Impar


Escribe un programa que diga si un número
es par o impar.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, introduce un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El numero es par.");
        }
        else
        {
            Console.WriteLine("El numero es impar.");
        }
    }
}
