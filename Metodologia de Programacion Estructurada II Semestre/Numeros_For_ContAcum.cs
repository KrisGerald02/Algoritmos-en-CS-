using System;

   public class Program
   {
      public static void Main(string[] args)
      {
      int cont;
      float suma;

      Console.Clear();

      //Buenas practicas iniciar el contador y acumulador en 0
      cont = 0;
      suma = 0;
      for(cont=0; cont <= 10; cont++)
      { 
         Console.WriteLine("Numero: {0}", cont);
         suma += cont;
      }
      Console.WriteLine();
      Console.ReadKey();
      }
   }
