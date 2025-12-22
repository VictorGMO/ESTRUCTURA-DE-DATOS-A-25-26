using System;

namespace AgendaTelefonicaPOO
{
    //Clase Contacto: representa un registro
    public class Contacto
    {
        //Atributos del contacto
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        //Constructor
        public Contacto(string nombre, string telefono, string correo)
        {
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
        }

        //Metodo para mostrar la información del contacto
        public void Mostrar()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Teléfono: " + Telefono);
            Console.WriteLine("Correo: " + Correo);
            Console.WriteLine("----------------------------");
        }
    }
}
