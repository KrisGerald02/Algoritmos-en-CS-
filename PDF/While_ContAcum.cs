using System;

   public class Program
   {
      public static void Main(string[] args)
      {
      int cont;
      float suma;

      Console.Clear();

      //Buenas practicas iniciar el contador y acumulador en 0
      cont = 1;
      suma = 0;
      while(cont <=10)
      { 
         Console.WriteLine("Numero: {0}", cont);
         suma= suma + cont;
         cont++;
      }
      Console.WriteLine("Suma de los Numero: {0}", suma);
      Console.WriteLine();
      Console.ReadKey();
      }
   }
