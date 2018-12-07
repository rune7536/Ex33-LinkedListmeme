using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adt
{
    public class Node
    {
        private object data;
        private Node next;

        public Node Next { get; set; }
        public object Data { get; set; }


        public Node(object o)
        {
            data = Data;
            next = Next;
        }
    }
}
