using System;
using System.IO;

class ConversorUnidades
{
    // Ruta para almacenar los resultados en archivo binario
    private const string rutaArchivo = "resultadosConversion.bin";

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            MostrarMenu();
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ConvertirMetrosAKilometros();
                    break;
                case 2:
                    ConvertirKilogramosAGramos();
                    break;
                case 3:
                    ConvertirLitrosAMililitros();
                    break;
                case 4:
                    ConvertirCelsiusAFahrenheit();
                    break;
                case 5:
                    ConvertirHorasAMinutos();
                    break;
                case 6:
                    Console.WriteLine("Saliendo del programa.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intenta de nuevo.");
                    break;
            }

        } while (opcion != 6);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\nSeleccione una opción:");
        Console.WriteLine("1. Convertir metros a kilómetros");
        Console.WriteLine("2. Convertir kilogramos a gramos");
        Console.WriteLine("3. Convertir litros a mililitros");
        Console.WriteLine("4. Convertir Celsius a Fahrenheit");
        Console.WriteLine("5. Convertir horas a minutos");
        Console.WriteLine("6. Salir");
        Console.Write("Ingrese su opción: ");
    }

    // Funciones de conversión
    static void ConvertirMetrosAKilometros()
    {
        Console.Write("Ingrese el valor en metros: ");
        double metros = double.Parse(Console.ReadLine());
        double kilometros = metros / 1000;
        Console.WriteLine($"{metros} metros son {kilometros} kilómetros.");
        GuardarResultado($"{metros} metros = {kilometros} kilómetros");
    }

    static void ConvertirKilogramosAGramos()
    {
        Console.Write("Ingrese el valor en kilogramos: ");
        double kilogramos = double.Parse(Console.ReadLine());
        double gramos = kilogramos * 1000;
        Console.WriteLine($"{kilogramos} kilogramos son {gramos} gramos.");
        GuardarResultado($"{kilogramos} kg = {gramos} gramos");
    }

    static void ConvertirLitrosAMililitros()
    {
        Console.Write("Ingrese el valor en litros: ");
        double litros = double.Parse(Console.ReadLine());
        double mililitros = litros * 1000;
        Console.WriteLine($"{litros} litros son {mililitros} mililitros.");
        GuardarResultado($"{litros} litros = {mililitros} mililitros");
    }

    static void ConvertirCelsiusAFahrenheit()
    {
        Console.Write("Ingrese el valor en grados Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius}°C son {fahrenheit}°F.");
        GuardarResultado($"{celsius}°C = {fahrenheit}°F");
    }

    static void ConvertirHorasAMinutos()
    {
        Console.Write("Ingrese el valor en horas: ");
        double horas = double.Parse(Console.ReadLine());
        double minutos = horas * 60;
        Console.WriteLine($"{horas} horas son {minutos} minutos.");
        GuardarResultado($"{horas} horas = {minutos} minutos");
    }

    // Guardar resultados en archivo binario
    static void GuardarResultado(string resultado)
    {
        using (FileStream fs = new FileStream(rutaArchivo, FileMode.Append, FileAccess.Write))
        {
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(resultado);
            }
        }
        Console.WriteLine("Resultado guardado.");
    }

    // Función para leer resultados guardados (CRUD: Leer)
    static void LeerResultados()
    {
        if (File.Exists(rutaArchivo))
        {
            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    while (fs.Position < fs.Length)
                    {
                        string resultado = reader.ReadString();
                        Console.WriteLine(resultado);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("No se encontraron resultados guardados.");
        }
    }
}
