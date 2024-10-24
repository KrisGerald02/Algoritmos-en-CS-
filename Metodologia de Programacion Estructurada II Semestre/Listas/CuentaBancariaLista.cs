using System;
using System.Collections.Generic;

class CuentaBancaria
{
    private List<decimal> transacciones = new List<decimal>();

    public CuentaBancaria(decimal saldoInicial)
    {
        transacciones.Add(saldoInicial); 
    }

    public void ConsultarSaldo()
    {
        decimal saldoActual = CalcularSaldo();
        Console.WriteLine($"El saldo actual es: {saldoActual:C}");
    }

    public void DepositarDinero()
    {
        Console.Write("Ingrese la cantidad a depositar: ");
        decimal cantidad = decimal.Parse(Console.ReadLine());

        if (cantidad > 0)
        {
            transacciones.Add(cantidad); 
            Console.WriteLine($"Has depositado {cantidad:C}. Saldo actualizado: {CalcularSaldo():C}");
        }
        else
        {
            Console.WriteLine("La cantidad debe ser mayor que cero.");
        }
    }
    public void RetirarDinero()
    {
        Console.Write("Ingrese la cantidad a retirar: ");
        decimal cantidad = decimal.Parse(Console.ReadLine());

        if (cantidad > 0)
        {
            decimal saldoActual = CalcularSaldo();
            if (cantidad <= saldoActual)
            {
                transacciones.Add(-cantidad); 
                Console.WriteLine($"Has retirado {cantidad:C}. Saldo actualizado: {CalcularSaldo():C}");
            }
            else
            {
                Console.WriteLine("Fondos insuficientes para realizar el retiro.");
            }
        }
        else
        {
            Console.WriteLine("La cantidad debe ser mayor que cero.");
        }
    }
    private decimal CalcularSaldo()
    {
        decimal saldo = 0;
        foreach (decimal transaccion in transacciones)
        {
            saldo += transaccion;
        }
        return saldo;
    }
}

class Program
{
    static void Main()
    {
        CuentaBancaria cuenta = new CuentaBancaria(1000);

        int opcion;
        do
        {
            Console.WriteLine("\nMenú de Cuenta Bancaria:");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("4. Salir");
            Console.Write("Elija una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    cuenta.ConsultarSaldo();
                    break;
                case 2:
                    cuenta.DepositarDinero();
                    break;
                case 3:
                    cuenta.RetirarDinero();
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 4);
    }
}
