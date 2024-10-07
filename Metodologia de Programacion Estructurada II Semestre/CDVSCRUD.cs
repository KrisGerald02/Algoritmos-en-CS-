/* Desarrollar una aplicación que permita almacenar las fases, 
actividades y productos esperados del Ciclo de Vida de 
Desarrollo de Software, tomando como base el enfoque 
metodológico estudiado en la asignatura Análisis y Diseño de 
Sistemas, de forma que se pueda gestionar el avance de cada 
fase haciendo uso de un tablero Kanban*/
using System;
using System.IO;

struct Actividad
{
    public string Nombre;
    public string Descripcion;
    public bool Completada;
}

struct Fase
{
    public string Nombre;
    public string ProductoEsperado;
    public Actividad[] Actividades;
}
class Program
{
    static void Main()
    {
        string archivoDatos = "ciclo_datos.bin";
        Fase[] fases = CargarDatos(archivoDatos);
        Menu(fases, archivoDatos);
    }

    static void Menu(Fase[] fases, string archivoDatos)
    {
        while (true)
        {
            Console.WriteLine("1. Agregar Fase");
            Console.WriteLine("2. Mostrar Fases");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    fases = AgregarFase(fases);
                    GuardarDatos(fases, archivoDatos);
                    break;
                case "2":
                    MostrarFases(fases);
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static Fase[] AgregarFase(Fase[] fases)
    {
        Console.Write("Nombre de la fase: ");
        string nombre = Console.ReadLine();
        Console.Write("Producto esperado: ");
        string productoEsperado = Console.ReadLine();

        Actividad[] actividades = new Actividad[3]; // Ejemplo: Tres actividades por fase
        for (int i = 0; i < actividades.Length; i++)
        {
            Console.Write($"Nombre de la actividad {i + 1}: ");
            actividades[i].Nombre = Console.ReadLine();
            Console.Write($"Descripción de la actividad {i + 1}: ");
            actividades[i].Descripcion = Console.ReadLine();
            actividades[i].Completada = false; // Inicialmente no completada
        }

        Fase nuevaFase = new Fase { Nombre = nombre, ProductoEsperado = productoEsperado, Actividades = actividades };
        Array.Resize(ref fases, fases.Length + 1);
        fases[fases.Length - 1] = nuevaFase;

        return fases;
    }

    static void MostrarFases(Fase[] fases)
    {
        for (int i = 0; i < fases.Length; i++)
        {
            Console.WriteLine($"Fase {i + 1}: {fases[i].Nombre}");
            Console.WriteLine($"Producto Esperado: {fases[i].ProductoEsperado}");
            for (int j = 0; j < fases[i].Actividades.Length; j++)
            {
                Console.WriteLine($"  Actividad {j + 1}: {fases[i].Actividades[j].Nombre} - {(fases[i].Actividades[j].Completada ? "Completada" : "Pendiente")}");
            }
        }
    }

    static void GuardarDatos(Fase[] fases, string archivoDatos)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(archivoDatos, FileMode.Create)))
        {
            writer.Write(fases.Length);
            foreach (Fase fase in fases)
            {
                writer.Write(fase.Nombre);
                writer.Write(fase.ProductoEsperado);
                writer.Write(fase.Actividades.Length);
                foreach (Actividad actividad in fase.Actividades)
                {
                    writer.Write(actividad.Nombre);
                    writer.Write(actividad.Descripcion);
                    writer.Write(actividad.Completada);
                }
            }
        }
    }

    static Fase[] CargarDatos(string archivoDatos)
    {
        if (!File.Exists(archivoDatos))
            return new Fase[0];

        using (BinaryReader reader = new BinaryReader(File.Open(archivoDatos, FileMode.Open)))
        {
            int cantidadFases = reader.ReadInt32();
            Fase[] fases = new Fase[cantidadFases];

            for (int i = 0; i < cantidadFases; i++)
            {
                fases[i].Nombre = reader.ReadString();
                fases[i].ProductoEsperado = reader.ReadString();
                int cantidadActividades = reader.ReadInt32();
                fases[i].Actividades = new Actividad[cantidadActividades];

                for (int j = 0; j < cantidadActividades; j++)
                {
                    fases[i].Actividades[j].Nombre = reader.ReadString();
                    fases[i].Actividades[j].Descripcion = reader.ReadString();
                    fases[i].Actividades[j].Completada = reader.ReadBoolean();
                }
            }
            return fases;
        }
    }
}
