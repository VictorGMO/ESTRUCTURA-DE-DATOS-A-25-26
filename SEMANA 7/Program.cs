using System;

class Program
{
    static void Main(string[] args)
    {
      //Muestra el menu de opciones al usuario
        Console.WriteLine("=== Tarea Semana 7: Pilas en C# ===\n");
        Console.WriteLine("1. Verificar paréntesis balanceados");
        Console.WriteLine("2. Resolver Torres de Hanoi");
        Console.Write("\nSeleccione una opción (1 o 2): ");
        
        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            //solicita una expresion al usuario
            Console.Write("\nIngrese una expresión matemática: ");
            string expr = Console.ReadLine();
            //Verifica si los simbolos están balanceados
            bool ok = Balanceador.EstaBalanceada(expr);
            //muestra el resultado
            Console.WriteLine(ok ? "Formula balanceada." : "Formula NO balanceada.");
        }
        else if (opcion == "2")
        {
            //Solicita el número de discos
            Console.Write("\nIngrese el número de discos (ej. 3): ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                //Crea una instancia del problema de Torres de Hanoi
                TorresHanoi hanoi = new TorresHanoi(n);
                //Ejecuta la solucion paso a paso
                hanoi.Iniciar();
            }
            else
            {
                //Informa si el número ingresado no es válido
                Console.WriteLine("Numero invalido. Use un entero positivo.");
            }
        }
        else
        {
            //Informa que la opcion no existe
            Console.WriteLine("Opcion no valida.");
        }
    }
}