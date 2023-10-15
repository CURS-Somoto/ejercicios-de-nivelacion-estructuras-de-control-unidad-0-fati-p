/*Ejercicio 3: Numero primo


Escribe un
programa que determine si un número dado es primo o no.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, introduce un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool esPrimo = true;

        if (numero == 1)
        {
            esPrimo = false;
        }
        else
        {
            for (int i = 2; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }

        if (esPrimo)
        {
            Console.WriteLine("El numero es primo.");
        }
        else
        {
            Console.WriteLine("El numero no es primo.");
        }
    }
}
