using System;

public class Program
{
   public static void Main(string[] args)
   {
      //Arreglo en String de Nombres
      int i;
      int nElementos;
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
         //Metodos sobrecargados de POO
         //El + convierte el numero a cadena
         //+ actua como sumador y concatenador de cadena
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

      //Matriz Flotante

    
      Console.WriteLine();
      Console.ReadKey();
   }
}
