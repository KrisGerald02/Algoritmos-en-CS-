/*Desarrolla un programa que permita al usuario gestionar una 
cuenta bancaria. El programa debe utilizar un menú que 
permita realizar diferentes operaciones sobre el saldo de la 
cuenta.
Menú de opciones:
1. Consultar saldo
2. Depositar dinero
3. Retirar dinero
4. Salir
El programa debe permitir al usuario ingresar la cantidad para 
depositar o retirar, actualizar el saldo y mostrar los resultados. 
Si se elige la opción de retiro, debe verificar que el saldo sea 
suficiente */

using System;
using System.IO;

class CuentaBancaria
{
    const string archivoSaldo = "saldo.bin";

    static void Main(string[] args)
    {
        if (!File.Exists(archivoSaldo))
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(archivoSaldo, FileMode.Create)))
            {
                writer.Write(0.0); 
            }
        }

        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al sistema de cuenta bancaria.");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ConsultarSaldo();
                    break;
                case "2":
                    DepositarDinero();
                    break;
                case "3":
                    RetirarDinero();
                    break;
                case "4":
                    salir = true;
                    Console.WriteLine("Gracias por usar el sistema.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
            if (!salir)
            {
                Console.WriteLine("Presione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        }
    }

    static void ConsultarSaldo()
    {
        double saldo = LeerSaldo();
        Console.WriteLine($"El saldo actual es: {saldo:C2}");
    }

    static void DepositarDinero()
    {
        Console.Write("Ingrese la cantidad a depositar: ");
        if (double.TryParse(Console.ReadLine(), out double cantidad) && cantidad > 0)
        {
            double saldo = LeerSaldo();
            saldo += cantidad;
            EscribirSaldo(saldo);
            Console.WriteLine($"Depósito realizado. El nuevo saldo es: {saldo:C2}");
        }
        else
        {
            Console.WriteLine("Cantidad inválida.");
        }
    }

    static void RetirarDinero()
    {
        Console.Write("Ingrese la cantidad a retirar: ");
        if (double.TryParse(Console.ReadLine(), out double cantidad) && cantidad > 0)
        {
            double saldo = LeerSaldo();
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
                EscribirSaldo(saldo);
                Console.WriteLine($"Retiro realizado. El nuevo saldo es: {saldo:C2}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
        else
        {
            Console.WriteLine("Cantidad inválida.");
        }
    }

    static double LeerSaldo()
    {
        using (BinaryReader reader = new BinaryReader(File.Open(archivoSaldo, FileMode.Open)))
        {
            return reader.ReadDouble();
        }
    }

    static void EscribirSaldo(double saldo)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(archivoSaldo, FileMode.Create)))
        {
            writer.Write(saldo);
        }
    }
}
