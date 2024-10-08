using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n;
        char resp = ' '; 
        Console.WriteLine("Uso de Entrada con Iteraciones (Si/No)");

        do
        {
            Console.WriteLine("Ingrese el numero: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Desea ingresar otro numero (S= Si || N= No): ");
            resp = Console.ReadLine().ToUpper()[0]; // Convertimos a mayúscula y tomamos el primer carácter
            if (resp == 'N')
                break;

        } while (resp == 'S');

        // Centinela
        Console.WriteLine("Uso de Centinela");
        do
        {
            Console.WriteLine("Ingrese un numero - (Digite -99 para finalizar): ");
            n = int.Parse(Console.ReadLine());
        } while (n != -99);

        // Banderas
        Console.WriteLine("Uso de Banderas");
        bool bandera = false;
        do
        {
            Console.WriteLine("Ingrese un numero positivo: ");
            n = int.Parse(Console.ReadLine());

            if (n <= 0)
                bandera = true;
        } while (!bandera);

        Console.ReadKey();
    }
}
