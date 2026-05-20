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

