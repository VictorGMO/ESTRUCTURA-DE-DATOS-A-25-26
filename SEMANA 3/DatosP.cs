namespace Semana3

{
    public class DatosP
    {
        //atributos privados para almacenar los datos del estudiante
    private int id= 12345;
    private string nombres= "Juan Pablo"; 
    private string Apellidos= "Sanchez Guzman";
    private string Direccion= "Av. Amazonas N34-56 y Av. Colón";
    //metodo público para mostrar los datos del estudiante
    public void datos()
        {
        Console.WriteLine("ID:"+id);
        Console.WriteLine("Nombre:"+nombres);
        Console.WriteLine("Apellido:"+Apellidos);
        Console.WriteLine("Direccion:"+Direccion);
        }
}}