﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    public class QueueForLoop
    {
        Node head = null;
        public void EnqueueMethod(int value)
        {
            Node node = new Node(value);
            if(head == null)
            {
              head= node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp=temp.next;
                }
                temp.next=node;
            }
            Console.WriteLine(node.data);
        }

        public void DequeueMethod()
        {
            if(head == null)
            {
                Console.WriteLine("queue is empty");
            }
            else
            {
                this.head = this.head.next;
                Console.WriteLine("queue is removed.");

            }
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
