using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Node
    {
        private int[] node;

        public Node(int count)
        {
            node = new int[count];
            for(int i=0;i<count;i++)
            {
                node[i] = i + 1;
            }
        }

        public void PrintAll()
        {
            foreach(int i in node)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

        }

        public void Insert(int data)
        {
            Array.Resize<int>(ref node, node.Length + 1);
            node[node.Length - 1] = data;
        }

        public void Insert(int data, int target)
        {
            Array.Resize<int>(ref node, node.Length + 1);

            int temp = node[target];
            int temp2 = node[target + 1];

            node[target + 1] = node[target];
            node[target] = data;

            for (int i=target; i < node.Length - 1; i++)
            {
                if (i == target)
                {
                    temp = node[i + 1];
                    node[i + 1] = node[i];
                    node[i] = data;
                }
                else
                {
                    node[i] = temp;
                    temp = node[i + 1];
                    node[i + 1] = node[i];
                }
            }
        }
    }
}
