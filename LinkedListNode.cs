using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLIst
{
    public class LinkedListNode
    {
        
            public int Data;
            public LinkedListNode Next;

            public LinkedListNode(int data)
            {
                Data = data;
                Next = null;
            }
        
    }
}
