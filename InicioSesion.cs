//INICIO DE SESION

using System;

class Programa
{
    static void Main(string[] args)
    {
        string usuarioPredefinido = "luis";
        string contrasenaPredefinida = "10366694";
        int intentosRestantes = 3;

        while (intentosRestantes > 0)
        {
            Console.WriteLine("Ingrese su nombre de usuario:");
            string usuario = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña:");
            string contrasena = Console.ReadLine();

            if (usuario == usuarioPredefinido && contrasena == contrasenaPredefinida)
            {
                Console.WriteLine("Acceso concedido");
                return;
            }
            else
            {
                intentosRestantes--;
                Console.WriteLine("Nombre de usuario o contraseña incorrectos. Intentos restantes: " + intentosRestantes);
            }
        }

        Console.WriteLine("Acceso denegado");
    }
}
