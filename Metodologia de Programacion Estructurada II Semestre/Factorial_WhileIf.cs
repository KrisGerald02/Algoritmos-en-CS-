/*Escriba un programa que calcule el factorial de un número ingresado por el usuario utilizando un ciclo while. 
Use una estructura if para manejar el caso en que el número ingresado es negativo, 
ya que el factorial no está definido para números negativos */
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());
        if (numero < 0)
        {
            Console.WriteLine("Ingresa un numero positivo.");
        }
        else
        {
            /*use long pq el factorial de números relativamente
            pequeños puede crecer muy rápidamente y exceder el rango de un int*/
            long factorial = 1;
            int i = 1;
            while (i <= numero)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine("El factorial de " + numero + " es: " + factorial);
        }
    }
}
