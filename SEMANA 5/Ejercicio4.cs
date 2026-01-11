using System;
using System.Collections.Generic;

public class Ejercicio4
{
    public void Ejecutar()
    {
        //numeros predefinidos de la loteria (simulación)
        List<int> numeros = new List<int> { 34, 7, 22, 45, 13, 9 };
        Console.WriteLine("=== Ejercicio 4 ===");
        Console.WriteLine("Números ganadores (originales): " + string.Join(", ", numeros));
        numeros.Sort();
        Console.WriteLine("Números ordenados de menor a mayor: " + string.Join(", ", numeros));
        Console.WriteLine();
    }
}