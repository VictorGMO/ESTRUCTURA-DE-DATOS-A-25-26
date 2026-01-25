using System;
using System.Collections.Generic;

public class Balanceador
{
    public static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            //Si el caracter es un simbolo de apertura, se agrega a la pila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            //Si el caracter es un simbolo de cierre, se verifica coincidencia con el ultimo apertura
            else if (c == ')' || c == '}' || c == ']')
            {
                //Si la pila esta vacia, no hay simbolo de apertura correspondiente
                if (pila.Count == 0)
                    return false;

                char ultimo = pila.Pop();

                //Compara si el tipo de cierre coincide con el ultimo apertura
                if ((c == ')' && ultimo != '(') ||
                    (c == '}' && ultimo != '{') ||
                    (c == ']' && ultimo != '['))
                {
                    return false;
                }
            }
            //Los demas caracteres (numeros, operadores, espacios) se ignoran
        }

        //La expresion esta balanceada si la pila queda vacia al final
        return pila.Count == 0;
    }
}