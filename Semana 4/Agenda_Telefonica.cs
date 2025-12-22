using System;
using System.Collections.Generic;

namespace AgendaTelefonicaPOO
{
    //Clase AgendaTelefonica
    public class AgendaTelefonica
    {
        //Lista que funciona como vector
        private List<Contacto> contactos = new List<Contacto>();

        //Agregar un contacto
        public void AgregarContacto()
        {
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el teléfono: ");
            string telefono = Console.ReadLine();

            Console.Write("Ingrese el correo: ");
            string correo = Console.ReadLine();

            Contacto nuevo = new Contacto(nombre, telefono, correo);
            contactos.Add(nuevo);

            Console.WriteLine("Contacto agregado correctamente.\n");
        }

        //Buscar contacto por nombre
        public void BuscarContacto()
        {
            Console.Write("Ingrese el nombre a buscar: ");
            string nombreBuscar = Console.ReadLine();

            bool encontrado = false;

            foreach (Contacto c in contactos)
            {
                if (c.Nombre.Equals(nombreBuscar, StringComparison.OrdinalIgnoreCase))
                {
                    c.Mostrar();
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Contacto no encontrado.\n");
            }
        }

        //Mostrar todos los contactos
        public void MostrarContactos()
        {
            if (contactos.Count == 0)
            {
                Console.WriteLine("No existen contactos registrados.\n");
            }
            else
            {
                Console.WriteLine("LISTA DE CONTACTOS");
                foreach (Contacto c in contactos)
                {
                    c.Mostrar();
                }
            }
        }

        //Menu principal
        public void Menu()
        {
            int opcion;

            do
            {
                Console.WriteLine("===== AGENDA TELEFÓNICA =====");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Buscar contacto");
                Console.WriteLine("3. Mostrar contactos");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        AgregarContacto();
                        break;
                    case 2:
                        BuscarContacto();
                        break;
                    case 3:
                        MostrarContactos();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.\n");
                        break;
                }

            } while (opcion != 4);
        }
    }}
