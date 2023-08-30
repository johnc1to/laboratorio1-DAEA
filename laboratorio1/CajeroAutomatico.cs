using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio1
{
    class CajeroAutomatico 
    {
        private CuentaBancaria cuenta;

        public CajeroAutomatico(CuentaBancaria cuenta)
        {
            this.cuenta = cuenta;
        }

        public void RealizarOperaciones()
        {
            bool salir = false;

            Console.WriteLine($"Bienvenido/a, {cuenta.Titular}!");

            while (!salir)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar fondos");
                Console.WriteLine("3. Retirar efectivo");
                Console.WriteLine("4. Cambiar PIN");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        cuenta.ConsultarSaldo();
                        break;
                    case 2:
                        Console.Write("Ingrese el monto a depositar: ");
                        decimal montoDeposito = Convert.ToDecimal(Console.ReadLine());
                        cuenta.Depositar(montoDeposito);
                        Console.WriteLine("Depósito exitoso.");
                        break;
                    case 3:
                        Console.Write("Ingrese el monto a retirar: ");
                        decimal montoRetiro = Convert.ToDecimal(Console.ReadLine());
                        if (cuenta.Retirar(montoRetiro))
                        {
                            Console.WriteLine("Retiro exitoso.");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente.");
                        }
                        break;
                    case 4:
                        Console.Write("Ingrese su nuevo PIN: ");
                        int nuevoPin = Convert.ToInt32(Console.ReadLine());
                        cuenta.CambiarPin(nuevoPin);
                        Console.WriteLine("PIN cambiado exitosamente.");
                        break;
                    case 5:
                        salir = true;
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }

}


