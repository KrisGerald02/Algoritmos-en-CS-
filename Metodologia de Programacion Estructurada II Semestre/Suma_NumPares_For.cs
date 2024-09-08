/*. Escriba un programa que calcule la suma de todos los números pares entre 1 y 
un número ingresado por el usuario. Utilice un ciclo for para iterar sobre los 
números y una estructura if para verificar si cada número es par.
*/
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());
        int suma = 0;
        for (int i = 1; i <= numero; i++)
        {
            if (i % 2 == 0)
            {
                suma += i;
            }
        }

        Console.WriteLine("La suma de todos los números pares entre 1 y " + numero + " es: " + suma);
    }
}
