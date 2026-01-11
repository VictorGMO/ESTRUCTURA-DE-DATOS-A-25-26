using System;

public class Ejercicio8
{
    public void Ejecutar()
    {
        string palabra = "reconocer"; //palabra predefinida(es palindromo)
        Console.WriteLine("=== Ejercicio 8 ===");
        Console.WriteLine($"Palabra evaluada: {palabra}");

        string limpia = palabra.ToLower();
        char[] letras = limpia.ToCharArray();
        Array.Reverse(letras);
        string invertida = new string(letras);

        if (limpia == invertida)
            Console.WriteLine("Resultado: Es un palindromo");
        else
            Console.WriteLine("Resultado: No es un palindromo");
        Console.WriteLine();
    }
}