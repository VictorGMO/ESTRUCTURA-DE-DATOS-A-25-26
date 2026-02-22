using System;
using System.Collections.Generic;

//Clase que encapsula la lógica de gestion de vacunacion usando conjuntos.
//se tiliza HashSet<T> para representar colecciones sin duplicados y aplicar operaciones matematicas.
public class GestorVacunacion
{
    // Conjuntos que representan a la población y a los vacunados
    private HashSet<string> todos = new();           //todos los ciudadanos (1 a 500)
    private HashSet<string> pfizer = new();          //ciudadanos con al menos una dosis de Pfizer
    private HashSet<string> astrazeneca = new();     //ciudadanos con al menos una dosis de AstraZeneca

    // Genera datos ficticios siguiendo los requisitos:
    //- 500 ciudadanos totales
    //- 75 vacunados con Pfizer(Ciudadano 1 a 75)
    //- 75 vacunados con AstraZeneca (Ciudadano 51 a 125)
    //esto crea un solapamiento intencional: los ciudadanos 51-75 tienen ambas dosis.
    public void GenerarDatos()
    {
        for (int i = 1; i <= 500; i++)
            todos.Add($"Ciudadano {i}");

        for (int i = 1; i <= 75; i++)
            pfizer.Add($"Ciudadano {i}");

        for (int i = 51; i <= 125; i++)
            astrazeneca.Add($"Ciudadano {i}");
    }

    // aplica operaciones de teoría de conjuntos para obtener los cuatro listados solicitados y muestra los resultados en la consola.
    public void MostrarResultados()
    {
        //1.NO VACUNADOS: quienes no estan en Pfizer NI en AstraZeneca
        //Se parte del conjunto total y se eliminan todos los vacunados
        var noVacunados = new HashSet<string>(todos);
        noVacunados.ExceptWith(pfizer);         // Quita Pfizer
        noVacunados.ExceptWith(astrazeneca);    // Quita AstraZeneca

        //2.AMBAS DOSIS: interseccion entre Pfizer y AstraZeneca
        //Solo quedan los elementos comunes a ambos conjuntos
        var ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astrazeneca);

        //3.SOLO PFIZER: quienes están en Pfizer pero NO en AstraZeneca
        var soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astrazeneca);

        //4.SOLO ASTRAZENECA: quienes están en AstraZeneca pero NO en Pfizer
        var soloAstra = new HashSet<string>(astrazeneca);
        soloAstra.ExceptWith(pfizer);

        //mostrar resultados (limitamos a 10 en "no vacunados" para evitar saturar la consola)
        Console.WriteLine("=== CIUDADANOS NO VACUNADOS (muestra de 10) ===");
        int count = 0;
        foreach (var c in noVacunados)
        {
            if (count++ >= 10) break;
            Console.WriteLine(c);
        }

        Console.WriteLine("\n=== CIUDADANOS CON AMBAS DOSIS ===");
        foreach (var c in ambasDosis)
            Console.WriteLine(c);

        Console.WriteLine("\n=== CIUDADANOS SOLO CON PFIZER ===");
        foreach (var c in soloPfizer)
            Console.WriteLine(c);

        Console.WriteLine("\n=== CIUDADANOS SOLO CON ASTRAZENECA ===");
        foreach (var c in soloAstra)
            Console.WriteLine(c);

        Console.WriteLine("\n✅ Operaciones completadas usando teoría de conjuntos (HashSet<T>).");
    }
}