public class Program
    {
        public static void Main(string[] args) 
        {
        string cadena;
        cadena = "Esta es una cadena";
        Console.WriteLine("Tamaño de Tipos de Datos");
        Console.WriteLine();
        Console.WriteLine("Tamaño del Tipo de Datos de bool es:{0}", sizeof(bool));
        Console.WriteLine("Tamaño del Tipo de Dato de byte es: {0}, rango:{1:#, ##0}", sizeof(byte), Math.Pow(2, 8));
        Console.WriteLine("Tamaño del Tipo de Dato de sbyte es: {0}, rango:{1:#, ##0}", sizeof(sbyte), Math.Pow(2, 8));
        Console.WriteLine("Tamaño del Tipo de Dato de string es:{0}", cadena.Length);
        Console.WriteLine("Tamaño del Tipo de Dato de short es:{0}, rango:{1:#, ##0}", sizeof(short), Math.Pow(2, 16));
        Console.WriteLine("Tamaño del Tipo de Dato de ushort es:{0}, rango:{1:#, ##0}", sizeof(ushort), Math.Pow(2, 16));
        Console.WriteLine("Tamaño del Tipo de Dato de int es:{0}, rango:{1:#, ##0}", sizeof(int), Math.Pow(2, 32));
        Console.WriteLine("Tamaño del Tipo de Dato de uint es:{0}, rango:{1:#, ##0}", sizeof(uint), Math.Pow(2, 32));
        Console.WriteLine("Tamaño del Tipo de Dato de long es:{0}, rango:{1:#, ##0}", sizeof(long), Math.Pow(2, 64));
        Console.WriteLine("Tamaño del Tipo de Dato de ulong es:{0}, rango:{1:#, ##0}", sizeof(ulong), Math.Pow(2, 64));
        Console.WriteLine("Tamaño del Tipo de Dato de float es:{0}, rango:{1:#, ##0}", sizeof(float), Math.Pow(2, 32));
        Console.WriteLine("Tamaño del Tipo de Dato de double es:{0}, rango:{1:#, ##0}", sizeof(double), Math.Pow(2, 64));
        Console.WriteLine("Tamaño del Tipo de Dato de decimal es:{0}, rango:{1:#, ##0}", sizeof(decimal), Math.Pow(2, 128));
    }
}
