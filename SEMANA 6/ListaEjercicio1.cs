
//Implementación de una lista enlazada simple para el Ejercicio 1.
//incluye método para contar la cantidad de nodos en la lista.

public class ListaEjercicio1
{
    public Nodo Cabeza { get; private set; } //puntero al primer nodo de la lista


    //constructor: inicializa la lista vacía.
  
    public ListaEjercicio1()
    {
        Cabeza = null;
    }


    //Inserta un nuevo nodo al inicio de la lista.
  
    public void InsertarInicio(int dato)
    {
        Nodo nuevo = new Nodo(dato);   //crear nuevo nodo
        nuevo.Siguiente = Cabeza;    //el nuevo nodo apunta al nodo actual de la cabeza
        Cabeza = nuevo;  //la cabeza ahora es el nuevo nodo
    }


    //cuenta cuántos nodos hay en la lista.
    //recorre desde la cabeza hasta el final (null) e incrementa un contador.
  
    //Número total de elementos en la lista
    public int ContarElementos()
    {
        int contador = 0;      //inicializar contador
        Nodo actual = Cabeza;         //empezar desde la cabeza

        //recorrer mientras haya nodos
        while (actual != null)
        {
            contador++;     //contar el nodo actual
            actual = actual.Siguiente;   //avanzar al siguiente nodo
        }

        return contador;    //Devolver el total
    }
}