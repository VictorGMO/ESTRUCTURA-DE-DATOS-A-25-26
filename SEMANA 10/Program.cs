
class Program
{
    static void Main()
    {
        //instancia del gestor que maneja toda la lógica de conjuntos
        var gestor = new GestorVacunacion();
        
        //genera los conjuntos ficticios de ciudadanos y vacunados
        gestor.GenerarDatos();
        
        //muestra los resultados de las operaciones de teoría de conjuntos
        gestor.MostrarResultados();
    }
}