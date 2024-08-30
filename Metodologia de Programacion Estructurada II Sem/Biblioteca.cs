using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
   static void Main(string[] args)
   {
      string titulo;
      string autor;
      int numPag;
      float precio;
      bool disponibilidad;
      int anioPub;
      //Declaracion y Captura de Variables
      Console.WriteLine("Bienvenido a la Biblioteca");
      Console.WriteLine("Ingrese el nombre del titulo: ");
      titulo= Console.ReadLine();
      //Validacion Titulo
      if (string.IsNullOrEmpty(titulo))
      {
         //Denegamos el Titulo
         Console.BackgroundColor = ConsoleColor.Red;
         Console.WriteLine("Libro no existente :(");
         Console.ReadKey();
         Console.Clear();
         return;
      }
      else
      {
         //Aprobamos el Titulo
         Console.BackgroundColor = ConsoleColor.Green;
         Console.WriteLine("Titulo Aprobado");
         Console.ResetColor();
         return;
      };
      Console.WriteLine("Ingrese el autor: ");
      autor= Console.ReadLine();
      //Validacion Autor
      if(string.IsNullOrEmpty(autor)){
         //Denegamos el autor
         Console.BackgroundColor= ConsoleColor.Red;
         Console.WriteLine("Autor no existente :(");
         Console.ReadKey();
         return;
      }
      else
      {
         //Aprobamos el Autor
         Console.BackgroundColor = ConsoleColor.Green;
         Console.WriteLine("Autor Aprobado");
         Console.ResetColor();
         return;
      };
      Console.WriteLine("Ingrese el numero de paginas: ");
      numPag = int.Parse (Console.ReadLine());//convierte num a string
      Console.WriteLine("Ingrese el precio del libro: ");
      precio= float.Parse (Console.ReadLine());
      Console.WriteLine("¿Esta Disponible?");
      disponibilidad = false;
      Console.WriteLine("Ingrese el anio de publicacion: ");
      anioPub= int.Parse (Console.ReadLine());
      //Validacion anioPub
      if(anioPub <= DateTime.Now.Year)
      {
         //Esta Disponible
         Console.BackgroundColor= ConsoleColor.Green;
         Console.WriteLine("El anio esta Disponible");
         Console.ResetColor();
         return;
      }
        else
      {
         //No Esta Disponible
         Console.BackgroundColor = ConsoleColor.Red;
         Console.WriteLine("El anio no esta Disponible");
         Console.ReadKey();
         return;
      };

   }
}
