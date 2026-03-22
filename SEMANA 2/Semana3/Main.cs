// Uso
using System;
namespace Semana3
{
class Program
{
    static void Main(string[] args)
    {
       DatosP Estudiante= new DatosP();
        Estudiante.datos();
        
        string[] nums = { "0946010547", "0933849235", "0926328734" };
        Gestor celular= new Gestor(nums);
        celular.PrintArray();
    }
}
}