using System;

namespace ArbolBinarioBST
{
    public class Menu
    {
        private Tree tree;

        public Menu()
        {
            tree = new Tree();
        }

        public void Show()
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.Clear();
                Console.WriteLine("=== ARBOL BINARIO DE BUSQUEDA ===\n");
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Buscar");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Pre-Orden");
                Console.WriteLine("5. In-Orden");
                Console.WriteLine("6. Post-Orden");
                Console.WriteLine("7. Mínimo");
                Console.WriteLine("8. Máximo");
                Console.WriteLine("9. Altura");
                Console.WriteLine("10. Contar nodos");
                Console.WriteLine("11. Contar hojas");
                Console.WriteLine("12. Mostrar arbol");
                Console.WriteLine("13. Limpiar");
                Console.WriteLine("14. Salir");
                Console.Write("\nOpción: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1": HandleInsert(); break;
                    case "2": HandleSearch(); break;
                    case "3": HandleDelete(); break;
                    case "4": tree.PreOrder(); break;
                    case "5": tree.InOrder(); break;
                    case "6": tree.PostOrder(); break;
                    case "7": tree.FindMin(); break;
                    case "8": tree.FindMax(); break;
                    case "9": tree.Height(); break;
                    case "10": tree.CountNodes(); break;
                    case "11": tree.CountLeaves(); break;
                    case "12": tree.Display(); break;
                    case "13": HandleClear(); break;
                    case "14":
                        Console.WriteLine("\nFin del programa.");
                        continueProgram = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                if (continueProgram)
                {
                    Console.WriteLine("\nPresione tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        private void HandleInsert()
        {
            Console.Write("Valor: ");
            if (int.TryParse(Console.ReadLine(), out int value))
                tree.Insert(value);
            else
                Console.WriteLine("Valor inválido.");
        }

        private void HandleSearch()
        {
            Console.Write("Buscar: ");
            if (int.TryParse(Console.ReadLine(), out int value))
                tree.Search(value);
            else
                Console.WriteLine("Valor inválido.");
        }

        private void HandleDelete()
        {
            Console.Write("Eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int value))
                tree.Delete(value);
            else
                Console.WriteLine("Valor inválido.");
        }

        private void HandleClear()
        {
            Console.Write("¿Seguro? (s/n): ");
            if (Console.ReadLine()?.ToLower() == "s")
                tree.Clear();
        }
    }
}