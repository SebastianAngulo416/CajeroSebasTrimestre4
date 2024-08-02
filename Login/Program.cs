using System;

namespace Ingreso
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
    }
}