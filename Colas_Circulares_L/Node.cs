using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Colas_Circulares_L
{
    internal class Node
    {
        private int data;
        private Node next;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
