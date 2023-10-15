/*
Ejercicio 9: Mayor de Dos Números


Dado dos números, muestra el número mayor
utilizando una estructura if

*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, introduce el primer numero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Por favor, introduce el segundo numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine("El numero mayor es: " + numero1);
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine("El numero mayor es: " + numero2);
        }
        else
        {
            Console.WriteLine("Los numeros son iguales.");
        }
    }
}

