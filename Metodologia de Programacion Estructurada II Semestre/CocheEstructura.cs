// Ejercicio 9:
// Define un struct llamado "Coche" con campos para Marca, Modelo, y Año. 
// Escribe un programa que permita al usuario ingresar la información para varios coches, 
// los almacene en un arreglo y luego muestre  los coches ingresados.
using System;

namespace Ejercicio9
{

    struct Coche
    {
        public string Marca;
        public string Modelo;
        public int Año;
        public Coche(string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos coches desea ingresar?: ");
            int cantidad = int.Parse(Console.ReadLine());

            Coche[] coches = new Coche[cantidad]; // Arreglo para almacenar los coches

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Ingrese la marca del coche {i + 1}: ");
                string marca = Console.ReadLine();

                Console.WriteLine($"Ingrese el modelo del coche {i + 1}: ");
                string modelo = Console.ReadLine();

                Console.WriteLine($"Ingrese el año del coche {i + 1}: ");
                int año = int.Parse(Console.ReadLine());

                coches[i] = new Coche(marca, modelo, año);// Agregar el coche al arreglo
            }

            Console.WriteLine("\nCoches ingresados:");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Coche {i + 1}: Marca: {coches[i].Marca}, Modelo: {coches[i].Modelo}, Año: {coches[i].Año}");
            }

            Console.ReadKey();
        }
    }
}
