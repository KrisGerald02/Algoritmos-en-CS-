using System;

class Cadenas
{
    static void Main()
    {
        String[] cadenas = { "Julio", "Ana", "Luis", "Pedro", "María" };

        Console.Write("Ingresa la cadena a buscar: ");
        string busqueda = Console.ReadLine();

        int posicion = -1;

        for (int i = 0; i < cadenas.Length; i++)
        {
            if (cadenas[i] == busqueda)
            {
                posicion = i;
                break;
            }
        }

        if (posicion != -1)
        {
            Console.WriteLine($"La cadena '{busqueda}' fue encontrada en la posición {posicion}.");
        }
        else
        {
            Console.WriteLine($"La cadena '{busqueda}' no se encontró en el arreglo.");
        }

        Console.ReadKey(); 
    }
}
