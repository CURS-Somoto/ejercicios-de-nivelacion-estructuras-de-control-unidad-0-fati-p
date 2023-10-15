/*Ejercicio 4: Serie factorial


Crea un programa que genere y muestre el
resultado factorial de un numero. */

using System;

class Program
{
    static void Main()
    {
        int numero = Convert.ToInt32(Console.ReadLine());
        long factorial = 1;
        for (int i = 2; i <= numero; i++)
            factorial *= i;
        Console.WriteLine(factorial);
    }
}
