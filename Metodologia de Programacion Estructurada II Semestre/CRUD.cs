using System;
using System.IO;
namespace Crud;
public struct Producto
{
    public int Id;
    public string Nombre;
    public int Cantidad;
    public decimal Precio;
    public Producto(int id, string nombre, int cantidad, decimal precio)
    {
        Id = id;
        Nombre = nombre;
        Cantidad = cantidad;
        Precio = precio;
    }
}
public class Crud
{
    private const string archivo = "productos.dat";
    public static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- Menú CRUD ---");
            Console.WriteLine("1. Crear Producto");
            Console.WriteLine("2. Leer Productos");
            Console.WriteLine("3. Actualizar Producto");
            Console.WriteLine("4. Eliminar Producto");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: AgregarProducto(); break;
                case 2: LeerProductos(); break;
                case 3: ActualizarProducto(); break;
                case 4: EliminarProducto(); break;
                case 5: break;
                default: break;
            }
        } while (opcion != 5);
    }
    public static void AgregarProducto()
    {
        Console.Write("Ingrese el ID del producto: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese la cantidad de productos: ");
        int cantidad = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el precio del producto: ");
        decimal precio = decimal.Parse(Console.ReadLine());

        Producto producto = new Producto(id, nombre, cantidad, precio);

        using (BinaryWriter writer = new BinaryWriter(File.Open(archivo, FileMode.Append)))
        {
            writer.Write(producto.Id);
            writer.Write(producto.Nombre);
            writer.Write(producto.Cantidad);
            writer.Write(producto.Precio);
        }
        Console.WriteLine("Producto agregado exitosamente.");
    }
    public static void LeerProductos()
    {
        if (!File.Exists(archivo) || new FileInfo(archivo).Length == 0)
        {
            Console.WriteLine("No hay productos registrados.");
            return;
        }

        using (BinaryReader reader = new BinaryReader(File.Open(archivo, FileMode.Open)))
        {
            Console.WriteLine("\nProductos");
            try
            {
                while (true)
                {
                    Producto producto = new Producto()
                    {
                        Id = reader.ReadInt32(),
                        Nombre = reader.ReadString(),
                        Cantidad = reader.ReadInt32(),
                        Precio = reader.ReadDecimal()
                    };
                    Console.WriteLine($"ID: {producto.Id}");
                    Console.WriteLine($"Nombre: {producto.Nombre}");
                    Console.WriteLine($"Cantidad: {producto.Cantidad}");
                    Console.WriteLine($"Precio: {producto.Precio}");
                    Console.WriteLine();
                }
            }
            catch (EndOfStreamException) { }
        }
    }
    public static void ActualizarProducto()
    {
        if (!File.Exists(archivo))
        {
            Console.WriteLine("No hay productos para actualizar.");
            return;
        }

        Console.Write("Ingrese el ID del producto a actualizar: ");
        int idBuscar = int.Parse(Console.ReadLine());
        bool encontrado = false;
        List<Producto> productos = new List<Producto>();

        using (BinaryReader reader = new BinaryReader(File.Open(archivo, FileMode.Open)))
        {
            try
            {
                while (true)
                {
                    Producto producto = new Producto()
                    {
                        Id = reader.ReadInt32(),
                        Nombre = reader.ReadString(),
                        Cantidad = reader.ReadInt32(),
                        Precio = reader.ReadDecimal()
                    };
                    if (producto.Id == idBuscar)
                    {
                        Console.Write("Nuevo nombre: ");
                        string nuevoNombre = Console.ReadLine();
                        Console.Write("Nueva cantidad: ");
                        int nuevaCantidad = int.Parse(Console.ReadLine());
                        Console.Write("Nuevo precio: ");
                        decimal nuevoPrecio = decimal.Parse(Console.ReadLine());

                        producto.Nombre = nuevoNombre;
                        producto.Cantidad = nuevaCantidad;
                        producto.Precio = nuevoPrecio;
                        encontrado = true;
                    }
                    productos.Add(producto);
                }
            }
            catch (EndOfStreamException) { }
        }

        if (encontrado)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(archivo, FileMode.Create)))
            {
                foreach (var prod in productos)
                {
                    writer.Write(prod.Id);
                    writer.Write(prod.Nombre);
                    writer.Write(prod.Cantidad);
                    writer.Write(prod.Precio);
                }
            }
            Console.WriteLine("Producto actualizado con éxito.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    public static void EliminarProducto()
    {
        if (!File.Exists(archivo))
        {
            Console.WriteLine("No hay productos para eliminar.");
            return;
        }

        Console.Write("Ingrese el ID del producto a eliminar: ");
        int idEliminar = int.Parse(Console.ReadLine());
        bool encontrado = false;
        List<Producto> productos = new List<Producto>();

        using (BinaryReader reader = new BinaryReader(File.Open(archivo, FileMode.Open)))
        {
            try
            {
                while (true)
                {
                    Producto producto = new Producto()
                    {
                        Id = reader.ReadInt32(),
                        Nombre = reader.ReadString(),
                        Cantidad = reader.ReadInt32(),
                        Precio = reader.ReadDecimal()
                    };
                    if (producto.Id != idEliminar)
                    {
                        productos.Add(producto);
                    }
                    else
                    {
                        encontrado = true;
                    }
                }
            }
            catch (EndOfStreamException) { }
        }

        if (encontrado)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(archivo, FileMode.Create)))
            {
                foreach (var prod in productos)
                {
                    writer.Write(prod.Id);
                    writer.Write(prod.Nombre);
                    writer.Write(prod.Cantidad);
                    writer.Write(prod.Precio);
                }
            }
            Console.WriteLine("Producto eliminado con éxito.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

}
