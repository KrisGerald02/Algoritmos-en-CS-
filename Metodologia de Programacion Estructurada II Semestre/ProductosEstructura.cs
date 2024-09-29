/* 
 2. Crea un struct llamado “Producto” con campos para ID, Nombre y Precio. Define un 
arreglo de “Producto” con 5 elementos, inicialízalo con datos de ejemplo, y escribe un 
programa que muestre los detalles de los productos en el arreglo
*/

using System;

struct Producto
{
    public int ID;
    public string Nombre;
    public double Precio;
}

class Program
{
    static void Main()
    {
        Producto[] productos = new Producto[5];//mi arreglo son 5 productos

        productos[0] = new Producto { ID = 1, Nombre = "Laptop", Precio = 800.50 };
        productos[1] = new Producto { ID = 2, Nombre = "Smartphone", Precio = 600.99 };
        productos[2] = new Producto { ID = 3, Nombre = "Tablet", Precio = 300.75 };
        productos[3] = new Producto { ID = 4, Nombre = "Monitor", Precio = 250.00 };
        productos[4] = new Producto { ID = 5, Nombre = "Teclado", Precio = 50.25 };

        Console.WriteLine("Detalles de los Productos:");
        foreach (var producto in productos)//for each para mostrar el diccionario
        {
            Console.WriteLine($"ID: {producto.ID}, Nombre: {producto.Nombre}, Precio: ${producto.Precio}");
        }

        Console.ReadKey();
    }
}
