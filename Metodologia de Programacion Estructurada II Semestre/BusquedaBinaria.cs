//Ejemplo de busqueda binaria usando arrays de strings 

using System;

class Programa
{
    // Método de búsqueda binaria
    static int BusquedaBinaria(string[] productos, string objetivo)
    {
        int inicio = 0;
        int fin = productos.Length - 1; //Numero de elementos del arreglo 

        while (inicio <= fin)
        {
            int medio = inicio + (fin - inicio) / 2;
            //Divide la longitud entre 2 para encontrar la mitad del rango

            // Compara el elemento en la posición media con el objetivo
            int comparacion = String.Compare(productos[medio], objetivo, StringComparison.OrdinalIgnoreCase);

            if (comparacion == 0)
            {
                return medio; // Retorna el índice si el objetivo es encontrado
            }
            else if (comparacion < 0)
            {
                inicio = medio + 1; // Busca en la mitad derecha
            }
            else
            {
                fin = medio - 1; // Busca en la mitad izquierda
            }
        }

        return -1; // Retorna -1 si el objetivo no es encontrado
    }

    static void Main()
    {
        // Array de productos de ropa ordenados alfabéticamente
        string[] productosDeRopa =
        {
            "Blusa", "Camisa", "Chaqueta", "Cinturón", "Falda",
            "Gorra", "Jeans", "Pantalones", "Sombrero", "Suéter",
            "Vestido", "Zapatos"
        };

        // Producto que queremos buscar
        Console.WriteLine("---Busqueda binaria---");
        Console.Write("Producto: ");
        string productoBuscado = Console.ReadLine(); 
        

        // Realiza la búsqueda binaria
        int resultado = BusquedaBinaria(productosDeRopa, productoBuscado);

        if (resultado != -1)
        {
            Console.WriteLine($"Producto '{productoBuscado}' encontrado en el índice {resultado}.");
        }
        else
        {
            Console.WriteLine($"Producto '{productoBuscado}' no encontrado.");
        }
        Console.ReadKey();
    }
}
