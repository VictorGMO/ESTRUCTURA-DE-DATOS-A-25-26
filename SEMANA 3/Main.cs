// Uso
using System;
namespace Semana3
{
class Program
{
    static void Main(string[] args)
    {
        //Crea una instancia de la clase DatosP 
       DatosP Estudiante= new DatosP();
       //llama al metodo datos para mostrar la informacion del estudiante
        Estudiante.datos();
        //defini un array con tres numeros de telefono
        string[] nums = { "0946010547", "0933849235", "0926328734" };
        Gestor celular= new Gestor(nums);
        //llama al metodo PrintArray para mostrar los numeros de telefono
        celular.PrintArray();
    }
}
}