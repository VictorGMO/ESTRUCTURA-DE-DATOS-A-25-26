using System;

public class MenuInteractivo
{
    private readonly Traductor _traductor = new Traductor();

    // Inicia el ciclo principal del menú interactivo.
    public void Iniciar()
    {
        Console.WriteLine("Bienvenido al Traductor Básico Español → Inglés\n");

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
                    Console.WriteLine("Opción no válida. Por favor, seleccione 0, 1 o 2.\n");
                    break;
            }
        }
    }

    // Muestra el menú con el formato exacto solicitado en la tarea.
    private void MostrarOpciones()
    {
        Console.WriteLine("==================== MENÚ ====================");
        Console.WriteLine("1. Traducir una frase");
        Console.WriteLine("2. Agregar palabras al diccionario");
        Console.WriteLine("0. Salir");
        Console.Write("Seleccione una opción: ");
    }

    // Solicita una frase al usuario y muestra su traducción parcial.
    private void EjecutarTraduccion()
    {
        Console.Write("\nIngrese una frase en español: ");
        string frase = Console.ReadLine();
        string traduccion = _traductor.TraducirFrase(frase);
        Console.WriteLine($"Traducción: {traduccion}\n");
    }

    // Permite al usuario ingresar una nueva palabra y su traducción.
    private void EjecutarAgregarPalabra()
    {
        Console.Write("\nIngrese la palabra en español: ");
        string espanol = Console.ReadLine();
        Console.Write("Ingrese la traducción en inglés: ");
        string ingles = Console.ReadLine();

        if (_traductor.AgregarPalabra(espanol, ingles))
        {
            Console.WriteLine($"¡Palabra '{espanol}' agregada correctamente!\n");
        }
        else
        {
            Console.WriteLine("No se pudo agregar la palabra (está vacía o ya existe).\n");
        }
    }
}