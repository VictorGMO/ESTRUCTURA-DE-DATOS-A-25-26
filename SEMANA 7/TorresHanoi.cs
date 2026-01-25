using System;
using System.Collections.Generic;

public class TorresHanoi
{
    private Stack<int> torreA, torreB, torreC;
    private int totalDiscos;

    public TorresHanoi(int n)
    {
        totalDiscos = n;
        torreA = new Stack<int>();
        torreB = new Stack<int>();
        torreC = new Stack<int>();

        //Coloca los discos en la torre A, del más grande al más pequeño (el mas pequeño queda arriba)
        for (int i = n; i >= 1; i--)
        {
            torreA.Push(i);
        }
    }

    private void MoverDisco(Stack<int> origen, Stack<int> destino, string nomOrigen, string nomDestino)
    {
        //Extrae el disco superior de la torre de origen
        int disco = origen.Pop();
        //coloca ese disco en la torre de destino
        destino.Push(disco);
        //Muestra el movimiento realizado
        Console.WriteLine($"Mover disco {disco} de {nomOrigen} a {nomDestino}");
    }

    private void Resolver(int n, Stack<int> origen, Stack<int> aux, Stack<int> dest,
                          string nomOrigen, string nomAux, string nomDest)
    {
        //mover un solo disco directamente al destino
        if (n == 1)
        {
            MoverDisco(origen, dest, nomOrigen, nomDest);
        }
        else
        {
            //mueve n-1 discos de la torre origen a la torre auxiliar
            Resolver(n - 1, origen, dest, aux, nomOrigen, nomDest, nomAux);
            //mueve el disco restante (el mas grande) de origen a destino
            MoverDisco(origen, dest, nomOrigen, nomDest);
            //mueve los n-1 discos desde la torre auxiliar al destino
            Resolver(n - 1, aux, origen, dest, nomAux, nomOrigen, nomDest);
        }
    }

    public void Iniciar()
    {
        //muestra un mensaje inicial con el numero de discos
        Console.WriteLine($"\nResolviendo Torres de Hanoi con {totalDiscos} discos:\n");
        //Inicia la resolución recursiva usando las tres torres
        Resolver(totalDiscos, torreA, torreB, torreC, "A", "B", "C");
    }
}