using System;
using System.Collections.Generic;
using System.IO;

// ===================== CLASES =====================

// Ejercicio 1: Cuenta bancaria
class CuentaBancaria
{
    private string titular;
    private int saldo;

    public CuentaBancaria(string titular, int saldoInicial)
    {
        this.titular = titular;
        this.saldo = saldoInicial;
    }

    // Propiedad de solo lectura: tiene get pero NO set
    public int Saldo
    {
        get { return saldo; }
    }

    public void Depositar(int monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("El deposito debe ser mayor a 0");
            return;
        }
        saldo += monto;
        Console.WriteLine("Deposito de " + monto + " Bs. Saldo: " + saldo + " Bs");
    }

    public void Retirar(int monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("El retiro debe ser mayor a 0");
            return;
        }
        if (monto > saldo)
        {
            Console.WriteLine("Saldo insuficiente. Saldo: " + saldo + " Bs");
            return;
        }
        saldo -= monto;
        Console.WriteLine("Retiro de " + monto + " Bs. Saldo: " + saldo + " Bs");
    }

    public void MostrarResumen()
    {
        Console.WriteLine("Cuenta de " + titular + " | Saldo final: " + saldo + " Bs");
    }
}

// ===================== PROGRAMA =====================

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine();
            Console.WriteLine("===== TAREA 7: CLASES Y ARCHIVOS =====");
            Console.WriteLine("Estudiante: Mauricio Gabriel Terrazas Gomez");
            Console.WriteLine("1. Cuenta bancaria");
            Console.WriteLine("2. Prestamo de libros");
            Console.WriteLine("3. Agenda de contactos con archivo");
            Console.WriteLine("4. Mi propia clase");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opcion: ");

            try
            {
                opcion = int.Parse(Console.ReadLine());
            }
            catch (Exception) // si escribe letras, la opcion no vale
            {
                opcion = -1;
            }

            switch (opcion)
            {
                case 1: Ejercicio1(); break;
                case 2: Ejercicio2(); break;
                case 3: Ejercicio3(); break;
                case 4: Ejercicio4(); break;
                case 0: Console.WriteLine("Hasta luego"); break;
                default: Console.WriteLine("Opcion no valida"); break;
            }
        } while (opcion != 0);
    }

    // Pide un numero entero y repite hasta que escriban uno valido
    static int LeerEntero(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Escribe un numero entero");
            }
        }
    }

    // Ejercicio 1: Cuenta bancaria
    static void Ejercicio1()
    {
        Console.Write("Titular: ");
        string titular = Console.ReadLine();
        int saldoInicial = LeerEntero("Saldo inicial: ");

        CuentaBancaria cuenta = new CuentaBancaria(titular, saldoInicial);

        int deposito = LeerEntero("Deposito: ");
        cuenta.Depositar(deposito);

        int retiro = LeerEntero("Retiro: ");
        cuenta.Retirar(retiro);

        cuenta.MostrarResumen();
    }

    // Ejercicio 2: Prestamo de libros
    static void Ejercicio2()
    {
        // pendiente
    }

    // Ejercicio 3: Agenda de contactos con archivo
    static void Ejercicio3()
    {
        // pendiente
    }

    // Ejercicio 4: Mi propia clase
    static void Ejercicio4()
    {
        // pendiente
    }
}
