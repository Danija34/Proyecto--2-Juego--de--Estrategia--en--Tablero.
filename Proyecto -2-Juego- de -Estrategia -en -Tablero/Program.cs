// Contraseña: CDemo2026##

static string leercontralogin()
{
    string pass = "";
    ConsoleKeyInfo tecla;

    do
    {
        tecla = Console.ReadKey(true);

        if (tecla.Key != ConsoleKey.Enter && tecla.Key != ConsoleKey.Backspace)
        {
            pass += tecla.KeyChar;
            Console.Write("*");
        }
        else if (tecla.Key == ConsoleKey.Backspace && pass.Length > 0)
        {
            pass = pass.Substring(0, pass.Length - 1);
            Console.Write("\b \b");
        }

    } while (tecla.Key != ConsoleKey.Enter);

    return pass;

}

string contralogincorrecta = "CDemo2026##";
string contraseñalogin;

do
{
    Console.WriteLine("Ingrese la contraseña para ingresar al juego: ");
    contraseñalogin = leercontralogin();

    if (contraseñalogin != contralogincorrecta)
    {
        Console.WriteLine("Contraseña incorrecta. Intente nuevamente.");
    }
    else
    {
        Console.WriteLine("Contraseña correcta, Cargando ingreso...");

        int opcionmenu;

        do
        {

            Console.WriteLine(" _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _ \r\n||||||||||||||||||||||||||||||||||||||||||||||||||||\r\n||                                                                        ||\r\n||*█████*███████******************||\r\n||░░███*███░░░░*******************||\r\n||*░██████████████████*████████████***********||\r\n||*░███████░░██░░███░░██████░░██████░░************||\r\n||*░███░░███░███░███░███░███░██░░█████**********||\r\n||*░███░░███░███░███░███░███░███░░░░███***********||\r\n||*█████░░███████████████░░█████████████**********||\r\n||░░░░░*░░░░░░░░░░░░░░░░░░░░░██░░░░░░***********||\r\n||**********███░███*************||\r\n||*********░░██████*************||\r\n||**********░░░░░░**************||\r\n||**█████████*****************█████*||\r\n||*███░░░░░███****************░░███***||\r\n||*███*░░░██████████████*█████████████████████████████████**||\r\n||*░███***███░░██░░███░░██████░░██░░███░██████░░█████░░░░███░*||\r\n||░███**░███░███░███░███░███░███░███░███░██████░░█████░███**||\r\n||*░░███**██░███░███░███░███░███░███░███░███░███░░░░░░░██░██████||\r\n||*░░█████████░░██████████████░░███████░░███████░░████████████░░█████*||\r\n||**░░░░░░░░░░░░░░░░░░░░░░░░░░░░░███░░░░░░░░░░░░░░░░░░░░*░░░░░**||\r\n||*************░███***********||\r\n||*************█████**********||\r\n||************░░░░░***********||\r\n|| _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _  _ ||\r\n||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("--> 1. |Iniciar Partida|");
            Console.WriteLine("--> 2. |Ver las Reglas del Juego|");
            Console.WriteLine("--> 3. |Ver el Puntaje Más Alto|");
            Console.WriteLine("--> 4. |Salir|");
            Console.WriteLine("Elige una opción");
            if (int.TryParse(Console.ReadLine(), out opcionmenu))
            {
                switch (opcionmenu)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:
                        Console.WriteLine("Saliendo del juego.... ¡Hasta luego!");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
            }

        } while (opcionmenu != 4);
    }

} while (contraseñalogin != "CDemo2026##");