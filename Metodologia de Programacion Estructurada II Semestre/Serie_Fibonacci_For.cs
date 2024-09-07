using System;

public class Program
{
    public static void Main(string[] args)
    {
        int d = 10;
        int a = 0, b = 1, c;

        Console.WriteLine("Serie de Fibonacci:");
        Console.WriteLine(a);
        Console.WriteLine(b);

        for (int i = 2; i < d; i++)
        {
            c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
    }
}
