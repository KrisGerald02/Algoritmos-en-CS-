using System;

class Program
{
   static void Main(string[] args)
   {
      string titulo;
      string autor;
      int numPag;
      float precio;
      string disponibilidad;
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
      };
      Console.WriteLine("Ingrese el numero de paginas: ");
      numPag = int.Parse (Console.ReadLine());//convierte num a string
      // Validacion numPag si es neg bai si es + oli
      //if (!string.IsNullOrEmpty(numPag)) negativo
      if (numPag >= 0)
      {
         //Aprobamos el numPag
         Console.BackgroundColor = ConsoleColor.Green;
         Console.WriteLine("Numero de Paginas Aprobado");
         Console.ResetColor();
      }
      else
      {
         //Aprobamos el Autor
         Console.BackgroundColor = ConsoleColor.Red;
         Console.WriteLine("Ingrese un numero positivo");
         Console.ReadKey();
         return;
      };
      Console.WriteLine("Ingrese el precio del libro: ");
      precio= float.Parse (Console.ReadLine());
      //Validacion Precio
      if (precio >= 0)
      {
         //Aprobamos el Precio
         Console.BackgroundColor = ConsoleColor.Green;
         Console.WriteLine("Precio Aprobado");
         Console.ResetColor();
      }
      else
      {
         //Aprobamos el Autor
         Console.BackgroundColor = ConsoleColor.Red;
         Console.WriteLine("Ingrese un numero positivo");
         Console.ReadKey();
         return;
      };
      Console.WriteLine("¿Esta Disponible?");
      Console.WriteLine("Para verificar su Disponibilidad ingrese S/N o s/n");
      disponibilidad = Console.ReadLine();
      if (disponibilidad.ToUpper() == "S")
      {
         //Aprobamos el Libro
         Console.BackgroundColor = ConsoleColor.Green;
         Console.WriteLine("Libro Disponible");
         Console.ResetColor();
      }
      else if(disponibilidad.ToUpper() == "N")
      {
         //Aprobamos el Libro
         Console.BackgroundColor = ConsoleColor.Red;
         Console.WriteLine("El libro no esta Disponible");
         Console.ReadKey();
         return;
      };

      Console.WriteLine("Ingrese el anio de publicacion: ");
      anioPub= int.Parse (Console.ReadLine());
      //Validacion anioPub
      if(anioPub <= DateTime.Now.Year)
      {
         //Esta Disponible
         Console.BackgroundColor= ConsoleColor.Green;
         Console.WriteLine("El anio esta Disponible");
         Console.ResetColor();
      }
        else
      {
         //No Esta Disponible
         Console.BackgroundColor = ConsoleColor.Red;
         Console.WriteLine("El anio no esta Disponible");
         Console.ReadKey();
      };
      
      //Salida Final
      Console.Clear();
      Console.WriteLine("El libro se llama: {0}", titulo);
      Console.WriteLine("El autor es: {0}", autor);
      Console.WriteLine("Tiene: {0}", numPag, "paginas");
      Console.WriteLine("Tiene un precio de $: {0}", precio);
      Console.WriteLine("Se publico en : {0}", anioPub);
      Console.WriteLine("Disponibilidad: {0}", disponibilidad);
      Console.ReadKey();
      return;
   }
}
