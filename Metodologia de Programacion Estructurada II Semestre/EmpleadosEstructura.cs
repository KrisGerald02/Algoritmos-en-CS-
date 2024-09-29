/* 
Define un struct llamado “Empleado” que contenga un campo Nombre y otro Direccion, 
donde Direccion es otro struc` con campos para Calle, Ciudad, y CódigoPostal. Crea una 
instancia de ”Empleado”, asigna valores a todas las propiedades, y muestra la 
información completa del empleado en la consola.
*/

using System;

struct Direccion
{
    public string Calle;
    public string Ciudad;
    public string CodigoPostal;
}

struct Empleado
{
    public string Nombre;
    public Direccion Direccion; //instancia
}

class Program
{
    static void Main()
    {
        Empleado empleado;//instancia

        empleado.Nombre = " Kris Villalta";
        empleado.Direccion.Calle = "Mayoreo";
        empleado.Direccion.Ciudad = "Managua";
        empleado.Direccion.CodigoPostal = "C123";
        Console.WriteLine("Información del Empleado:");
        Console.WriteLine($"Nombre: {empleado.Nombre}");
        Console.WriteLine($"Calle: {empleado.Direccion.Calle}");
        Console.WriteLine($"Ciudad: {empleado.Direccion.Ciudad}");
        Console.WriteLine($"Código Postal: {empleado.Direccion.CodigoPostal}");

        Console.ReadKey();
    }
}
