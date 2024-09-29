/* Ejercicios de Programación en C# con Estructuras y Arreglos
1. Crea un struct llamado “Estudiante” con campos para Nombre, Edad y Promedio. Luego,
escribe un programa que cree una instancia de “Estudiante”, asigne valores a los 
campos y muestre la información en la consola.
*/

using System;

struct Estudiante
{
    public string Nombre;
    public int Edad;
    public double Promedio;
}

class Program
{
    static void Main()
    {
        Estudiante estudiante; //instancia

        estudiante.Nombre = "Kris Villalta";
        estudiante.Edad = 18;
        estudiante.Promedio = 100;

        Console.WriteLine("Información del Estudiante:");
        Console.WriteLine($"Nombre: {estudiante.Nombre}");
        Console.WriteLine($"Edad: {estudiante.Edad}");
        Console.WriteLine($"Promedio: {estudiante.Promedio}");
    }
}
