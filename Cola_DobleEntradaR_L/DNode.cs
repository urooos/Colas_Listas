using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_DobleEntradaR_L
{
    internal class DNode
    {
        private int data;
        private DNode next;
        private DNode prev;

        
        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        
        public DNode Next
        {
            get { return next; }
            set { next = value; }
        }

        
        public DNode Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        
        public DNode(int data)
        {
            this.data = data;
            this.next = null; 
            this.prev = null; 
        }
    }
}

