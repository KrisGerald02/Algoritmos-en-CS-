using System;
/*Ejercicio #4 Cálculo del precio con descuento. Escribe un programa que
calcule el precio final de un producto después de aplicar un
descuento según el tipo de cliente:
Cliente Regular: 10% de descuento
Cliente VIP: 20% de descuento
El programa debe pedir el precio original del producto y el tipo de
cliente (Regular o VIP) y mostrar el precio con descuento.
Entrada: Un número decimal para el precio original y una cadena que indique el tipo
de cliente ("Regular" o "VIP").
Salida: El precio final después de aplicar el descuento*/
   public class Program
   {
   public static void Main(string[] args)
   {
      float precio = 25;
      string cliente;
      string producto;
      int cantidad;
      const float descuento10 = 0.10f;
      const float descuento20 = 0.20f;
      float total; 
      float subtotal;
      Console.WriteLine("Ingrese el Tipo de Cliente: ");
      cliente = Console.ReadLine();
      if (cliente == "Regular") {
         Console.WriteLine("Escribe el nombre del producto");
         producto= Console.ReadLine();
         Console.WriteLine("¿Cuantos quiere?");
         cantidad= int.Parse(Console.ReadLine());
         Console.WriteLine("Usted aplica al 10% de descuento por ser Cliente Regular");
         subtotal= precio * cantidad;
         total = subtotal - (descuento10* subtotal);
         Console.Clear();
         Console.WriteLine("Producto: " +  producto);
         Console.WriteLine("Cantidad: " +  cantidad);
         Console.WriteLine("Total: " + total);
      }
      else
      {
         Console.WriteLine("Escribe el nombre del producto");
         producto = Console.ReadLine();
         Console.WriteLine("¿Cuantos quiere?");
         cantidad = int.Parse(Console.ReadLine());
         Console.WriteLine("Usted aplica al 20% de descuento por ser Cliente VIP");
         subtotal = precio * cantidad;
         total = subtotal - (descuento20 * subtotal);
         Console.Clear();
         Console.WriteLine("Producto: " + producto);
         Console.WriteLine("Cantidad: " + cantidad);
         Console.WriteLine("Total: " + total);
      }
      Console.ReadKey();
      }
   }
