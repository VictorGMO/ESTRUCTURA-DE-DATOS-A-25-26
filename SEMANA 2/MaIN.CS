using System;

namespace Semana2
{
    class Figuras
    {
        public static void Main(string[] args)
        {
            Cuadrado c = new Cuadrado();
            //se llaman los metodos del cuadrado
            double areaC = c.CalcularArea();
            double periC = c.CalcularPerimetro();

            //se muestran los resultados del cuadrado en consola
            Console.WriteLine("El Area del cuadrado es: " + areaC + "cm²");
            Console.WriteLine("El Perimetro del cuadrado es: " + periC + "cm");

            Rectangulo r = new Rectangulo();

            //se llaman los metodos del rectangulo
            double areaR = r.CalcularArea();
            double periR = r.CalcularPerimetro();

            //se muestran los resultados del rectangulo en consola
            Console.WriteLine("El Area del rectangulo es: " + areaR + "cm²");
            Console.WriteLine("El Perimetro del rectangulo es: " + periR + "cm");
        }
    }
}