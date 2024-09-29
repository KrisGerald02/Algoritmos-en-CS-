/* Crea un struct llamado “CuentaBancaria” con campos para NumeroDeCuenta, 
NombreTitular, y Saldo. Agrega un constructor que permita inicializar  los campos. 
Crea un arreglo de “CuentaBancaria”, inicialízalo usando el constructor, y muestra la 
información de cada cuenta..*/
using System;

struct CuentaBancaria
{
    public string NumeroDeCuenta;
    public string NombreTitular;
    public double Saldo;

    public CuentaBancaria(string numeroDeCuenta, string nombreTitular, double saldo)
    {
        NumeroDeCuenta = numeroDeCuenta;
        NombreTitular = nombreTitular;
        Saldo = saldo;
    }
}

class Program
{
    static void Main()
    {
        CuentaBancaria[] cuentas = new CuentaBancaria[3];

        cuentas[0] = new CuentaBancaria("0012345678", "Kris Villalta", 1500.75);
        cuentas[1] = new CuentaBancaria("0012345679", "Ana Torres", 2500.50);
        cuentas[2] = new CuentaBancaria("0012345680", "Luis Gómez", 1000.00);

        Console.WriteLine("Información de las Cuentas Bancarias:");
        foreach (var cuenta in cuentas)
        {
            Console.WriteLine($"Número de Cuenta: {cuenta.NumeroDeCuenta}, Titular: {cuenta.NombreTitular}, Saldo: ${cuenta.Saldo}");
        }

        Console.ReadKey();
    }
}
