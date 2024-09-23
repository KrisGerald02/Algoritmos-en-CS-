using System;
using System.IO;

class ArchivoTexto
{
    static void Main()
    {
        string rutaArchivo = "archivo.txt";

        Console.Write("Ingresa el texto a escribir en el archivo: ");
        string texto = Console.ReadLine();

        FileStream fs = new FileStream(rutaArchivo, FileMode.Create);
        StreamWriter writer = new StreamWriter(fs);
        writer.WriteLine(texto);//se instancia el objeto writer para escribir

        writer.Close();
        fs.Close();

        Console.WriteLine("Texto grabado en el archivo.");

        if (File.Exists(rutaArchivo))
        {
            FileStream fsLectura = new FileStream(rutaArchivo, FileMode.Open);
            StreamReader reader = new StreamReader(fsLectura);
            string contenido = reader.ReadToEnd(); // se instancia el objeto contenido para leer
            reader.Close();
            fsLectura.Close();
            Console.WriteLine("Contenido del archivo:");
            Console.WriteLine(contenido);
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }

        Console.ReadKey();
    }
}
