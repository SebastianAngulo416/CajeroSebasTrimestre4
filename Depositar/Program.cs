using System;
namespace Depositar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido Estimado Usuario! Usted ha entrado al Cajero Automático SEBT");
            if (Ingresar())
            {
                Console.Beep();
                Console.WriteLine("Su Inicio de sesión o login ha sido exitoso");
                Depositar();
            }
            else
            {
                Console.Beep();
                Console.WriteLine("Su Inicio de sesión/login ha fallado");
            }
        }

        static bool Ingresar()
        {
            Console.Write("Ingrese su nombre de usuario: ");
            string nombreusuario = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string contraseña = Console.ReadLine();
            return nombreusuario == "Sebastian" && contraseña == "0416";
        }

        static void Depositar()
        {
            Console.Write("Ingrese la cantidad que quiere depositar: ");
            decimal cantidadddeposito = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Se ha depositado la cantidad de {cantidadddeposito:C}.");
        }
    }
}
