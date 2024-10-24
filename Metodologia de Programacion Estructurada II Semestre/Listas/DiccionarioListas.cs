using System;
using System.Collections.Generic;

class Diccionario
{
    private Dictionary<string, string> diccionario = new Dictionary<string, string>();

    public void CrearDiccionario()
    {
        Console.WriteLine("Introduce hasta 5 pares de palabras (inglés - español):");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Introduce una palabra en inglés: ");
            string palabraIngles = Console.ReadLine();

            Console.Write("Introduce la traducción en español: ");
            string palabraEspanol = Console.ReadLine();

            diccionario[palabraIngles] = palabraEspanol;
        }

        Console.WriteLine("Diccionario creado con éxito.");
    }

    public void Traducir()
    {
        Console.WriteLine("\nModo de traducción. Escribe 'salir' para terminar.");

        while (true)
        {
            Console.Write("Introduce una palabra en inglés: ");
            string palabraIngles = Console.ReadLine();

            if (palabraIngles.ToLower() == "salir")
                break;

            if (diccionario.TryGetValue(palabraIngles, out string palabraEspanol))
            {
                Console.WriteLine($"La traducción de '{palabraIngles}' es '{palabraEspanol}'.");
            }
            else
            {
                Console.WriteLine($"La palabra '{palabraIngles}' no se encuentra en el diccionario.");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Diccionario diccionario = new Diccionario();

        diccionario.CrearDiccionario(); 
        diccionario.Traducir(); 
    }
}
