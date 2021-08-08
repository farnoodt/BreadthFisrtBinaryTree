using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthFisrtBinaryTree
{
    class BreadthFirstTree
    {
        public void LevelOrderTree(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            if (root == null)
                return ;

            q.Enqueue(root);
            
            while (q.Count != 0)
            {
                
                root = q.Dequeue();
                Console.Write(root.data + " , ");
                if (root.left != null)
                    q.Enqueue(root.left);

                if (root.right != null)
                    q.Enqueue(root.right);
                
            }
        }

        public void PreOrderTree(Node root)
        {
            Stack<Node> s = new Stack<Node>();
            if (root == null)
                return;

            s.Push(root);

            while (s.Count != 0)
            {

                root = s.Pop();
                Console.Write(root.data + " , ");
                if (root.right != null)
                    s.Push(root.right);

                if (root.left != null)
                    s.Push(root.left);

            }
        }
    }
}
