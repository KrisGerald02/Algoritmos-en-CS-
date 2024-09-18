/*
Ejercicio 1: Simulación de tirar dos dados

Escriba un programa en C#, que simule el tirar dos dados. El programa deberá utilizar la función 
rand para tirar el primer dado, y después volverá a utilizar la función rand para tirar el segundo. 
La suma de los valores deberá entonces ser calculada. Nota: en vista de que cada dado puede 
mostrar un valor entero de 1 a 6, entonces la suma de los dos valores variará desde 2 hasta 12, 
siendo 7 la suma más frecuente y 2 y 12 las menos frecuentes. Su programa deberá tirar 36,000 
veces los dos dados. Utilice un arreglo de un subíndice para llevar cuenta del número de veces que aparece 
cada suma posible. Imprima los resultados en un formato tabular. También determine si los totales 
son razonables, por ejemplo, existen seis formas de llegar a un 7, por lo que aproximadamente una 
sexta parte de todas las tiradas deberán ser 7.
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int[] sumFrequencies = new int[13];

        // Tirar los dados 36,000 veces
        for (int i = 0; i < 36000; i++)
        {
            int dado1 = rand.Next(1, 7);
            int dado2 = rand.Next(1, 7);
            int suma = dado1 + dado2;

            sumFrequencies[suma]++;
        }
        Console.WriteLine("Suma\tFrecuencia");
        for (int i = 2; i < sumFrequencies.Length; i++)
        {
            Console.WriteLine($"{i}\t{sumFrequencies[i]}");
        }
    }
}
