/* 
Usa el struct “Empleado” del ejercicio anterior. Escribe un programa que filtre los 
empleados que viven en una ciudad específica y muestre la información de estos 
empleados.
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
    public Direccion Direccion; // instancia
}

class Program
{
    static void Main()
    {
        Empleado[] empleados = new Empleado[3];

        empleados[0] = new Empleado
        {
            Nombre = "Kris Villalta",
            Direccion = new Direccion
            {
                Calle = "Mayoreo",
                Ciudad = "Managua",
                CodigoPostal = "C123"
            }
        };

        empleados[1] = new Empleado
        {
            Nombre = "Ana Torres",
            Direccion = new Direccion
            {
                Calle = "Avenida Libertador",
                Ciudad = "Buenos Aires",
                CodigoPostal = "C1001AB"
            }
        };

        empleados[2] = new Empleado
        {
            Nombre = "Luis Gómez",
            Direccion = new Direccion
            {
                Calle = "Calle 10",
                Ciudad = "Managua",
                CodigoPostal = "C456"
            }
        };

        string ciudadBuscada = "Managua"; //filtro

        Console.WriteLine($"Empleados que viven en {ciudadBuscada}:");

        foreach (var empleado in empleados)
        {
            if (empleado.Direccion.Ciudad.Equals(ciudadBuscada, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Nombre: {empleado.Nombre}");
                Console.WriteLine($"Calle: {empleado.Direccion.Calle}");
                Console.WriteLine($"Código Postal: {empleado.Direccion.CodigoPostal}");
                Console.WriteLine(); 
            }
        }

        Console.ReadKey();
    }
}
