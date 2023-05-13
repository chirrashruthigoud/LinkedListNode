using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    public class Node
    {
        public int data;
        public Node next;//Address of a node
        //constructor
        public Node(int data)
        {
            this.data = data;
        }
    }
}
