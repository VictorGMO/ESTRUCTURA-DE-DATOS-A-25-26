using System;

public class MenuInteractivo
{
    private readonly Traductor _traductor = new Traductor();

    //inicia el ciclo principal del menu interactivo.
    public void Iniciar()
    {
        Console.WriteLine("Bienvenido al Traductor Basico Español a Ingles\n");

        bool salir = false;
        while (!salir)
        {
            MostrarOpciones();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    EjecutarTraduccion();
                    break;
                case "2":
                    EjecutarAgregarPalabra();
                    break;
                case "0":
                    salir = true;
                    Console.WriteLine("¡Gracias por usar el traductor!");
                    break;
                default:
                    Console.WriteLine("Opcion no válida. Por favor, seleccione 0, 1 o 2.\n");
                    break;
            }
        }
    }

    //muestra el menu con el formato exacto solicitado en la tarea.
    private void MostrarOpciones()
    {
        Console.WriteLine("==================== MENU ====================");
        Console.WriteLine("1. Traducir una frase");
        Console.WriteLine("2. Agregar palabras al diccionario");
        Console.WriteLine("0. Salir");
        Console.Write("Seleccione una opcion: ");
    }

    //solicita una frase al usuario y muestra su traduccion parcial
    private void EjecutarTraduccion()
    {
        Console.Write("\nIngrese una frase en español: ");
        string frase = Console.ReadLine();
        string traduccion = _traductor.TraducirFrase(frase);
        Console.WriteLine($"Traduccion: {traduccion}\n");
    }

    //Permite al usuario ingresar una nueva palabra y su traduccion.
    private void EjecutarAgregarPalabra()
    {
        Console.Write("\nIngrese la palabra en español: ");
        string espanol = Console.ReadLine();
        Console.Write("Ingrese la traduccion en ingles: ");
        string ingles = Console.ReadLine();

        if (_traductor.AgregarPalabra(espanol, ingles))
        {
            Console.WriteLine($"¡Palabra '{espanol}' agregada correctamente!\n");
        }
        else
        {
            Console.WriteLine("No se pudo agregar la palabra (esta vacia o ya existe).\n");
        }
    }
}