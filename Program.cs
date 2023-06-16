using System.Collections.Generic;

namespace LinkedLIst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList1 = new LinkedList();

            linkedList1.AddFirst(30);
            linkedList1.AddFirst(20);
            linkedList1.AddFirst(10);

            linkedList1.Display();

            linkedList1.AddLast(40);
            linkedList1.AddLast(50);
            linkedList1.AddLast(60);

            linkedList1.Display();

            linkedList1.AddInBetween(1, 2);
            linkedList1.AddInBetween(2, 5);
            linkedList1.AddInBetween(3, 8);

            linkedList1.Display();

            linkedList1.DeleteFirst();
            linkedList1.DeleteLast();
            linkedList1.DeleteInBetween(2);

            linkedList1.Display();
        }
    }
}