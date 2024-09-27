using System;
public struct Rectangulo
{
    public double Ancho;
    public double Altura;

    public Rectangulo(double ancho, double altura)
    {
        Ancho = ancho;
        Altura = altura;
    }

    public double calcularArea()
    {
        return (Ancho*Altura);
    }
}

public class Geometria
{
    public static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de rectangulos a procesar:");
        int cant = int.Parse(Console.ReadLine()); 
        Rectangulo[] rectangulo=new Rectangulo[cant];
        for(int i = 0; i < rectangulo.Length; i++)
        {
            Console.Write("Datos de los rectangulos");
            Console.Write("Ancho: ");
            double ancho= double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double altura= double.Parse(Console.ReadLine());

            rectangulo[i] = new Rectangulo(ancho, altura);
        }

        for(int i = 0;i < rectangulo.Length;i++)
        {
            Console.Write("Datos de los rectangulos");
            double area= rectangulo[i].calcularArea();
            Console.WriteLine($"Rectangulo {i+1}: Ancho:{rectangulo[i].Ancho}, Altura:  {rectangulo[i].Altura}, Area: {area}");
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}
