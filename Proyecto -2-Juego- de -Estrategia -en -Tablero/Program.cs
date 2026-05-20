//Program.cs
using JuegoTablero;

class Program
{
    static void Main()
    {
        Login login = new Login();

        //Si el login falla, termina
        if (!login.IniciarSesion())
            return;

        int opcionmenu;

        do
        {
            Console.Clear();

            Console.WriteLine("··········································································\r\n: ██ ▄█▀ ██▓ ███▄    █   ▄████   ██████                                  :\r\n: ██▄█▒ ▓██▒ ██ ▀█   █  ██▒ ▀█▒▒██    ▒                                  :\r\n:▓███▄░ ▒██▒▓██  ▀█ ██▒▒██░▄▄▄░░ ▓██▄                                    :\r\n:▓██ █▄ ░██░▓██▒  ▐▌██▒░▓█  ██▓  ▒   ██▒                                 :\r\n:▒██▒ █▄░██░▒██░   ▓██░░▒▓███▀▒▒██████▒▒                                 :\r\n:▒ ▒▒ ▓▒░▓  ░ ▒░   ▒ ▒  ░▒   ▒ ▒ ▒▓▒ ▒ ░                                 :\r\n:░ ░▒ ▒░ ▒ ░░ ░░   ░ ▒░  ░   ░ ░ ░▒  ░ ░                                 :\r\n:░ ░░ ░  ▒ ░   ░   ░ ░ ░ ░   ░ ░  ░  ░                                   :\r\n:░▄████▄ ░ ▒█████   ███▄    █░  █████░  █    ██ ▓█████   ██████ ▄▄▄█████▓:\r\n:▒██▀ ▀█  ▒██▒  ██▒ ██ ▀█   █ ▒██▓  ██▒ ██  ▓██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒:\r\n:▒▓█    ▄ ▒██░  ██▒▓██  ▀█ ██▒▒██▒  ██░▓██  ▒██░▒███   ░ ▓██▄   ▒ ▓██░ ▒░:\r\n:▒▓▓▄ ▄██▒▒██   ██░▓██▒  ▐▌██▒░██  █▀ ░▓▓█  ░██░▒▓█  ▄   ▒   ██▒░ ▓██▓ ░ :\r\n:▒ ▓███▀ ░░ ████▓▒░▒██░   ▓██░░▒███▒█▄ ▒▒█████▓ ░▒████▒▒██████▒▒  ▒██▒ ░ :\r\n:░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ▒ ▒ ░░ ▒▒░ ▒ ░▒▓▒ ▒ ▒ ░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░   :\r\n:  ░  ▒     ░ ▒ ▒░ ░ ░░   ░ ▒░ ░ ▒░  ░ ░░▒░ ░ ░  ░ ░  ░░ ░▒  ░ ░    ░    :\r\n:░        ░ ░ ░ ▒     ░   ░ ░    ░   ░  ░░░ ░ ░    ░   ░  ░  ░    ░      :\r\n:░ ░          ░ ░           ░     ░       ░        ░  ░      ░           :\r\n:░                                                                       :\r\n··········································································");
            Console.WriteLine("--> |1. Iniciar Partida|");
            Console.WriteLine("--> |2. Ver reglas|");
            Console.WriteLine("--> |3. Ver puntaje más alto|");
            Console.WriteLine("--> |4. Salir|");

            Console.Write("Seleccione su destino: ");

            int.TryParse(
            Console.ReadLine(),
            out opcionmenu);

            switch (opcionmenu)
            {
                case 1:

                    //Crea el juego y lo inicia
                    Juego juego = new Juego();
                    juego.Iniciar();

                    break;

                case 2:

                    Console.Clear();
                    Console.WriteLine("=========================LAS REGLAS=========================");
                    Console.WriteLine("- El rey se mueve una casilla en cualquier dirección");
                    Console.WriteLine("- La torre se mueve solo de forma horizontal o vertical");
                    Console.WriteLine("- El soldado solo avanza una casilla");
                    Console.WriteLine("- El soldado ataca diagonal");
                    Console.WriteLine("- Captura al rey y conseguirás la victoria");
                    Console.WriteLine("========Presiona Cualquier tecla para volver al Menú========");
                    Console.ReadLine();

                    break;

                case 3:

                    Juego.MostrarPuntajeGlobal();

                    break;

                case 4:

                    Console.WriteLine(
                    "Saliendo...");

                    break;

                default:

                    Console.WriteLine(
                    "Opción inválida");

                    Console.ReadLine();

                    break;
            }

        }
        while (opcionmenu != 4);
    }
}
/ Login.cs

namespace JuegoTablero
{
    public class Login
    {
        //Contraseña del sistema
        string contralogincorrecta = "CDemo2026##";

        //Función para ocultar contraseña con *
        static string leercontralogin()
        {
            string pass = "";
            ConsoleKeyInfo tecla;

            do
            {
                tecla = Console.ReadKey(true);

                if (tecla.Key != ConsoleKey.Enter &&
                    tecla.Key != ConsoleKey.Backspace)
                {
                    pass += tecla.KeyChar;
                    Console.Write("*");
                }

                else if (tecla.Key == ConsoleKey.Backspace &&
                         pass.Length > 0)
                {
                    pass = pass.Substring(
                    0,
                    pass.Length - 1);

                    Console.Write("\b \b");
                }

            }
            while (tecla.Key != ConsoleKey.Enter);

            return pass;
        }

        //Proceso completo de login
        public bool IniciarSesion()
        {
            string contraseñalogin;

            do
            {
                Console.Clear();
                Console.WriteLine("··········································································\r\n: ██ ▄█▀ ██▓ ███▄    █   ▄████   ██████                                  :\r\n: ██▄█▒ ▓██▒ ██ ▀█   █  ██▒ ▀█▒▒██    ▒                                  :\r\n:▓███▄░ ▒██▒▓██  ▀█ ██▒▒██░▄▄▄░░ ▓██▄                                    :\r\n:▓██ █▄ ░██░▓██▒  ▐▌██▒░▓█  ██▓  ▒   ██▒                                 :\r\n:▒██▒ █▄░██░▒██░   ▓██░░▒▓███▀▒▒██████▒▒                                 :\r\n:▒ ▒▒ ▓▒░▓  ░ ▒░   ▒ ▒  ░▒   ▒ ▒ ▒▓▒ ▒ ░                                 :\r\n:░ ░▒ ▒░ ▒ ░░ ░░   ░ ▒░  ░   ░ ░ ░▒  ░ ░                                 :\r\n:░ ░░ ░  ▒ ░   ░   ░ ░ ░ ░   ░ ░  ░  ░                                   :\r\n:░▄████▄ ░ ▒█████   ███▄    █░  █████░  █    ██ ▓█████   ██████ ▄▄▄█████▓:\r\n:▒██▀ ▀█  ▒██▒  ██▒ ██ ▀█   █ ▒██▓  ██▒ ██  ▓██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒:\r\n:▒▓█    ▄ ▒██░  ██▒▓██  ▀█ ██▒▒██▒  ██░▓██  ▒██░▒███   ░ ▓██▄   ▒ ▓██░ ▒░:\r\n:▒▓▓▄ ▄██▒▒██   ██░▓██▒  ▐▌██▒░██  █▀ ░▓▓█  ░██░▒▓█  ▄   ▒   ██▒░ ▓██▓ ░ :\r\n:▒ ▓███▀ ░░ ████▓▒░▒██░   ▓██░░▒███▒█▄ ▒▒█████▓ ░▒████▒▒██████▒▒  ▒██▒ ░ :\r\n:░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ▒ ▒ ░░ ▒▒░ ▒ ░▒▓▒ ▒ ▒ ░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░   :\r\n:  ░  ▒     ░ ▒ ▒░ ░ ░░   ░ ▒░ ░ ▒░  ░ ░░▒░ ░ ░  ░ ░  ░░ ░▒  ░ ░    ░    :\r\n:░        ░ ░ ░ ▒     ░   ░ ░    ░   ░  ░░░ ░ ░    ░   ░  ░  ░    ░      :\r\n:░ ░          ░ ░           ░     ░       ░        ░  ░      ░           :\r\n:░                                                                       :\r\n··········································································");
                Console.WriteLine("Ingrese la contraseña para ingresar al juego:");

                contraseñalogin =
                leercontralogin();

                if (contraseñalogin != contralogincorrecta)
                {
                    Console.WriteLine(
                    "\n\nContraseña incorrecta.");

                    Console.WriteLine(
                    "Intente nuevamente.");

                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine(
                    "Contraseña correcta");

                    Console.WriteLine(
                    "Cargando ingreso...");

                    System.Threading.Thread.Sleep(1500);

                    return true;
                }

            }
            while (contraseñalogin != contralogincorrecta);

            return false;
        }
    }
}
