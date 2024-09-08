/*Escriba un programa que imprima todos los números múltiplos de 5 entre 1 
 y un número ingresado por el usuario. Utilice un ciclo for
 para iterar sobre los números y una estructura if para verificar si cada número es múltiplo de 5.*/
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Los multiplos de 5 entre 1 y " + numero + " son:");

        for (int i = 1; i <= numero; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
