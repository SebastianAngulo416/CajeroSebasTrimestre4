using System;

namespace Ver_Saldos
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
                Ver_Saldos();
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

        static void Ver_Saldos()
        {
            decimal saldo = 17900.00m; 
            Console.WriteLine($"El saldo actual que posee es {saldo:C}.");
        }
    }
}
