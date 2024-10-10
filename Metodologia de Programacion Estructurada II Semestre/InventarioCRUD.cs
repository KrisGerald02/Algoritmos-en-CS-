/*Crea un programa que simule la gestión de un inventario en una 
tienda. Utiliza un menú para agregar, eliminar, modificar y 
consultar productos en el inventario. Cada producto tendrá un 
código, nombre, cantidad y precio.
1. Menú de opciones:
2. Agregar producto
3. Eliminar producto
4. Modificar producto
5. Consultar producto
6. Mostrar todos los productos
7. Salir
El programa debe almacenar los productos en una lista o 
estructura similar y permitir al usuario realizar las operaciones 
hasta que elija la opción de salir*/
using System;
using System.IO;

class Producto
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }

    public Producto(int codigo, string nombre, int cantidad, double precio)
    {
        Codigo = codigo;
        Nombre = nombre;
        Cantidad = cantidad;
        Precio = precio;
    }

    public override string ToString()
    {
        return $"{Codigo},{Nombre},{Cantidad},{Precio}";
    }

    public static Producto FromString(string data)
    {
        var partes = data.Split(',');
        return new Producto(
            int.Parse(partes[0]),
            partes[1],
            int.Parse(partes[2]),
            double.Parse(partes[3])
        );
    }
}

class Inventario
{
    const string archivoInventario = "inventario.txt";
    static Producto[] productos = new Producto[100]; // Limitar inventario a 100 productos
    static int contadorProductos = 0;

    static void Main(string[] args)
    {
        CargarInventario();

        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Modificar producto");
            Console.WriteLine("4. Consultar producto");
            Console.WriteLine("5. Mostrar todos los productos");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AgregarProducto();
                    break;
                case "2":
                    EliminarProducto();
                    break;
                case "3":
                    ModificarProducto();
                    break;
                case "4":
                    ConsultarProducto();
                    break;
                case "5":
                    MostrarTodosLosProductos();
                    break;
                case "6":
                    salir = true;
                    GuardarInventario();
                    Console.WriteLine("Gracias por usar el sistema.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
            if (!salir)
            {
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void AgregarProducto()
    {
        if (contadorProductos >= 100)
        {
            Console.WriteLine("El inventario está lleno.");
            return;
        }

        Console.Write("Ingrese el código del producto: ");
        if (int.TryParse(Console.ReadLine(), out int codigo))
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la cantidad del producto: ");
            if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
            {
                Console.Write("Ingrese el precio del producto: ");
                if (double.TryParse(Console.ReadLine(), out double precio) && precio > 0)
                {
                    productos[contadorProductos] = new Producto(codigo, nombre, cantidad, precio);
                    contadorProductos++;
                    Console.WriteLine("Producto agregado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Precio inválido.");
                }
            }
            else
            {
                Console.WriteLine("Cantidad inválida.");
            }
        }
        else
        {
            Console.WriteLine("Código inválido.");
        }
    }

    static void EliminarProducto()
    {
        Console.Write("Ingrese el código del producto a eliminar: ");
        if (int.TryParse(Console.ReadLine(), out int codigo))
        {
            int index = BuscarProducto(codigo);
            if (index != -1)
            {
                for (int i = index; i < contadorProductos - 1; i++)
                {
                    productos[i] = productos[i + 1]; // Desplazar productos
                }
                productos[contadorProductos - 1] = null; // Eliminar referencia al último producto
                contadorProductos--;
                Console.WriteLine("Producto eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Código inválido.");
        }
    }

    static void ModificarProducto()
    {
        Console.Write("Ingrese el código del producto a modificar: ");
        if (int.TryParse(Console.ReadLine(), out int codigo))
        {
            int index = BuscarProducto(codigo);
            if (index != -1)
            {
                Producto producto = productos[index];

                Console.Write("Ingrese el nuevo nombre del producto (actual: {0}): ", producto.Nombre);
                producto.Nombre = Console.ReadLine();

                Console.Write("Ingrese la nueva cantidad del producto (actual: {0}): ", producto.Cantidad);
                if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
                {
                    producto.Cantidad = cantidad;

                    Console.Write("Ingrese el nuevo precio del producto (actual: {0:C2}): ", producto.Precio);
                    if (double.TryParse(Console.ReadLine(), out double precio) && precio > 0)
                    {
                        producto.Precio = precio;
                        Console.WriteLine("Producto modificado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Precio inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("Cantidad inválida.");
                }
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Código inválido.");
        }
    }

    static void ConsultarProducto()
    {
        Console.Write("Ingrese el código del producto a consultar: ");
        if (int.TryParse(Console.ReadLine(), out int codigo))
        {
            int index = BuscarProducto(codigo);
            if (index != -1)
            {
                Console.WriteLine(productos[index]);
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Código inválido.");
        }
    }

    static void MostrarTodosLosProductos()
    {
        if (contadorProductos > 0)
        {
            Console.WriteLine("Inventario de productos:");
            for (int i = 0; i < contadorProductos; i++)
            {
                Console.WriteLine(productos[i]);
            }
        }
        else
        {
            Console.WriteLine("El inventario está vacío.");
        }
    }

    static int BuscarProducto(int codigo)
    {
        for (int i = 0; i < contadorProductos; i++)
        {
            if (productos[i].Codigo == codigo)
            {
                return i;
            }
        }
        return -1;
    }

    static void GuardarInventario()
    {
        using (StreamWriter writer = new StreamWriter(archivoInventario))
        {
            for (int i = 0; i < contadorProductos; i++)
            {
                writer.WriteLine(productos[i].ToString());
            }
        }
    }

    static void CargarInventario()
    {
        if (File.Exists(archivoInventario))
        {
            using (StreamReader reader = new StreamReader(archivoInventario))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null && contadorProductos < 100)
                {
                    productos[contadorProductos] = Producto.FromString(linea);
                    contadorProductos++;
                }
            }
        }
    }
}
