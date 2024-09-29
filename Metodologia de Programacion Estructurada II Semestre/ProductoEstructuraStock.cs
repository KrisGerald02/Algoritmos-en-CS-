/* 
Modifica el struct “Producto” para incluir un campo CantidadEnStock. Escribe un 
programa que busque los productos en el arreglo que tienen existencia baja ,es 
decir, que la cantidad en stock es menor o igual que 5. Muestre la lista de los 
productos que cumplen la condición de búsqueda
*/
using System;

struct Producto
{
    public int ID;
    public string Nombre;
    public double Precio;
    public int CantidadEnStock; 
}

class Program
{
    static void Main()
    {
        Producto[] productos = new Producto[5];

        productos[0] = new Producto { ID = 1, Nombre = "Laptop", Precio = 800.50, CantidadEnStock = 3 };
        productos[1] = new Producto { ID = 2, Nombre = "Smartphone", Precio = 600.99, CantidadEnStock = 8 };
        productos[2] = new Producto { ID = 3, Nombre = "Tablet", Precio = 300.75, CantidadEnStock = 5 };
        productos[3] = new Producto { ID = 4, Nombre = "Monitor", Precio = 250.00, CantidadEnStock = 2 };
        productos[4] = new Producto { ID = 5, Nombre = "Teclado", Precio = 50.25, CantidadEnStock = 12 };

        Console.WriteLine("Productos con existencia baja (Cantidad en stock <= 5):");

        foreach (var producto in productos)//filtro con lower
        {
            if (producto.CantidadEnStock <= 5)
            {
                Console.WriteLine($"ID: {producto.ID}, Nombre: {producto.Nombre}, Precio: ${producto.Precio}, Cantidad en Stock: {producto.CantidadEnStock}");
            }
        }

        Console.ReadKey();
    }
}

