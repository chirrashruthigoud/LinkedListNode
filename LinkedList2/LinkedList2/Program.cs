using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    internal class Program
    {
      public static void Main(string[] args)
        {
            //LinkedList list = new LinkedList();
            // Console.WriteLine("select the following");
            // Console.WriteLine("1.Add element to linked list.\n2.Add element in reverse.\n3.Remove First Element\n4.Remove last element\n5.Size of LinkedList \n6.Queue Add Elements");
            // int obj=Convert.ToInt32(Console.ReadLine());
            // switch(obj)
            // {
            //     case 1:
            //         list.Add(56); 
            //         list.Add(30);
            //         list.Add(70);
            //         list.ToDisplay();
            //         break;
            //  case 2:
            //      list.AddInReverseOrder(90);
            //      list.AddInReverseOrder(100);
            //      list.AddInReverseOrder(110);
            //      list.ToDisplay();

            //        break;
            // case 3 :
            //        list.AddInReverseOrder(90);
            //        list.AddInReverseOrder(100);
            //        list.AddInReverseOrder(110);
            //        list.Removeatfirst();
            //        list.ToDisplay();
            //        break;
            // case 4 :
            //        list.AddInReverseOrder(90);
            //        list.AddInReverseOrder(100);
            //        list.AddInReverseOrder(110);
            //        list.RemoveLast();
            //        list.ToDisplay();
            //        break;
            //case 5 :
            //        list.AddInReverseOrder(90);
            //        list.AddInReverseOrder(100);
            //        list.AddInReverseOrder(110);
            //        list.Size();
            //        break;
            //case 6:
            //        QueueExample name= new QueueExample();
            //        name.QueueMethod();
            //        name.QueueMethodGenerics();
            //        break;

            //   default:
            //        Console.WriteLine("Not Found !");
            //        break;

            //}

            //QueueForLoop queue= new QueueForLoop();
            //queue.EnqueueMethod(40);
            //queue.EnqueueMethod(60);
            //queue.EnqueueMethod(80);
            //queue.DequeueMethod();
            //queue.Display();

            //StackExample stack = new StackExample();
            //stack.StackMethod();


            StackuseNode name= new StackuseNode();
            name.PushNode(90);
            name.PushNode(30);
            name.PushNode(40);
            name.PeekNode();
            name.PopNode();
            name.Display();
            Console.ReadLine();
        }
    }
}
