using System;
using System.Data.Common;
namespace Semana3
{
public class Gestor
{
    
    private string[] array;

    public Gestor(string[] _array)
    {
        this.array = _array;
    }

    public void PrintArray()
    {
        foreach (string num in array)
        {
            Console.WriteLine("Numeros de Celular:"+num);
            
        }
    }
}}

