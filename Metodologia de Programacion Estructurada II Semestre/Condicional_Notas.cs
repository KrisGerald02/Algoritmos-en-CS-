using System;

   public class Program
   {
      public static void Main(string[] args)
      {
      string nombre;
      float notaFinal;

      Console.Clear();
      Console.WriteLine("Ingrese el nombre: ");
      nombre= Console.ReadLine();
      //Sirve para solo imprimir sin salto de linea
      Console.Write("Ingrese la nota: ");
      notaFinal= float.Parse(Console.ReadLine());

      if (notaFinal < 70)
         Console.WriteLine("Reprobado");
      else
         if (notaFinal >= 70 && notaFinal <= 79)
         Console.WriteLine("Bueno");
         else
            if (notaFinal >= 80 && notaFinal <= 89)
            Console.WriteLine("Muy Bueno");
            else
               if (notaFinal >= 90 && notaFinal <= 100)
               Console.WriteLine("Excelente");
      Console.WriteLine();
      Console.ReadKey();
   }
   }

