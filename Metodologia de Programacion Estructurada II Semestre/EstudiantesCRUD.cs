/*Ejercicio 2: Crear los registros Estudiante, Asignatura y Calificaciones, 
relacionados por campos, para una aplicación que permita 
realizar el CRUD para gestionar las calificaciones obtenidas por 
los estudiantes que cursan diferentes asignaturas en un 
semestre dado.  */

using System;
using System.IO;

namespace Crud
{
    public struct Estudiante
    {
        public int Id;
        public string Nombre;

        public Estudiante(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }

    public struct Asignatura
    {
        public int Id;
        public string Nombre;

        public Asignatura(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }

    public struct Calificacion
    {
        public int IdEstudiante;
        public int IdAsignatura;
        public float Nota;

        public Calificacion(int idEstudiante, int idAsignatura, float nota)
        {
            IdEstudiante = idEstudiante;
            IdAsignatura = idAsignatura;
            Nota = nota;
        }
    }

    public class Crud
    {
        private const string archivoEstudiantes = "estudiantes.dat";
        private const string archivoAsignaturas = "asignaturas.dat";
        private const string archivoCalificaciones = "calificaciones.dat";

        public static void Main()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n--- Menú CRUD ---");
                Console.WriteLine("1. Crear Estudiante");
                Console.WriteLine("2. Crear Asignatura");
                Console.WriteLine("3. Agregar Calificación");
                Console.WriteLine("4. Leer Calificaciones");
                Console.WriteLine("5. Actualizar Calificación");
                Console.WriteLine("6. Eliminar Calificación");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: AgregarEstudiante(); break;
                    case 2: AgregarAsignatura(); break;
                    case 3: AgregarCalificacion(); break;
                    case 4: LeerCalificaciones(); break;
                    case 5: ActualizarCalificacion(); break;
                    case 6: EliminarCalificacion(); break;
                    case 7: break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            } while (opcion != 7);
        }

        public static void AgregarEstudiante()
        {
            Console.Write("Ingrese el ID del estudiante: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Estudiante estudiante = new Estudiante(id, nombre);

            using (BinaryWriter writer = new BinaryWriter(File.Open(archivoEstudiantes, FileMode.Append)))
            {
                writer.Write(estudiante.Id);
                writer.Write(estudiante.Nombre);
            }
            Console.WriteLine("Estudiante agregado exitosamente.");
        }

        public static void AgregarAsignatura()
        {
            Console.Write("Ingrese el ID de la asignatura: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre de la asignatura: ");
            string nombre = Console.ReadLine();

            Asignatura asignatura = new Asignatura(id, nombre);

            using (BinaryWriter writer = new BinaryWriter(File.Open(archivoAsignaturas, FileMode.Append)))
            {
                writer.Write(asignatura.Id);
                writer.Write(asignatura.Nombre);
            }
            Console.WriteLine("Asignatura agregada exitosamente.");
        }

        public static void AgregarCalificacion()
        {
            Console.Write("Ingrese el ID del estudiante: ");
            int idEstudiante = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el ID de la asignatura: ");
            int idAsignatura = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota: ");
            float nota = float.Parse(Console.ReadLine());

            Calificacion calificacion = new Calificacion(idEstudiante, idAsignatura, nota);

            using (BinaryWriter writer = new BinaryWriter(File.Open(archivoCalificaciones, FileMode.Append)))
            {
                writer.Write(calificacion.IdEstudiante);
                writer.Write(calificacion.IdAsignatura);
                writer.Write(calificacion.Nota);
            }
            Console.WriteLine("Calificación agregada exitosamente.");
        }

        public static void LeerCalificaciones()
        {
            if (!File.Exists(archivoCalificaciones) || new FileInfo(archivoCalificaciones).Length == 0)
            {
                Console.WriteLine("No hay calificaciones registradas.");
                return;
            }

            using (BinaryReader reader = new BinaryReader(File.Open(archivoCalificaciones, FileMode.Open)))
            {
                Console.WriteLine("\nCalificaciones:");
                try
                {
                    while (true)
                    {
                        Calificacion calificacion = new Calificacion
                        {
                            IdEstudiante = reader.ReadInt32(),
                            IdAsignatura = reader.ReadInt32(),
                            Nota = reader.ReadSingle()
                        };
                        Console.WriteLine($"Estudiante ID: {calificacion.IdEstudiante}, Asignatura ID: {calificacion.IdAsignatura}, Nota: {calificacion.Nota}");
                    }
                }
                catch (EndOfStreamException) { }
            }
        }

        public static void ActualizarCalificacion()
        {
            if (!File.Exists(archivoCalificaciones))
            {
                Console.WriteLine("No hay calificaciones para actualizar.");
                return;
            }

            Console.Write("Ingrese el ID del estudiante a actualizar: ");
            if (!int.TryParse(Console.ReadLine(), out int idEstudianteBuscar))
            {
                Console.WriteLine("ID de estudiante no válido.");
                return;
            }

            Console.Write("Ingrese el ID de la asignatura: ");
            if (!int.TryParse(Console.ReadLine(), out int idAsignaturaBuscar))
            {
                Console.WriteLine("ID de asignatura no válido.");
                return;
            }

            bool encontrado = false;
            Calificacion[] calificaciones = new Calificacion[100];
            int contador = 0;

            using (BinaryReader reader = new BinaryReader(File.Open(archivoCalificaciones, FileMode.Open)))
            {
                try
                {
                    while (true)
                    {
                        Calificacion calificacion = new Calificacion
                        {
                            IdEstudiante = reader.ReadInt32(),
                            IdAsignatura = reader.ReadInt32(),
                            Nota = reader.ReadSingle()
                        };

                        if (calificacion.IdEstudiante == idEstudianteBuscar && calificacion.IdAsignatura == idAsignaturaBuscar)
                        {
                            Console.Write("Nueva Nota: ");
                            if (float.TryParse(Console.ReadLine(), out float nuevaNota))
                            {
                                calificacion.Nota = nuevaNota;
                                encontrado = true;
                            }
                            else
                            {
                                Console.WriteLine("Nota no válida, se omite la actualización.");
                            }
                        }
                        calificaciones[contador++] = calificacion;
                    }
                }
                catch (EndOfStreamException) { }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al leer las calificaciones: {ex.Message}");
                }
            }

            if (encontrado)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(archivoCalificaciones, FileMode.Create)))
                {
                    for (int i = 0; i < contador; i++)
                    {
                        writer.Write(calificaciones[i].IdEstudiante);
                        writer.Write(calificaciones[i].IdAsignatura);
                        writer.Write(calificaciones[i].Nota);
                    }
                }
                Console.WriteLine("Calificación actualizada con éxito.");
            }
            else
            {
                Console.WriteLine("Calificación no encontrada.");
            }
        }

        public static void EliminarCalificacion()
        {
            if (!File.Exists(archivoCalificaciones))
            {
                Console.WriteLine("No hay calificaciones para eliminar.");
                return;
            }

            Console.Write("Ingrese el ID del estudiante a eliminar: ");
            if (!int.TryParse(Console.ReadLine(), out int idEstudianteEliminar))
            {
                Console.WriteLine("ID de estudiante no válido.");
                return;
            }

            Console.Write("Ingrese el ID de la asignatura a eliminar: ");
            if (!int.TryParse(Console.ReadLine(), out int idAsignaturaEliminar))
            {
                Console.WriteLine("ID de asignatura no válido.");
                return;
            }

            bool encontrado = false;
            Calificacion[] calificaciones = new Calificacion[100];
            int contador = 0;

            using (BinaryReader reader = new BinaryReader(File.Open(archivoCalificaciones, FileMode.Open)))
            {
                try
                {
                    while (true)
                    {
                        Calificacion calificacion = new Calificacion
                        {
                            IdEstudiante = reader.ReadInt32(),
                            IdAsignatura = reader.ReadInt32(),
                            Nota = reader.ReadSingle()
                        };

                        // Solo añadimos la calificación si no coincide con la que se quiere eliminar
                        if (!(calificacion.IdEstudiante == idEstudianteEliminar && calificacion.IdAsignatura == idAsignaturaEliminar))
                        {
                            calificaciones[contador++] = calificacion; // Se guarda la calificación
                        }
                        else
                        {
                            encontrado = true; // Se encontró la calificación a eliminar
                        }
                    }
                }
                catch (EndOfStreamException) { }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al leer las calificaciones: {ex.Message}");
                }
            }

            if (encontrado)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(archivoCalificaciones, FileMode.Create)))
                {
                    for (int i = 0; i < contador; i++)
                    {
                        writer.Write(calificaciones[i].IdEstudiante);
                        writer.Write(calificaciones[i].IdAsignatura);
                        writer.Write(calificaciones[i].Nota);
                    }
                }
                Console.WriteLine("Calificación eliminada con éxito.");
            }
            else
            {
                Console.WriteLine("Calificación no encontrada.");
            }
        }
    }
}


