using System;
using System.Diagnostics.CodeAnalysis;

public class Program
{
   public static void Main(string[] args)
   {

         //Arreglo en String de Nombres
         int i, fila, nFilas, cols, nCols, nElementos;
         float suma, promedio;
         Console.WriteLine("Lista de Elementos de Arreglo");
         Console.WriteLine();
         Console.Write("Ingrese la cantidad de elementos del arreglo: ");
         nElementos = int.Parse(Console.ReadLine());

         string[] nombres = new string[nElementos];
         Console.WriteLine();
         Console.WriteLine("Ingreso de Datos");
         Console.WriteLine();
         for (i = 0; i < nElementos; i++)
         {
            Console.Write("Arreglo[" + i + "] = ");
            nombres[i] = Console.ReadLine();
         }
         Console.WriteLine();
         Console.WriteLine("Impresion de Datos");
         Console.WriteLine();
         for (i = 0; i < nElementos; i++)
         {
            Console.WriteLine(nombres[i]);
         }
         Console.WriteLine();
         Console.Clear();
      //Matriz Flotante
         Console.WriteLine("Lista de Elementos de la Matriz");
         Console.WriteLine();
         Console.Write("Ingrese la cantidad de filas: ");
         nFilas = int.Parse(Console.ReadLine());
         Console.Write("Ingrese la cantidad de columnas: ");
         nCols = int.Parse(Console.ReadLine());
         Console.WriteLine();
         int[,] matriz = new int[nFilas, nCols];
         Console.WriteLine("Ingreso de Datos");
         Console.WriteLine();
         for (fila = 0; fila < nFilas; fila++)
         {
            for (cols = 0; cols < nCols; cols++)
            {
            Console.Write("Matriz [" + nFilas + "," + cols + "] = ");
            matriz[fila, cols] = int.Parse(Console.ReadLine());

            }
         }
         Console.WriteLine();
         Console.WriteLine("Impresion de Datos");
         Console.WriteLine();
         for (fila = 0; fila < nFilas; fila++)
         {
            for (cols = 0; cols < nCols; cols++)
            {
               Console.Write(matriz[fila, cols]);
            }
            Console.WriteLine();
         }
      }
   }
