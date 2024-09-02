using System;

   public class Program
   {
      public static void Main(string[] args)
      {
      string[] nombres = { "Juan", "Pedro", "Luisa", "Amanda", "Carlos"};

      Console.Clear();

      //siempre se declara una variabe dentro
      //Imprime la lista que contiene los elementos
      foreach (var nombre in nombres)
      {
         //Con el {0} se le indica desde donde iniciara la iteracion
         Console.WriteLine("Nombre: {0}", nombre);
      }
      Console.WriteLine();
      Console.ReadKey();
      }
   }
