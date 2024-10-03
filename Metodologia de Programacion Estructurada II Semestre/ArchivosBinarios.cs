using System;
using System.IO;

struct Producto
{
    public string Nombre;
    public int Cantidad;
    public decimal Precio;
}

class Artículos
{
    static void Main()
    {
        string archivo = "productos.dat";
        Producto[] productos = new Producto[3];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Producto {i + 1}:");

            string? nombre;
            do
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                if (string.IsNullOrEmpty(nombre))
                {
                    Console.WriteLine("El nombre no puede estar vacío. Intente de nuevo.");
                }
            } while (string.IsNullOrEmpty(nombre));

            productos[i].Nombre = nombre;

            int cantidad;
            do
            {
                Console.Write("Cantidad: ");
                string? inputCantidad = Console.ReadLine();
                if (!int.TryParse(inputCantidad, out cantidad))
                {
                    Console.WriteLine("Entrada inválida. Debe ingresar un número entero. Intente de nuevo.");
                }
            } while (cantidad <= 0);

            productos[i].Cantidad = cantidad;

            decimal precio;
            do
            {
                Console.Write("Precio: ");
                string? inputPrecio = Console.ReadLine();
                if (!decimal.TryParse(inputPrecio, out precio))
                {
                    Console.WriteLine("Entrada inválida. Debe ingresar un número decimal válido. Intente de nuevo.");
                }
            } while (precio <= 0);

            productos[i].Precio = precio;
        }
        using (FileStream fs = new FileStream(archivo, FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            foreach (var producto in productos)
            {
                writer.Write(producto.Nombre);
                writer.Write(producto.Cantidad);
                writer.Write(producto.Precio);
            }
        }

        Console.WriteLine("\nProductos guardados exitosamente en archivo binario.");

        Producto[] productosLeidos = new Producto[5];
        using (FileStream fs = new FileStream(archivo, FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            for (int i = 0; i < 5; i++)
            {
                productosLeidos[i].Nombre = reader.ReadString();
                productosLeidos[i].Cantidad = reader.ReadInt32();
                productosLeidos[i].Precio = reader.ReadDecimal();
            }
        }

        Console.WriteLine("\nProductos leídos desde el archivo binario:");
        foreach (var producto in productosLeidos)
        {
            Console.WriteLine($"Nombre: {producto.Nombre}, Cantidad: {producto.Cantidad}, Precio: {producto.Precio:C}");
        }
        Console.ReadLine();
    }

}
