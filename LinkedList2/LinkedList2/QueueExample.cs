﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    internal class QueueExample
    {
        public void QueueMethod()
        {
            Queue queue = new Queue();
            queue.Enqueue(15);
            queue.Enqueue(25);
            queue.Enqueue(35);
            queue.Enqueue(45);
            var remove = queue.Dequeue();
            Console.WriteLine(remove);
            foreach (var item in queue)
            {
                Console.WriteLine("Queue elenents :" + item);
            }
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine("dequeue elements:" + item);
            }
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Contains(15));
        }
        public void QueueMethodGenerics()
        {
            Queue<double> name = new Queue<double>();           
            name.Enqueue(1.25);
            name.Enqueue(2.05);
            name.Enqueue(3.54);
            foreach(var i in name)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(name.Peek());

        }
    }
}
