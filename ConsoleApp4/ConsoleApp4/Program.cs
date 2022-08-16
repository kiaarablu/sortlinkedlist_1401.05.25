using SortLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation a = new Operation();
            a.Enqueue(15);
            a.Enqueue(21);
            a.Enqueue(7);
            a.Enqueue(42);
            a.Enqueue(20);
            a.Enqueue(9);
            a.Enqueue(11);
            a.Print();
            Console.WriteLine("-----------------------------");
            a.SortLinkedList();
            a.Print();
            Console.WriteLine("-----------------------------");
            Console.ReadKey();


        }
    }
}
