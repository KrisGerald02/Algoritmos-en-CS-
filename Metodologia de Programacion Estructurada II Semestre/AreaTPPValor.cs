   public class AreaT
   {
   public static void Main(string[] args)
      {
      Console.WriteLine("Ingrese el valor de la base del triangulo: ");
      double baset = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Ingrese el valor de la altura del triangulo: ");
      double alturat = Convert.ToDouble(Console.ReadLine());

      double res = Area(baset, alturat);
      Console.WriteLine($"El resultado del calculo del area del triangulo es: {res}");
      Console.WriteLine();
      Console.ReadLine();
      }

   public static double Area(double x, double y)
   {
      return ((x * y) / 2);
   }

   }


