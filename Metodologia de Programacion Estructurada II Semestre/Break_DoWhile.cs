using System;

   public class Program
   {
      public static void Main(string[] args)
      {
      int n;
      char resp; 
      Console.WriteLine("Uso de Entrada con Iteraciones (Si/No)");
      n = int.Parse(Console.ReadLine());

      do
      {
         Console.WriteLine("Desea ingresar otro numero (S= Si || N= No): ");
         resp = char.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese el numero: ");
         n = int.Parse(Console.ReadLine());

         //Para no
         if (resp == 'N' || resp == 'N')
         resp = char.Parse(Console.ReadLine());
         Console.WriteLine("Fin del Programa");
            break;
        
      } while (resp == 'S' || resp == 's');
      Console.ReadKey();
      }
   }
