/*Ejercicio 1: Crear un registro de Software que contenga los campos: 
fabricante, nombre, edición, versión, licenciamiento, 
descripción y con este crear un arreglo de registros para 
almacenar una lista de software que deberán ser almacenados 
en disco (fichero binario). Crear un menú para leer en memoria, 
almacenar en disco y recuperar del disco, así como las 
operaciones de actualización y eliminación de registros en 
memoria y disco.  */


using System;
using System.IO;

namespace CrudSoftware
{
    public struct Software
    {
        public string Fabricante;
        public string Nombre;
        public string Edicion;
        public string Version;
        public string Licenciamiento;
        public string Descripcion;

        public Software(string fabricante, string nombre, string edicion, string version, string licenciamiento, string descripcion)
        {
            Fabricante = fabricante;
            Nombre = nombre;
            Edicion = edicion;
            Version = version;
            Licenciamiento = licenciamiento;
            Descripcion = descripcion;
        }
    }

    public class Crud
    {
        private const string archivo = "software.dat";
        private const int MaxSoftware = 100; // Capacidad máxima del arreglo

        public static void Main()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n--- Menú CRUD de Software ---");
                Console.WriteLine("1. Crear Software");
                Console.WriteLine("2. Leer Software");
                Console.WriteLine("3. Actualizar Software");
                Console.WriteLine("4. Eliminar Software");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: AgregarSoftware(); break;
                    case 2: LeerSoftware(); break;
                    case 3: ActualizarSoftware(); break;
                    case 4: EliminarSoftware(); break;
                    case 5: break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            } while (opcion != 5);
        }

        public static void AgregarSoftware()
        {
            Console.Write("Ingrese el fabricante: ");
            string fabricante = Console.ReadLine();
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la edición: ");
            string edicion = Console.ReadLine();
            Console.Write("Ingrese la versión: ");
            string version = Console.ReadLine();
            Console.Write("Ingrese el licenciamiento: ");
            string licenciamiento = Console.ReadLine();
            Console.Write("Ingrese la descripción: ");
            string descripcion = Console.ReadLine();

            Software software = new Software(fabricante, nombre, edicion, version, licenciamiento, descripcion);

            using (BinaryWriter writer = new BinaryWriter(File.Open(archivo, FileMode.Append)))
            {
                writer.Write(software.Fabricante);
                writer.Write(software.Nombre);
                writer.Write(software.Edicion);
                writer.Write(software.Version);
                writer.Write(software.Licenciamiento);
                writer.Write(software.Descripcion);
            }
            Console.WriteLine("Software agregado exitosamente.");
        }

        public static void LeerSoftware()
        {
            if (!File.Exists(archivo) || new FileInfo(archivo).Length == 0)
            {
                Console.WriteLine("No hay software registrado.");
                return;
            }

            using (BinaryReader reader = new BinaryReader(File.Open(archivo, FileMode.Open)))
            {
                Console.WriteLine("\nLista de Software:");
                try
                {
                    while (true)
                    {
                        Software software = new Software()
                        {
                            Fabricante = reader.ReadString(),
                            Nombre = reader.ReadString(),
                            Edicion = reader.ReadString(),
                            Version = reader.ReadString(),
                            Licenciamiento = reader.ReadString(),
                            Descripcion = reader.ReadString()
                        };

                        Console.WriteLine($"Fabricante: {software.Fabricante}");
                        Console.WriteLine($"Nombre: {software.Nombre}");
                        Console.WriteLine($"Edición: {software.Edicion}");
                        Console.WriteLine($"Versión: {software.Version}");
                        Console.WriteLine($"Licenciamiento: {software.Licenciamiento}");
                        Console.WriteLine($"Descripción: {software.Descripcion}\n");
                    }
                }
                catch (EndOfStreamException) { }
            }
        }

        public static void ActualizarSoftware()
        {
            if (!File.Exists(archivo))
            {
                Console.WriteLine("No hay software para actualizar.");
                return;
            }

            Console.Write("Ingrese el nombre del software a actualizar: ");
            string nombreBuscar = Console.ReadLine();
            Software[] softwareList = new Software[MaxSoftware];
            int contador = 0;
            bool encontrado = false;

            using (BinaryReader reader = new BinaryReader(File.Open(archivo, FileMode.Open)))
            {
                try
                {
                    while (true)
                    {
                        Software software = new Software()
                        {
                            Fabricante = reader.ReadString(),
                            Nombre = reader.ReadString(),
                            Edicion = reader.ReadString(),
                            Version = reader.ReadString(),
                            Licenciamiento = reader.ReadString(),
                            Descripcion = reader.ReadString()
                        };

                        if (software.Nombre == nombreBuscar)
                        {
                            Console.Write("Nuevo fabricante: ");
                            software.Fabricante = Console.ReadLine();
                            Console.Write("Nuevo nombre: ");
                            software.Nombre = Console.ReadLine();
                            Console.Write("Nueva edición: ");
                            software.Edicion = Console.ReadLine();
                            Console.Write("Nueva versión: ");
                            software.Version = Console.ReadLine();
                            Console.Write("Nuevo licenciamiento: ");
                            software.Licenciamiento = Console.ReadLine();
                            Console.Write("Nueva descripción: ");
                            software.Descripcion = Console.ReadLine();
                            encontrado = true;
                        }

                        softwareList[contador++] = software; // Guardar el software en el arreglo
                    }
                }
                catch (EndOfStreamException) { }
            }

            if (encontrado)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(archivo, FileMode.Create)))
                {
                    for (int i = 0; i < contador; i++)
                    {
                        writer.Write(softwareList[i].Fabricante);
                        writer.Write(softwareList[i].Nombre);
                        writer.Write(softwareList[i].Edicion);
                        writer.Write(softwareList[i].Version);
                        writer.Write(softwareList[i].Licenciamiento);
                        writer.Write(softwareList[i].Descripcion);
                    }
                }
                Console.WriteLine("Software actualizado con éxito.");
            }
            else
            {
                Console.WriteLine("Software no encontrado.");
            }
        }

        public static void EliminarSoftware()
        {
            if (!File.Exists(archivo))
            {
                Console.WriteLine("No hay software para eliminar.");
                return;
            }

            Console.Write("Ingrese el nombre del software a eliminar: ");
            string nombreEliminar = Console.ReadLine();
            Software[] softwareList = new Software[MaxSoftware];
            int contador = 0;
            bool encontrado = false;

            using (BinaryReader reader = new BinaryReader(File.Open(archivo, FileMode.Open)))
            {
                try
                {
                    while (true)
                    {
                        Software software = new Software()
                        {
                            Fabricante = reader.ReadString(),
                            Nombre = reader.ReadString(),
                            Edicion = reader.ReadString(),
                            Version = reader.ReadString(),
                            Licenciamiento = reader.ReadString(),
                            Descripcion = reader.ReadString()
                        };

                        if (software.Nombre != nombreEliminar)
                        {
                            softwareList[contador++] = software; // Solo guardamos los que no se eliminan
                        }
                        else
                        {
                            encontrado = true; // Software encontrado para eliminar
                        }
                    }
                }
                catch (EndOfStreamException) { }
            }

            if (encontrado)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(archivo, FileMode.Create)))
                {
                    for (int i = 0; i < contador; i++)
                    {
                        writer.Write(softwareList[i].Fabricante);
                        writer.Write(softwareList[i].Nombre);
                        writer.Write(softwareList[i].Edicion);
                        writer.Write(softwareList[i].Version);
                        writer.Write(softwareList[i].Licenciamiento);
                        writer.Write(softwareList[i].Descripcion);
                    }
                }
                Console.WriteLine("Software eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Software no encontrado.");
            }
        }
    }
}
