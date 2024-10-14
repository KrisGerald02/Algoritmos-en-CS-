public class AreaT
{
   public static void Main(string[] args)
   {
      Console.WriteLine("Ingrese el valor de la base del triangulo: ");
      double baset = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Ingrese el valor de la altura del triangulo: ");
      double alturat = Convert.ToDouble(Console.ReadLine());

      double res = 0;
      Area(ref baset,ref alturat, ref res);
      Console.WriteLine($"El resultado del calculo del area del triangulo es: {res}");
      Console.WriteLine();
      Console.ReadLine();
   }

   public static void Area(ref double x,ref double y, ref double res)
   {
      res= ((x * y) / 2);
   }

}
