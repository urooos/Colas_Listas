using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_Circulares_L
{
    public class CircularQueue
    {
        private Node head;

        public CircularQueue()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                head = newNode;
                head.Next = head; // apunta a sí mismo
            }
            else
            {
                Node h = head;
                // recorremos hasta el último nodo (que apunta a head)
                while (h.Next != head)
                {
                    h = h.Next;
                }
                h.Next = newNode;
                newNode.Next = head; // nuevo nodo apunta a head
            }
        }

       
        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La cola está vacía");

            int value = head.Data;

            if (head.Next == head) // solo un nodo
            {
                head = null;
            }
            else
            {
                // buscamos el último nodo para actualizar su Next
                Node h = head;
                while (h.Next != head)
                {
                    h = h.Next;
                }
                h.Next = head.Next; // último nodo apunta al nuevo head
                head = head.Next;   // movemos head
            }
            return value;
        }

      
        public void Show()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía");
                return;
            }

            Node h = head;
            while(true)
            {
                Console.Write(h.Data + " -> ");
                h = h.Next;
                if (h == head)
                    break;
            }
            Console.WriteLine("(vuelve al inicio)");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularQueue cq = new CircularQueue();

            cq.Enqueue(1);
            cq.Enqueue(2);
            cq.Enqueue(3);

            cq.Show(); // 1 -> 2 -> 3 -> (vuelve al inicio)

            Console.WriteLine("Elemento eliminado " + cq.Dequeue());
            cq.Show(); // 2 -> 3 -> (vuelve al inicio)

            Console.ReadLine();
        }
    }
}
