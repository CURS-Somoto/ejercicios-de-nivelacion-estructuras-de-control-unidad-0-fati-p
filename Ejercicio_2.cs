/*Ejercicio 2: Suma de Dígitos


Crea un programa que calcule y muestre la
suma de los dígitos de un número ingresado por el usuario.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, introduce el primer numero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Por favor, introduce el segundo numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int suma = numero1 + numero2;

        Console.WriteLine("La suma de los dos numeros es: " + suma);
    }
}
