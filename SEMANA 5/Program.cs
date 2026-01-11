using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejecutando los 5 ejercicios de Listas y Tuplas (Aprende con Alf)\n");

        new Ejercicio1().Ejecutar();
        new Ejercicio2().Ejecutar();
        new Ejercicio4().Ejecutar();
        new Ejercicio5().Ejecutar();
        new Ejercicio8().Ejecutar();

        Console.WriteLine("Todos los ejercicios han sido ejecutados correctamente.");
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}