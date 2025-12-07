using System;

namespace Semana2
{
    public class Rectangulo
    {
        //se usa private para encapsulamiento y se definen, base y altura
        private double Base=8;
        private double Altura=4;

        //metodos para calcular Area y Perimetro
        //CalcularArea es un metodo que calcula y muesra el area del rectangulo usando la formula base*altura
        public double CalcularArea()
        {
            return Base*Altura;
        }

        //CalcularPerimetro es un metodo que calcula y muesra en consola el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2*(Base+Altura);
        }
    }
}