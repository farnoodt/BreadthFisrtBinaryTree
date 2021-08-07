using System;

namespace BreadthFisrtBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = new Node(10);
            tree.left = new Node(21);
            tree.right = new Node(19);
            tree.left.right = new Node(15);
            tree.right.right = new Node(0);
            tree.right.left = new Node(-6);

            BreadthFirstTree BFS = new BreadthFirstTree();
            BFS.LevelOrderTree(tree);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
