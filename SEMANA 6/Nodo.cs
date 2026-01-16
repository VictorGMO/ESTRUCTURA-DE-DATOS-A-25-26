
//Representa un nodo de una lista enlazada simple.
//Contiene un dato entero y una referencia al siguiente nodo.

public class Nodo
{
    public int Dato { get; set; } //valor almacenado en el nodo
    public Nodo Siguiente { get; set; } //referencia al siguiente nodo (null si es el último)

  
    ///Constructor del nodo.

    ///valor entero a almacenar en el nodo.
    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}