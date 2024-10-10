/*Escribe un programa que implemente una calculadora con un 
menú de opciones para realizar diversas operaciones 
matemáticas. El programa debe incluir funciones para cada 
operación y debe validar las entradas del usuario.
Menú de opciones:
1. Suma
2. Resta
3. Multiplicación
4. División
5. Potencia
6. Raíz cuadrada
7. Salir
El programa debe permitir al usuario seleccionar una opción del 
menú, solicitar los valores necesarios y mostrar el resultado. Si 
se elige la opción 7, el programa se debe cerrar.*/
using System;
using System.IO;

class Calculadora
{
    const string archivoResultados = "resultados.bin";

    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz cuadrada");
            Console.WriteLine("7. Mostrar resultados guardados");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione una opción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    RealizarSuma();
                    break;
                case "2":
                    RealizarResta();
                    break;
                case "3":
                    RealizarMultiplicacion();
                    break;
                case "4":
                    RealizarDivision();
                    break;
                case "5":
                    RealizarPotencia();
                    break;
                case "6":
                    RealizarRaizCuadrada();
                    break;
                case "7":
                    MostrarResultadosGuardados();
                    break;
                case "8":
                    salir = true;
                    Console.WriteLine("Gracias por usar la calculadora.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            if (!salir)
            {
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void RealizarSuma()
    {
        Console.WriteLine("Suma de dos números");
        double num1 = LeerNumero("Ingrese el primer número: ");
        double num2 = LeerNumero("Ingrese el segundo número: ");
        double resultado = num1 + num2;
        Console.WriteLine($"El resultado de la suma es: {resultado}");
        GuardarResultado("Suma", resultado);
    }

    static void RealizarResta()
    {
        Console.WriteLine("Resta de dos números");
        double num1 = LeerNumero("Ingrese el primer número: ");
        double num2 = LeerNumero("Ingrese el segundo número: ");
        double resultado = num1 - num2;
        Console.WriteLine($"El resultado de la resta es: {resultado}");
        GuardarResultado("Resta", resultado);
    }

    static void RealizarMultiplicacion()
    {
        Console.WriteLine("Multiplicación de dos números");
        double num1 = LeerNumero("Ingrese el primer número: ");
        double num2 = LeerNumero("Ingrese el segundo número: ");
        double resultado = num1 * num2;
        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
        GuardarResultado("Multiplicación", resultado);
    }

    static void RealizarDivision()
    {
        Console.WriteLine("División de dos números");
        double num1 = LeerNumero("Ingrese el dividendo: ");
        double num2;
        do
        {
            num2 = LeerNumero("Ingrese el divisor (diferente de 0): ");
            if (num2 == 0)
                Console.WriteLine("El divisor no puede ser 0. Intente de nuevo.");
        } while (num2 == 0);

        double resultado = num1 / num2;
        Console.WriteLine($"El resultado de la división es: {resultado}");
        GuardarResultado("División", resultado);
    }

    static void RealizarPotencia()
    {
        Console.WriteLine("Potencia de un número");
        double baseNum = LeerNumero("Ingrese la base: ");
        double exponente = LeerNumero("Ingrese el exponente: ");
        double resultado = Math.Pow(baseNum, exponente);
        Console.WriteLine($"El resultado de {baseNum} elevado a {exponente} es: {resultado}");
        GuardarResultado("Potencia", resultado);
    }

    static void RealizarRaizCuadrada()
    {
        Console.WriteLine("Raíz cuadrada de un número");
        double num;
        do
        {
            num = LeerNumero("Ingrese un número positivo: ");
            if (num < 0)
                Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo.");
        } while (num < 0);

        double resultado = Math.Sqrt(num);
        Console.WriteLine($"El resultado de la raíz cuadrada es: {resultado}");
        GuardarResultado("Raíz Cuadrada", resultado);
    }

    static double LeerNumero(string mensaje)
    {
        double numero;
        Console.Write(mensaje);
        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada no válida. Por favor ingrese un número.");
            Console.Write(mensaje);
        }
        return numero;
    }

    static void GuardarResultado(string operacion, double resultado)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(archivoResultados, FileMode.Append)))
        {
            writer.Write(operacion);
            writer.Write(resultado);
        }
        Console.WriteLine("Resultado guardado en archivo binario.");
    }

    static void MostrarResultadosGuardados()
    {
        if (File.Exists(archivoResultados))
        {
            Console.WriteLine("Resultados guardados:");
            using (BinaryReader reader = new BinaryReader(File.Open(archivoResultados, FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    string operacion = reader.ReadString();
                    double resultado = reader.ReadDouble();
                    Console.WriteLine($"{operacion}: {resultado}");
                }
            }
        }
        else
        {
            Console.WriteLine("No hay resultados guardados.");
        }
    }
}
