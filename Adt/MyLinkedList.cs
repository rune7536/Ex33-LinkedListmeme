using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adt
{
    public class MyLinkedList
    {
        private int count;


        public int Count { get { return this.count; } set { this.count = value; } }
        private Node Head;



        public void Insert(object m)
        {
            Insert(m, 0);
        }

        public void Insert(object m, int b)
        {
            Node n = new Node(m);
            // 1) tom 
            // index 0 
            switch (b)
            {
                case 0:
                    n.Next = Head;
                    Head = n;
                    n.Data = m;
                    break;

                //2) insert i midten
                // vis index er mellem 0 og antallet af listen

                //3) slutingen af listen
                // index er antallet af listen plus 1
                default:
                    Node temp = Head;
                    for (int i = 0; i < b - 1; i++)
                    {
                        temp = temp.Next;
                    }

                    n.Next = temp.Next;
                    temp.Next = n;
                    n.Data = m;
                    break;
            }
            count++;
        }

        public void Delete()
        {
            Delete(0);
        }


        public void Delete(int b)
        {
            switch (b)
            {
                case 0:
                    Node temp1 = Head;
                    Head = Head.Next;
                    temp1.Next = null;
                    Count--;
                    break;
                default:
                    Node temp2 = Head;
                    for (int i = 0; i < b - 1; i++)
                    {
                        temp2 = temp2.Next;
                    }
                    temp2.Next = temp2.Next.Next;
                    Count--;
                    break;
            }
        }

        public object ItemAt(int b)
        {
            Node pegepind = Head;
            for (int i = 0; i < b; i++)
            {
                pegepind = pegepind.Next;
            }
            return pegepind.Data;
        }

        public override string ToString()
        {
            string result = "";
            Node n = Head;
            while (n != null)
            {
                result = result + n.Data.ToString() + "\n";

                n = n.Next;
            }
            return result;

            /*string s = "";
            Node n = Head;
            for (int i = 0; i <= Count; i++)
            {
                s = s + n.Data.ToString() + "\n";//ItemAt(i) + "\n";
                n = n.Next;
            }
            return s;*/
        }

    }
}
