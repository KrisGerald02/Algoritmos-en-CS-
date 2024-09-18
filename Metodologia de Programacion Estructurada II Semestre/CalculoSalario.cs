//Ejercicio 4
// Instrucciones:
// 1. Este programa calcula el salario semanal de los vendedores basado en un salario base
//    de $200 más una comisión del 9% sobre las ventas brutas.
// 2. Luego, clasifica el salario de los vendedores en diferentes rangos y cuenta cuántos
//    vendedores caen en cada uno de esos rangos.
// 3. El usuario puede ingresar los montos de ventas para cada vendedor.
// 4. El salario se trunca a una cantidad entera antes de ser clasificado en los rangos.
// 5. Los rangos de salario son:
//    - $200-$299
//    - $300-$399
//    - $400-$499
//    - $500-$599
//    - $600-$699
//    - $700-$799
//    - $800-$899
//    - $900-$999
//    - $1000 o superior

using System;

public class ProgramaVentas
{
    public static void Main()
    {
        // Arreglo de contadores para cada rango de salarios
        int[] contadores = new int[9];
        
        // Solicitar el número de vendedores
        Console.Write("Ingresa el número de vendedores: ");
        int numVendedores = int.Parse(Console.ReadLine());
        
        // Procesar cada vendedor
        for (int i = 0; i < numVendedores; i++)
        {
            // Solicitar las ventas brutas de cada vendedor
            Console.Write($"Ingresa las ventas brutas del vendedor {i + 1}: ");
            double ventas = double.Parse(Console.ReadLine());
            
            // Calcular salario total: $200 + 9% de las ventas brutas
            double salario = 200 + (ventas * 0.09);
            
            // Truncar a cantidad entera
            int salarioEntero = (int)salario;
            
            // Determinar en qué rango cae el salario
            if (salarioEntero >= 1000)
            {
                contadores[8]++; // Rango $1000 o superior
            }
            else if (salarioEntero >= 900)
            {
                contadores[7]++; // Rango $900-$999
            }
            else if (salarioEntero >= 800)
            {
                contadores[6]++; // Rango $800-$899
            }
            else if (salarioEntero >= 700)
            {
                contadores[5]++; // Rango $700-$799
            }
            else if (salarioEntero >= 600)
            {
                contadores[4]++; // Rango $600-$699
            }
            else if (salarioEntero >= 500)
            {
                contadores[3]++; // Rango $500-$599
            }
            else if (salarioEntero >= 400)
            {
                contadores[2]++; // Rango $400-$499
            }
            else if (salarioEntero >= 300)
            {
                contadores[1]++; // Rango $300-$399
            }
            else
            {
                contadores[0]++; // Rango $200-$299
            }
        }

        // Mostrar los resultados
        Console.WriteLine("\nRangos de salarios:");
        Console.WriteLine("$200-$299: " + contadores[0]);
        Console.WriteLine("$300-$399: " + contadores[1]);
        Console.WriteLine("$400-$499: " + contadores[2]);
        Console.WriteLine("$500-$599: " + contadores[3]);
        Console.WriteLine("$600-$699: " + contadores[4]);
        Console.WriteLine("$700-$799: " + contadores[5]);
        Console.WriteLine("$800-$899: " + contadores[6]);
        Console.WriteLine("$900-$999: " + contadores[7]);
        Console.WriteLine("$1000 o superior: " + contadores[8]);
    }
}
