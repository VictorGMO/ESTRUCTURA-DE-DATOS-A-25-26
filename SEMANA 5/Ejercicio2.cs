using System;
using System.Collections.Generic;

public class Ejercicio2
{
    public void Ejecutar()
    {
        List<string> asignaturas = new List<string> { "Matematicas", "Fisica", "Quimica", "Historia", "Lengua" };
        Console.WriteLine("=== Ejercicio 2 ===");
        foreach (string asig in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asig}");
        }
        Console.WriteLine();
    }
}