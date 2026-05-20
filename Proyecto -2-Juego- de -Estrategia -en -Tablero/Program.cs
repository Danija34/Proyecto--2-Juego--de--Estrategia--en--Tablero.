
using JuegoTablero;

class Program
{
    static void Main()
    {
        Login login = new Login();

  
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


namespace JuegoTablero
{
    public class Login
    {
     
        string contralogincorrecta = "CDemo2026##";

       
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
    
        public void MoverPieza()
        {
            {
                Console.WriteLine("Fila origen:");
                int fo = int.Parse(Console.ReadLine());

                Console.WriteLine("Columna origen:");
                int co = int.Parse(Console.ReadLine());

                Console.WriteLine("Fila destino:");
                int fd = int.Parse(Console.ReadLine());

                Console.WriteLine("Columna destino:");
                int cd = int.Parse(Console.ReadLine());

                if (fo < 0 || fo > 7 ||
                    co < 0 || co > 7 ||
                    fd < 0 || fd > 7 ||
                    cd < 0 || cd > 7)
                {
                    Console.WriteLine("Posición inválida");
                    Console.ReadLine();
                    return;
                }

                Pieza pieza =
                tablero.casillas[fo, co];

                if (pieza == null)
                {
                    Console.WriteLine("No hay pieza ahí");
                    Console.ReadLine();
                    return;
                }

              
                if (pieza.jugador != turno)
                {
                    Console.WriteLine("Esa pieza no es tuya");
                    Console.ReadLine();
                    return;
                }

                bool movimientoValido = false;

                if (pieza.tipo == "Rey")
                {
                    if (Math.Abs(fd - fo) <= 1 &&
                        Math.Abs(cd - co) <= 1)
                    {
                        movimientoValido = true;
                    }
                }
                else if (pieza.tipo == "Torre")
                {
                    if (fo == fd || co == cd)
                    {
                        movimientoValido = true;
                    }
                }

      
                else if (pieza.tipo == "Soldado")
                {
                    int direccion =
                    pieza.jugador == 1 ? -1 : 1;

                    if (cd == co &&
                        fd == fo + direccion &&
                        tablero.casillas[fd, cd] == null)
                    {
                        movimientoValido = true;
                    }

                    if (Math.Abs(cd - co) == 1 &&
                        fd == fo + direccion &&
                        tablero.casillas[fd, cd] != null)
                    {
                        movimientoValido = true;
                    }
                }

                if (!movimientoValido)
                {
                    Console.WriteLine("Movimiento inválido");
                    Console.ReadLine();
                    return;
                }

           
                if (tablero.casillas[fd, cd] != null &&
                    tablero.casillas[fd, cd].jugador == turno)
                {
                    Console.WriteLine("No puedes capturar tu propia pieza");
                    Console.ReadLine();
                    return;
                }

             
                Pieza capturada =
                tablero.casillas[fd, cd];

                if (capturada != null)
                {
                    Console.WriteLine(
                    "Capturaste un " +
                    capturada.tipo);


                    int puntos = 0;

                    if (capturada.tipo == "Soldado")
                        puntos = 1;

                    else if (capturada.tipo == "Torre")
                        puntos = 5;

                    else if (capturada.tipo == "Rey")
                        puntos = 20;

                    if (turno == 1)
                        puntosJ1 += puntos;

                    else
                        puntosJ2 += puntos;

                    if (puntosJ1 > mejorPuntaje)
                    {
                        mejorPuntaje = puntosJ1;
                        mejorJugador = j1.nombre;
                    }

                    if (puntosJ2 > mejorPuntaje)
                    {
                        mejorPuntaje = puntosJ2;
                        mejorJugador = j2.nombre;
                    }
                }

              
                tablero.casillas[fd, cd] =
                pieza;

                tablero.casillas[fo, co] =
                null;
            }
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
namespace JuegoTablero
{
    public class Tablero
    {
       
        public Pieza[,] casillas =
        new Pieza[8, 8];

        public void Inicializar()
        {
           
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    casillas[i, j] = null;
                }
            }

            casillas[7, 3] =
            new Pieza("Rey", 'R', 1);

            casillas[0, 3] =
            new Pieza("Rey", 'r', 2);

          
            casillas[7, 0] =
            new Pieza("Torre", 'T', 1);

            casillas[7, 7] =
            new Pieza("Torre", 'T', 1);

            casillas[0, 0] =
            new Pieza("Torre", 't', 2);

            casillas[0, 7] =
            new Pieza("Torre", 't', 2);


            for (int j = 0; j < 4; j++)
            {
                casillas[6, j * 2] =
                new Pieza(
                "Soldado",
                'S',
                1);

                casillas[1, j * 2] =
                new Pieza(
                "Soldado",
                's',
                2);
            }
        }

        public void Mostrar()
        {
            Console.WriteLine(
            " 0 1 2 3 4 5 6 7");

            for (int i = 0; i < 8; i++)
            {
                Console.Write(i + " ");

                for (int j = 0; j < 8; j++)
                {
                    if (casillas[i, j] == null)
                        Console.Write(". ");

                    else
                        Console.Write(
                        casillas[i, j]
                        .simbolo + " ");
                }

                Console.WriteLine();
            }
        }
    }
}