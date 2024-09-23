using System;

class BuubleSort
{
    static void Main()
    {
        Console.Write("¿Cuántos números deseas ordenar?: ");
        int n = int.Parse(Console.ReadLine());

        int[] arreglo = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingresa el número en la posición {i + 1}: ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }

        n = arreglo.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    int temp = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Arreglo ordenado:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arreglo[i]);
        }

        Console.ReadKey();
    }
}
