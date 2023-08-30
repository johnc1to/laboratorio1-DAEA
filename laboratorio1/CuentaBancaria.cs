using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio1
{
    public class CuentaBancaria
    {
        public int NumeroCuenta { get; }
        public decimal Saldo { get; private set; }
        public int Pin { get; set; }
        public string Titular { get; }

        public CuentaBancaria(int numeroCuenta, decimal saldoInicial, int pin, string titular)
        {
            NumeroCuenta = numeroCuenta;
            Saldo = saldoInicial;
            Pin = pin;
            Titular = titular;
        }

        public bool ValidarPin(int pin)
        {
            return Pin == pin;
        }

        public void Depositar(decimal monto)
        {
            Saldo += monto;
        }

        public bool Retirar(decimal monto)
        {
            if (monto <= Saldo)
            {
                Saldo -= monto;
                return true;
            }
            return false;
        }

        public void CambiarPin(int nuevoPin)
        {
            Pin = nuevoPin;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo actual: {Saldo:C}");
        }
    }
}
