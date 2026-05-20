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
namespace JuegoTablero
{
    public class Juego
    {
        public Tablero tablero =
        new Tablero();

        public Jugador j1 =
        new Jugador();

        public Jugador j2 =
        new Jugador();

        public int turno = 1;

        public int puntosJ1 = 0;
        public int puntosJ2 = 0;

        public static int mejorPuntaje = 0;
        public static string mejorJugador =
        "Sin registros";

        public void Iniciar()
        {
            j1.Registrar(1);
            j2.Registrar(2);

            tablero.Inicializar();

            while (true)
            {
                Console.Clear();

                tablero.Mostrar();

                Console.WriteLine(
                "Turno: " +
                (turno == 1
                ? j1.nombre
                : j2.nombre));

                MoverPieza();

                if (VerificarGanador())
                    break;

                turno =
                turno == 1 ? 2 : 1;
            }
        }
        //Mover pieza
        public void MoverPieza()
        {
            //Aquí pegas la versión corregida
            //que te envié antes:
            //MovimientoValido
            //CaminoLibre
            //capturas
            //puntajes
        }

        public bool VerificarGanador()
        {
            return false;
        }

        public static void MostrarPuntajeGlobal()
        {
            Console.Clear();
            Console.WriteLine("==========Soldado de Honor==========");
            Console.WriteLine("El mejor jugador de la sesión es: " + mejorJugador);

            Console.WriteLine("Con un puntaje de: " + mejorPuntaje);
            Console.WriteLine("=====Presione cualquier tecla para volver al menú=====");

            Console.ReadLine();
        }
    }
}

//jugador.cs
namespace JuegoTablero
{
    public class Jugador
    {
        public int id;

        public string nombre;

        public void Registrar(
        int num)
        {
            id = num;

            Console.WriteLine("Nombre del jugador #" + num + ": ");

            nombre =
            Console.ReadLine();
        }
    }
}

//Pieza.cs
namespace JuegoTablero
{
    public class Pieza
    {
        public string tipo;

        public char simbolo;

        public int jugador;

        public Pieza(
        string tipo,
        char simbolo,
        int jugador)
        {
            this.tipo = tipo;
            this.simbolo = simbolo;
            this.jugador = jugador;
        }
    }
}
