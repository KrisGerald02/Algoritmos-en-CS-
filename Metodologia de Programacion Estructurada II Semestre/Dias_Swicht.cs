using System;

   public class Program
   {
      public static void Main(string[] args)
      {
      int dia;

      Console.Clear();
      Console.WriteLine("Ingrese el dia: ");
      dia = int.Parse(Console.ReadLine());
      switch (dia)
      {
         case 1:
            {
               Console.WriteLine("Lunes");
                 break;
            }
         case 2:
            {
               Console.WriteLine("Martes");
               break;
            }
         case 3:
            {
               Console.WriteLine("Miercoles");
               break;
            }
         case 4:
            {
               Console.WriteLine("Jueves");
               break;
            }
         case 5:
            {
               Console.WriteLine("VIernes");
               break;
            }
         case 6:
            {
               Console.WriteLine("Sabado");
               break;
            }
         case 7:
            {
               Console.WriteLine("Domingo");
               break;
            }
         default:
            {
               Console.WriteLine("Fuera de Rango........");
               break;
            }
      }
      Console.WriteLine();
      Console.ReadKey();
      }
   }
