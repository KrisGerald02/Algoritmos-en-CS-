using System;
public class Program
{
    public static void Main(string[] args)
    {
        int codigo;
        string nombres;
        string apellidos;
        string cargo;
        float salario;
        char sexo;
        bool capacitación;
        Console.WriteLine("Datos de empleado");
        Console.WriteLine();
        Console.Write("Ingrese el codigo: ");
        codigo = int.Parse(Console.ReadLine());
        Console.Write("Ingrese los nombres: ");
        nombres = Console.ReadLine();
        Console.Write("Ingrese los apellidos: ");
        apellidos = Console.ReadLine();
        Console.Write("Ingrese los cargo: ");
        cargo = Console.ReadLine();
        Console.Write("Ingrese el salario:");
        salario = float.Parse(Console.ReadLine());
        Console.Write("Indique el sexo (M = Masculino | F = femenino)");
        sexo = char.Parse(Console.ReadLine());
        Console.Write("Ingrese la anuencia a capacitación (True = si | False = No)");
        capacitación = bool.Parse(Console.ReadLine());
        Console.WriteLine("Datos Empleado");
        Console.WriteLine();
        Console.WriteLine("Codigo: {0}", codigo);
        Console.WriteLine("Nombres: {0}", nombres);
        Console.WriteLine("apellidos: {0}", apellidos);
        Console.WriteLine("cargo: {0}", cargo);
        Console.WriteLine("salario: {0}", salario);
        if (sexo == 'm' || sexo == 'M')
            Console.WriteLine("Sexo: Masculino");
        else
            if (sexo == 'F' || sexo == 'F')
            Console.WriteLine("Sexo: Femenino");

        if (capacitación == true)
            Console.WriteLine("Capacitacion: Anuente");
        else
           if (capacitación == false)
            Console.WriteLine("Capacitacion: No Anuente");
        Console.ReadKey(); 
    }
}
