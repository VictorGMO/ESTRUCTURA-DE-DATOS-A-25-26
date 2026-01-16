using System;


//Programa principal que ejecuta los Ejercicios 1 y 2.

class Program
{
    static void Main()
    {
        //EJERCICIO 1
        Console.WriteLine("=== EJERCICIO 1: Contar elementos ===");
        var lista1 = new ListaEjercicio1();
        //inserto 3 elementos: 15 → 10 → 5 (porque insertamos al inicio)
        lista1.InsertarInicio(5);
        lista1.InsertarInicio(10);
        lista1.InsertarInicio(15);
        int total = lista1.ContarElementos();
        Console.WriteLine($"La lista tiene {total} elementos.");

        //EJERCICIO 2
        Console.WriteLine("\n=== EJERCICIO 2: Invertir lista ===");
        var lista2 = new ListaEjercicio2();
        //Inserto 1, luego 2, luego 3 → lista queda: 3 → 2 → 1
        lista2.InsertarInicio(1);
        lista2.InsertarInicio(2);
        lista2.InsertarInicio(3);

        Console.Write("Lista original: ");
        lista2.Mostrar();

        lista2.InvertirLista(); //ahora queda: 1 → 2 → 3

        Console.Write("Lista invertida: ");
        lista2.Mostrar();
    }
}