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
            LinkedList list = new LinkedList();
           /* Console.WriteLine("select the following");
            Console.WriteLine("1.Add element to linked list.");
            int obj=Convert.ToInt32(Console.ReadLine());
            switch(obj)
            {
                case 1:
                    list.Add(56); 
                    list.Add(30);
                    list.Add(70);
                    list.ToDisplay();
                    break;
            }

            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            list.ToDisplay();*/
            list.AddInReverseOrder(90);
            list.AddInReverseOrder(100);
            list.AddInReverseOrder(110);
            list.ToDisplay();

            list.Removeatfirst();
            list.ToDisplay();

            list.RemoveLast();
            list.ToDisplay();

            Console.ReadLine();
        }
    }
}
