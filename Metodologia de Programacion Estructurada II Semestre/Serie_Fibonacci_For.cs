using System;

	public class Program
	{
		public static void Main(string[] args)
		{
			int n_terms = 10; 
			int n1 = 0, n2 = 1, nth;

			Console.WriteLine("Serie de Fibonacci:");
			Console.WriteLine(n1); 
			Console.WriteLine(n2); 

			for (int i = 2; i < n_terms; i++)
			{
				nth = n1 + n2;
				Console.WriteLine(nth);
				n1 = n2;
				n2 = nth;
			}
		}
	}
