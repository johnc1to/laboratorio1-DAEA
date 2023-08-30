// See https://aka.ms/new-console-template for more information
using laboratorio1;

//Persona persona = new Persona();
//persona.Apellidos = "Baldeon";
//persona.Nombres = "John";
//persona.Edad = 21;

//Console.WriteLine("Los nombres completos son: ");
//Console.WriteLine(persona.RetornarNombresCompleto());

//if (persona.EsMayorEdad())
//Console.WriteLine("Es mayor de edad");
//else
//Console.WriteLine("Es menor de edad");

//Empleado empleado = new Empleado
//{
//Nombres = "Michael",
//Apellidos = "Huaman",
//Edad = 24,
//Sueldo = 1600,
//};
//Console.WriteLine("El impuesto es: ");
//Console.WriteLine(empleado.CalcularImpuesto(8));

CuentaBancaria cuenta = new CuentaBancaria(123456, 1000, 1234, "John Piero");
CajeroAutomatico cajero = new CajeroAutomatico(cuenta);

bool loggedIn = false;
int pinIngresado = 0;

while (true)
{
    if (!loggedIn)
    {
        Console.Write("Bienvenido/a al cajero automático.\nIngrese su PIN: ");
        pinIngresado = Convert.ToInt32(Console.ReadLine());

        if (cuenta.ValidarPin(pinIngresado))
        {
            Console.WriteLine("PIN válido. Acceso permitido.\n");
            loggedIn = true;
        }
        else
        {
            Console.WriteLine("PIN incorrecto. Intente nuevamente.");
        }
    }
    else
    {
        cajero.RealizarOperaciones();
        Console.WriteLine("¿Desea realizar otra operación? (Sí/No): ");
        string respuesta = Console.ReadLine().Trim().ToLower();
        if (respuesta == "no")
        {
            Console.WriteLine("Cerrando sesión...");
            loggedIn = false;
        }
    }
}
