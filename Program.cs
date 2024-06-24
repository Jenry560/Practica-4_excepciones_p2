using System;

namespace Practica_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void InvalidUsernameException()
            {
                throw new Exception("Usuario o contrasena vacios");
            }
            void InvalidPasswordException()
            {
                throw new Exception("Contrasena demasia corta");
            }
            try
            {
                Console.WriteLine("Escribe nombre de usuario");
                string usuario = Console.ReadLine();
                Console.WriteLine("Escribe contrasena");
                string password = Console.ReadLine();
                if (usuario == "" || password == "")
                {
                    InvalidUsernameException();

                }
                if (password.Length < 8)
                {
                    InvalidPasswordException();
                }
            }catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error: {ex.Message}");
            } finally
            {
                Console.WriteLine("Proceso de validacion finalizado");
            }
        }
    }
}
