/*Escriba un programa que lea una serie de números ingresados por el
 usuario hasta que se ingrese un número 0 (cero). Utilice un ciclo 
 for para leer los números y una estructura if para determinar el 
 número máximo y el mínimo de la serie*/
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num;
        int max = int.MinValue;
        int min = int.MaxValue;
        Console.WriteLine("Ingrese una serie deos  nmeros (ingrese 0 para finalizar):");
        for (; ; )//for infinito se interrumpe cuando el usuario ingresa el número 0.
        {
            num = int.Parse(Console.ReadLine());

            if (num == 0)
                break;
            if (num > max)
                max = num;
            if (num < min)
                min  = num;
        }
        if (max == int.MinValue && min == int.MaxValue)
        {
            Console.WriteLine("Fin del programa.");
        }
        else
        {
            Console.WriteLine("El numero maximo es: " + max);
            Console.WriteLine("El numero minimo es: " + min);
        }
    }
}
