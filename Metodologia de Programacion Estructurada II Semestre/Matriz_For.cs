using System;

public class Program
{
   public static void Main(string[] args)
   {
      int fila, nFilas, cols, nCols;
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
      for (fila = 0; fila <  nFilas; fila++)
      {
         for(cols= 0; cols < nCols; cols++)
         {
            Console.Write("Matriz [" + nFilas + "," + cols + "] = ");
            matriz[fila, cols] = int.Parse(Console.ReadLine());

         }
      }
      Console.WriteLine();
      Console.WriteLine("Impresion de Datos");
      Console.WriteLine();
      for (fila = 0;fila < nFilas; fila++) 
      { 
         for(cols= 0; cols < nCols; cols ++)
         {
            Console.Write(matriz[fila, cols]);
         }
         Console.WriteLine();
      }
      Console.WriteLine();
      Console.ReadKey();
   }
}
