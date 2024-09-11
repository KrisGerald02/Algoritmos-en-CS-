using System;

public class Program
{
    public static void Main(string[] args)
    {
        int i, fila, nFilas, cols, nCols, nElementos;
        float suma, promedio;

        // Arreglo en String de Nombres
        Console.WriteLine("Lista de Elementos de Arreglo");
        Console.WriteLine();
        Console.Write("Ingrese la cantidad de estudiantes: ");
        nElementos = int.Parse(Console.ReadLine());

        string[] nombres = new string[nElementos];
        Console.WriteLine();
        Console.WriteLine("Ingreso de Datos");
        Console.WriteLine();
        for (i = 0; i < nElementos; i++)
        {
            Console.Write("Nombre del estudiante [" + i + "] = ");
            nombres[i] = Console.ReadLine();
        }
        Console.WriteLine();
        Console.Clear();

        // Matriz de Notas
        Console.WriteLine("Lista de Elementos de la Matriz");
        Console.WriteLine();
        Console.Write("Ingrese la cantidad de asignaturas: ");
        nFilas = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad de notas por asignatura: ");
        nCols = int.Parse(Console.ReadLine());
        Console.WriteLine();
        
        int[,] matriz = new int[nFilas, nCols];
        Console.WriteLine("Ingreso de Datos");
        Console.WriteLine();
        for (fila = 0; fila < nFilas; fila++)
        {
            for (cols = 0; cols < nCols; cols++)
            {
                Console.Write("Nota [" + fila + "," + cols + "] = ");
                matriz[fila, cols] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();
        Console.WriteLine("Impresión de Datos");
        Console.WriteLine();
        
        for (i = 0; i < nElementos; i++)
        {
            suma = 0;
            Console.WriteLine($"El estudiante {nombres[i]} tiene las siguientes notas:");

            for (fila = 0; fila < nCols; fila++)
            {
                Console.Write($"Nota {fila + 1}: ");
                for (cols = 0; cols < nFilas; cols++)
                {
                    if (cols == i) // Solo se imprimen las notas correspondientes al estudiante actual
                    {
                        Console.Write(matriz[cols, fila] + " ");
                        suma += matriz[cols, fila];
                    }
                }
                Console.WriteLine();
            }
            
            promedio = suma / nCols;
            Console.WriteLine($"El promedio de las notas de {nombres[i]} es: {promedio:F2}");
            Console.WriteLine();
        }
    }
}
