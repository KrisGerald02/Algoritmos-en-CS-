using System;
using System.Collections.Generic;

class Producto
{
    public int codigo;
    public string nombre;
    public int cantidad;
    public decimal precio;

    public Producto(int codigoProducto, string nombreProducto, int cantidadProducto, decimal precioProducto)
    {
        codigo = codigoProducto;
        nombre = nombreProducto;
        cantidad = cantidadProducto;
        precio = precioProducto;
    }

    public string Descripcion()
    {
        return $"Código: {codigo}, Nombre: {nombre}, Cantidad: {cantidad}, Precio: {precio:C}";
    }
}

class Inventario
{
    private List<Producto> productos = new List<Producto>();

    public void AgregarProducto()
    {
        Console.Write("Ingrese código: ");
        int codigoProducto = int.Parse(Console.ReadLine());
        Console.Write("Ingrese nombre: ");
        string nombreProducto = Console.ReadLine();
        Console.Write("Ingrese cantidad: ");
        int cantidadProducto = int.Parse(Console.ReadLine());
        Console.Write("Ingrese precio: ");
        decimal precioProducto = decimal.Parse(Console.ReadLine());

        productos.Add(new Producto(codigoProducto, nombreProducto, cantidadProducto, precioProducto));
        Console.WriteLine("Producto agregado con éxito.");
    }

    public void EliminarProducto()
    {
        Console.Write("Ingrese código del producto a eliminar: ");
        int codigoProducto = int.Parse(Console.ReadLine());

        // Buscar producto manualmente
        for (int i = 0; i < productos.Count; i++)
        {
            if (productos[i].codigo == codigoProducto)
            {
                productos.RemoveAt(i);
                Console.WriteLine("Producto eliminado.");
                return;
            }
        }
        Console.WriteLine("Producto no encontrado.");
    }

    public void ModificarProducto()
    {
        Console.Write("Ingrese código del producto a modificar: ");
        int codigoProducto = int.Parse(Console.ReadLine());

        // Buscar producto manualmente
        for (int i = 0; i < productos.Count; i++)
        {
            if (productos[i].codigo == codigoProducto)
            {
                Console.Write("Ingrese nuevo nombre: ");
                productos[i].nombre = Console.ReadLine();
                Console.Write("Ingrese nueva cantidad: ");
                productos[i].cantidad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese nuevo precio: ");
                productos[i].precio = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Producto modificado.");
                return;
            }
        }
        Console.WriteLine("Producto no encontrado.");
    }

    public void ConsultarProducto()
    {
        Console.Write("Ingrese código del producto a consultar: ");
        int codigoProducto = int.Parse(Console.ReadLine());

        // Buscar producto manualmente
        for (int i = 0; i < productos.Count; i++)
        {
            if (productos[i].codigo == codigoProducto)
            {
                Console.WriteLine(productos[i].Descripcion());
                return;
            }
        }
        Console.WriteLine("Producto no encontrado.");
    }

    public void MostrarTodosLosProductos()
    {
        if (productos.Count > 0)
        {
            Console.WriteLine("Listado de productos en inventario:");
            foreach (Producto producto in productos)
            {
                Console.WriteLine(producto.Descripcion());
            }
        }
        else
        {
            Console.WriteLine("El inventario está vacío.");
        }
    }
}

class Program
{
    static void Main()
    {
        Inventario inventario = new Inventario();
        int opcion;

        do
        {
            Console.WriteLine("\nMenú de Inventario:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Modificar producto");
            Console.WriteLine("4. Consultar producto");
            Console.WriteLine("5. Mostrar todos los productos");
            Console.WriteLine("6. Salir");
            Console.Write("Elija una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    inventario.AgregarProducto();
                    break;
                case 2:
                    inventario.EliminarProducto();
                    break;
                case 3:
                    inventario.ModificarProducto();
                    break;
                case 4:
                    inventario.ConsultarProducto();
                    break;
                case 5:
                    inventario.MostrarTodosLosProductos();
                    break;
                case 6:
                    Console.WriteLine("Saliendo del programa.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 6);
    }
}

