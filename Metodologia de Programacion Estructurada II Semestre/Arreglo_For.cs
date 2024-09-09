using System;

public class Program
{
   public static void Main(string[] args)
   {
      int i;
      int nElementos;
      Console.WriteLine("Lista de Elementos de Arreglo");
      Console.WriteLine("Ingrese la cantidad de elementos del arreglo: ");
      nElementos= int.Parse(Console.ReadLine());
      //Arreglo
      //Primer int para indicar creacion de arreglo
      //Segundo int para indicar el rango del arreglo
      //new para instanciar ya que la tipologia de datos son clases
      int[] arreglo= new int[nElementos];
      Console.WriteLine("Ingreso de Datos");
      for(i = 0; i< nElementos; i++)
      {
         //Metodos sobrecargados de POO
         //El + convierte el numero a cadena
         //+ actua como sumador y concatenador de cadena
         Console.Write("Arreglo[" + i + "] = ");
         arreglo[i] = int.Parse(Console.ReadLine());
      }
      Console.WriteLine("Impresion de Datos");
      for (i = 0; i < nElementos; i++)
      {
         Console.WriteLine(arreglo[i]);
      }
      Console.WriteLine();
      Console.ReadKey();
   }
}
