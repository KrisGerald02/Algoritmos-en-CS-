/*
Ejercicio 2: Sistema de Reservaciones de Aerolínea

Una pequeña aerolínea acaba de adquirir una computadora para su sistema automatizado de reservaciones.
Escriba un programa que asigne asientos en un vuelo con capacidad para 10 asientos. El programa 
deberá mostrar un menú de alternativas: 

1. Si el usuario digita 1, se asigna un asiento en la sección de fumar (asientos 1 al 5).
2. Si el usuario digita 2, se asigna un asiento en la sección de no fumar (asientos 6 al 10).

El programa imprimirá un pase de abordaje indicando el número de asiento y la sección.
Si la sección elegida está llena, deberá preguntar si desea ser asignado en la otra sección.
Si se rehúsa, se imprimirá el mensaje "Next flight leaves in 3 hours" y el programa terminará.
*/

using System;

class Program
{
    static void Main()
    {
        bool[] asientos = new bool[10]; // Arreglo que indica si un asiento está ocupado
        bool asignado;

        while (true)
        {
            Console.WriteLine("Por favor, elija su opción:");
            Console.WriteLine("1 - Sección de fumar (asientos 1-5)");
            Console.WriteLine("2 - Sección de no fumar (asientos 6-10)");
            int opcion = int.Parse(Console.ReadLine());

            asignado = false; // Reiniciamos la variable de asignación

            if (opcion == 1) // Opción de fumar
            {
                // Intentar asignar asiento en la sección de fumar (1 a 5)
                for (int i = 0; i < 5; i++)
                {
                    if (!asientos[i])
                    {
                        asientos[i] = true;
                        Console.WriteLine($"Asiento asignado en la sección de fumar: {i + 1}");
                        asignado = true;
                        break;
                    }
                }

                // Si no hay asientos en la sección de fumar
                if (!asignado)
                {
                    Console.WriteLine("Sección de fumar llena. ¿Le gustaría un asiento en la sección de no fumar? (S/N)");
                    string respuesta = Console.ReadLine();

                    if (respuesta.ToUpper() == "S")
                    {
                        for (int i = 5; i < 10; i++)
                        {
                            if (!asientos[i])
                            {
                                asientos[i] = true;
                                Console.WriteLine($"Asiento asignado en la sección de no fumar: {i + 1}");
                                asignado = true;
                                break;
                            }
                        }
                    }
                    else if (respuesta.ToUpper() == "N")
                    {
                        Console.WriteLine("Next flight leaves in 3 hours.");
                        break; // Termina el programa si la respuesta es "N"
                    }
                }
            }
            else if (opcion == 2) // Opción de no fumar
            {
                // Intentar asignar asiento en la sección de no fumar (6 a 10)
                for (int i = 5; i < 10; i++)
                {
                    if (!asientos[i])
                    {
                        asientos[i] = true;
                        Console.WriteLine($"Asiento asignado en la sección de no fumar: {i + 1}");
                        asignado = true;
                        break;
                    }
                }

                // Si no hay asientos en la sección de no fumar
                if (!asignado)
                {
                    Console.WriteLine("Sección de no fumar llena. ¿Le gustaría un asiento en la sección de fumar? (S/N)");
                    string respuesta = Console.ReadLine();

                    if (respuesta.ToUpper() == "S")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (!asientos[i])
                            {
                                asientos[i] = true;
                                Console.WriteLine($"Asiento asignado en la sección de fumar: {i + 1}");
                                asignado = true;
                                break;
                            }
                        }
                    }
                    else if (respuesta.ToUpper() == "N")
                    {
                        Console.WriteLine("Next flight leaves in 3 hours.");
                        break; // Termina el programa si la respuesta es "N"
                    }
                }
            }

            // Si no se pudo asignar ningún asiento
            if (!asignado)
            {
                Console.WriteLine("Next flight leaves in 3 hours.");
                break; // Finaliza el programa si no hay asignación posible
            }
        }
    }
}
