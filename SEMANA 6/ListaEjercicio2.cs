
//Implementación de una lista enlazada simple para el Ejercicio 2.
//Incluye métodos para invertir la lista y mostrar su contenido.

public class ListaEjercicio2
{
    public Nodo Cabeza { get; private set; } // Puntero al primer nodo

   
    //constructor: inicializa la lista vacía.
  
    public ListaEjercicio2()
    {
        Cabeza = null;
    }

   
    /// Inserta un nuevo nodo al inicio de la lista.
  
    /// <param name="dato">Valor entero a insertar.</param>
    public void InsertarInicio(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.Siguiente = Cabeza;
        Cabeza = nuevo;
    }

  
    //Invierte el orden de los nodos en la lista.
    //Usa tres punteros: anterior, actual y siguiente.
    //al final la cabeza apunta al último nodo original.
  
    public void InvertirLista()
    {
        Nodo anterior = null;            //Comienza como null (será la nueva cola)
        Nodo actual = Cabeza;            //Empezamos desde la cabeza
        Nodo siguiente = null;           //Para guardar temporalmente el siguiente nodo

        //Recorremos toda la lista
        while (actual != null)
        {
            siguiente = actual.Siguiente; //Guardar referencia al siguiente nodo
            actual.Siguiente = anterior;  //Invertir el enlace: ahora apunta hacia atrás
            anterior = actual;            //Mover 'anterior' al nodo actual
            actual = siguiente;           //Avanzar al siguiente nodo original
        }

        //al terminar, 'anterior' es el último nodo → se convierte en la nueva cabeza
        Cabeza = anterior;
    }

  
    //muestra todos los datos de la lista en orden, separados por espacios.
  
    public void Mostrar()
    {
        Nodo actual = Cabeza;
        while (actual != null)
        {
            System.Console.Write(actual.Dato + " ");
            actual = actual.Siguiente;
        }
        System.Console.WriteLine(); // Salto de línea al final
    }
}