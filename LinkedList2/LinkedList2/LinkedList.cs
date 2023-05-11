using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    internal class LinkedLists
    {
        public Node head;//empty node
        public void Add(int data)
        {
            Node node=new Node(data);
            if(this.head== null)
            {
                this.head= node;
            }
            else
            {
                Node temp = head;//storing last data in temp variable
                while (temp.next !=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Linkedlist", node.data);
        }
    }
}
