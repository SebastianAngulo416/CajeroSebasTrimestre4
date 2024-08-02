using System;
namespace Retirar_Fondos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido Estimado Usuario! Usted ha entrado al Cajero Automático SEBT");
            if (Ingreso())
            {
                Console.Beep();
                Console.WriteLine("Su Inicio de sesión o login ha exitoso");
                Retirar();
            }
            else
            {
                Console.Beep();
                Console.WriteLine("Su Inicio de sesión/login ha fallado");
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

        static void Retirar()
        {
            Console.Write("Ingrese la cantidad a retirar: ");
            decimal cantidadretirada = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Has retirado {cantidadretirada:C}.");
        }
    }
}
