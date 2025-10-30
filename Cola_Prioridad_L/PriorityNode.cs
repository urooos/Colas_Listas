using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_Prioridad_L
{
    internal class PriorityNode
    {
        private string data;
        private int priority;
        private PriorityNode next;

        // Propiedad para acceder al dato
        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        // Propiedad para acceder a la prioridad
        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        // Propiedad para acceder al siguiente nodo
        public PriorityNode Next
        {
            get { return next; }
            set { next = value; }
        }

        // Constructor
        public PriorityNode(string data, int priority)
        {
            this.data = data;
            this.priority = priority;
            this.next = null; // por defecto apunta a null
        }
    }
}
