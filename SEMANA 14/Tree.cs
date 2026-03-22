using System;
using System.Collections.Generic;

namespace ArbolBinarioBST
{
    public class Tree
    {
        public Node Root { get; set; }

        public Tree()
        {
            Root = null;
        }

        // Insertar valor
        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
            Console.WriteLine($"✓ Valor {value} insertado.");
        }

        private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                return new Node(value);
            }

            if (value < root.Value)
                root.Left = InsertRec(root.Left, value);
            else if (value > root.Value)
                root.Right = InsertRec(root.Right, value);
            else
                Console.WriteLine($"⚠ Valor {value} ya existe.");

            return root;
        }

        // Buscar valor
        public bool Search(int value)
        {
            Node result = SearchRec(Root, value);
            if (result != null)
            {
                Console.WriteLine($"✓ Valor {value} encontrado.");
                return true;
            }
            else
            {
                Console.WriteLine($"✗ Valor {value} NO encontrado.");
                return false;
            }
        }

        private Node SearchRec(Node root, int value)
        {
            if (root == null || root.Value == value)
                return root;

            if (value < root.Value)
                return SearchRec(root.Left, value);
            else
                return SearchRec(root.Right, value);
        }

        // Eliminar valor
        public void Delete(int value)
        {
            if (SearchRec(Root, value) == null)
            {
                Console.WriteLine($"✗ El valor {value} no existe.");
                return;
            }

            Root = DeleteRec(Root, value);
            Console.WriteLine($"✓ Valor {value} eliminado.");
        }

        private Node DeleteRec(Node root, int value)
        {
            if (root == null)
                return root;

            if (value < root.Value)
                root.Left = DeleteRec(root.Left, value);
            else if (value > root.Value)
                root.Right = DeleteRec(root.Right, value);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Value = MinValue(root.Right);
                root.Right = DeleteRec(root.Right, root.Value);
            }
            return root;
        }

        private int MinValue(Node root)
        {
            int min = root.Value;
            while (root.Left != null)
            {
                min = root.Left.Value;
                root = root.Left;
            }
            return min;
        }

        // Recorrido Pre-Orden
        public void PreOrder()
        {
            Console.WriteLine("\n--- PRE-ORDEN ---");
            if (Root == null)
            {
                Console.WriteLine("Árbol vacío.");
                return;
            }
            PreOrderRec(Root);
            Console.WriteLine();
        }

        private void PreOrderRec(Node node)
        {
            if (node != null)
            {
                Console.Write(node.Value + " ");
                PreOrderRec(node.Left);
                PreOrderRec(node.Right);
            }
        }

        // Recorrido In-Orden
        public void InOrder()
        {
            Console.WriteLine("\n--- IN-ORDEN ---");
            if (Root == null)
            {
                Console.WriteLine("Árbol vacío.");
                return;
            }
            InOrderRec(Root);
            Console.WriteLine();
        }

        private void InOrderRec(Node node)
        {
            if (node != null)
            {
                InOrderRec(node.Left);
                Console.Write(node.Value + " ");
                InOrderRec(node.Right);
            }
        }

        // Recorrido Post-Orden
        public void PostOrder()
        {
            Console.WriteLine("\n--- POST-ORDEN ---");
            if (Root == null)
            {
                Console.WriteLine("Árbol vacío.");
                return;
            }
            PostOrderRec(Root);
            Console.WriteLine();
        }

        private void PostOrderRec(Node node)
        {
            if (node != null)
            {
                PostOrderRec(node.Left);
                PostOrderRec(node.Right);
                Console.Write(node.Value + " ");
            }
        }

        // Mínimo
        public int FindMin()
        {
            if (Root == null)
            {
                Console.WriteLine("✗ Árbol vacío.");
                return -1;
            }

            Node current = Root;
            while (current.Left != null)
                current = current.Left;

            Console.WriteLine($"✓ Mínimo: {current.Value}");
            return current.Value;
        }

        // Máximo
        public int FindMax()
        {
            if (Root == null)
            {
                Console.WriteLine("✗ Árbol vacío.");
                return -1;
            }

            Node current = Root;
            while (current.Right != null)
                current = current.Right;

            Console.WriteLine($"✓ Máximo: {current.Value}");
            return current.Value;
        }

        // Altura
        public int Height()
        {
            int h = HeightRec(Root);
            Console.WriteLine($"✓ Altura: {h}");
            return h;
        }

        private int HeightRec(Node root)
        {
            if (root == null)
                return -1;

            int leftHeight = HeightRec(root.Left);
            int rightHeight = HeightRec(root.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        // Contar nodos
        public int CountNodes()
        {
            int count = CountNodesRec(Root);
            Console.WriteLine($"✓ Nodos totales: {count}");
            return count;
        }

        private int CountNodesRec(Node root)
        {
            if (root == null)
                return 0;

            return 1 + CountNodesRec(root.Left) + CountNodesRec(root.Right);
        }

        // Contar hojas
        public int CountLeaves()
        {
            int count = CountLeavesRec(Root);
            Console.WriteLine($"✓ Hojas: {count}");
            return count;
        }

        private int CountLeavesRec(Node root)
        {
            if (root == null)
                return 0;

            if (root.Left == null && root.Right == null)
                return 1;

            return CountLeavesRec(root.Left) + CountLeavesRec(root.Right);
        }

        // Mostrar estructura
        public void Display()
        {
            Console.WriteLine("\n--- Estructura ---");
            if (Root == null)
            {
                Console.WriteLine("Árbol vacío.");
                return;
            }
            DisplayRec(Root, "", true);
        }

        private void DisplayRec(Node node, string indent, bool last)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("└──");
                    indent += "   ";
                }
                else
                {
                    Console.Write("├──");
                    indent += "│  ";
                }
                Console.WriteLine(node.Value);

                DisplayRec(node.Left, indent, false);
                DisplayRec(node.Right, indent, true);
            }
        }

        // Limpiar
        public void Clear()
        {
            Root = null;
            Console.WriteLine("✓ Árbol limpiado.");
        }
    }
}