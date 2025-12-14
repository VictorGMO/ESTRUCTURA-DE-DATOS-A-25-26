using System;
using System.Data.Common;
namespace Semana3
{
public class Gestor
{
    //Array privado para almacenar los numeros de telefono
    private string[] array;
   //constructor que recibe un array de strings y lo asigna al campo interno    public Gestor(string[] _array)
    
    public Gestor(string[] _array){
        this.array = _array;
    }
//metodo publico para imprimir cada numero
    public void PrintArray()
    {
        foreach (string num in array)
        {
            Console.WriteLine("Numeros de Celular:"+num);
            
        }
    }
}}

