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
                
                Node temp = q.Dequeue();
                Console.Write(temp.data + " , ");
                if (temp.left != null)
                    q.Enqueue(temp.left);

                if (temp.right != null)
                    q.Enqueue(temp.right);
                
            }
        }
    }
}
