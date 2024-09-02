using System;

   public class Program
   {
      public static void Main(string[] args)
      {
      int anio;
      Console.WriteLine("Ingrese un anio: ");
      anio = int.Parse(Console.ReadLine()); 
      Console.Clear();

      //siempre se declara una variabe dentro
      //Imprime la lista que contiene los elementos
      if (anio % 4 ==0 ) {  
         //divisible por4
         //no es divisible por 100 amenos que sea divisible por 400
         Console.WriteLine("El anio esbisiesto");
      }
      else
         Console.WriteLine("El anio no es bisiesto");

      Console.WriteLine();
      Console.ReadKey();
      }
   }
