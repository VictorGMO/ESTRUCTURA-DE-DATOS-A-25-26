using System;

namespace Semana2
{
    //clase para cuadrado
    public class Cuadrado
    {
        //Se usa private para encapsulamiento y se define "lados"
        private double lados=5;

        // CalcularArea es un metodo que calcula y muesra el area del cuadrado usando la fórmula lado * lado. 
        public double CalcularArea()
        {
            return lados*lados; // usa valores de private
        }

        //CalcularPerimetro es un metodo que calcula y muesra en consola el perímetro del cuadrado.
        public double CalcularPerimetro()
        {
            return lados*4;
        }
    }}
 