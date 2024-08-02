using System;

namespace Transferir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido Estimado Usuario! Usted ha entrado al Cajero Automático SEBT");
            if (Ingreso())
            {
                Console.Beep();
                Console.WriteLine("Su inicio de sesión o Login fue un exito");
                Transferir();
            }
            else
            {
                Console.Beep();
                Console.WriteLine("Su Inicio de sesión/Login ha fallado");
            }
        }

        static bool Ingreso()
        {
            Console.Write("Ingrese su nombre de usuario: ");
            string nombreusuario = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string contraseña = Console.ReadLine();
            return nombreusuario == "Sebastian" && contraseña == "0416";
        }

        static void Transferir()
        {
            Console.Write("Ingrese la cantidad que quiere transferir a ota cuenta: ");
            decimal cantidadtransferir = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese el número de la cuenta a la que quiere mandar el dinero: ");
            string numero_cuentatransferir = Console.ReadLine();
            Console.WriteLine($"Acaba de transferir {cantidadtransferir:C} a la cuenta {numero_cuentatransferir}.");
        }
    }
}