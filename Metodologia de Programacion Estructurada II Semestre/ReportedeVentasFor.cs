/*
Ejercicio 3: Resumen de Ventas por Vendedor y Producto

Una empresa tiene 4 vendedores (1 a 4) que venden 5 productos diferentes (1 a 5). 
Cada vendedor emite un reporte diario por cada tipo de producto vendido, que incluye el número 
del vendedor, el número del producto y el valor total en dólares vendido ese día.

Escriba un programa que lea la información de ventas del mes anterior y resuma las ventas totales 
por vendedor y por producto. Los resultados deberán almacenarse en un arreglo bidimensional y 
se imprimirán en formato tabular.
*/

using System;

class Program
{
    static void Main()
    {
        decimal[,] ventas = new decimal[5, 6];

        Console.WriteLine("Ingrese la información de ventas: ");
        for (int i = 0; i < 5; i++) // 5 productos
        {
            for (int j = 0; j < 4; j++) // 4 vendedores
            {
                Console.Write($"Ventas del producto {i + 1} por el vendedor {j + 1}: ");
                ventas[i, j] = decimal.Parse(Console.ReadLine());
                ventas[i, 4] += ventas[i, j]; // Sumar ventas por producto
                ventas[4, j] += ventas[i, j]; // Sumar ventas por vendedor
            }
        }

        Console.WriteLine("\nResumen de ventas (en dólares):");
        Console.WriteLine("Producto\tVendedor 1\tVendedor 2\tVendedor 3\tVendedor 4\tTotal Producto");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Producto {i + 1}\t");
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{ventas[i, j]}\t\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Total Vendedor\t");
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{ventas[4, j]}\t\t");
        }
        Console.WriteLine();
    }
}