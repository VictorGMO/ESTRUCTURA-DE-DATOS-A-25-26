using System;
using System.Collections.Generic;

public class Ejercicio1
{
    public void Ejecutar()
    {
        List<string> asignaturas = new List<string> { "Matematicas", "Fisica", "Quimica", "Historia", "Lengua" };
        Console.WriteLine("=== Ejercicio 1 ===");
        Console.WriteLine("Asignaturas del curso:");
        foreach (string asig in asignaturas)
        {
            Console.WriteLine(asig);
        }
        Console.WriteLine();
    }
}