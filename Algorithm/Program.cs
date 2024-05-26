using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Node data = new Node(5);
            data.PrintAll();
            data.Insert(10, 1);
            data.PrintAll();
        }
    }
}
