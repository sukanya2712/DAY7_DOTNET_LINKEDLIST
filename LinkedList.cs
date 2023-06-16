using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLIst
{
  
       

        class LinkedList
        {
            private LinkedListNode head;

            public void AddFirst(int data)
            {
                LinkedListNode newNode = new LinkedListNode(data);
                newNode.Next = head;
                head = newNode;
            }

            public void AddLast(int data)
            {
                LinkedListNode newNode = new LinkedListNode(data);

                if (head == null)
                {
                    head = newNode;
                    return;
                }

                LinkedListNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }

            public void AddInBetween(int data, int position)
            {
            if (position <= 0)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            LinkedListNode newNode = new LinkedListNode(data);

           

            LinkedListNode current = head;
            LinkedListNode previous = null;
            for (int i = 0; i < position && current != null; i++)
            {
                previous = current;
                current = current.Next;
            }

            previous.Next = newNode;
            newNode.Next = current;
            }

            public void DeleteFirst()
            {
                if (head == null)
                {
                    Console.WriteLine("Linked list is empty");
                    return;
                }

                head = head.Next;
            }

            public void DeleteLast()
            {
                if (head == null)
                {
                    Console.WriteLine("Linked list is empty");
                    return;
                }

                if (head.Next == null)
                {
                    head = null;
                    return;
                }

                LinkedListNode current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }

                current.Next = null;
            }

            public void DeleteInBetween(int position)
            {
            if (position <= 0)
            {
                Console.WriteLine("Invalid position");
                return;
            }

           
            LinkedListNode current = head;
            LinkedListNode previous = null;
            for (int i = 0; i < position && current != null; i++)
            {
                previous = current;
                current = current.Next;
            }

            previous.Next = current.Next;
            

            }

            public void Display()
            {
                LinkedListNode current = head;

                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }

                Console.WriteLine();
            }
        }

    }

