using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_Prioridad_L
{
    public class PriorityQueue
    {
        private PriorityNode head;

        public PriorityQueue()
        {
            head = null;
        }

        // Enqueue: inserta según la prioridad (menor int = mayor prioridad)
        public void Enqueue(string data, int priority)
        {
            PriorityNode newNode = new PriorityNode(data, priority);

            if (head == null || priority < head.Priority)
            {
                // nuevo nodo va al inicio
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                PriorityNode h = head;
                while (h.Next != null && h.Next.Priority <= priority)
                {
                    h = h.Next;
                }
                newNode.Next = h.Next;
                h.Next = newNode;
            }
        }

        // Dequeue: elimina el nodo de mayor prioridad (head)
        public string Dequeue()
        {
            if (head == null)
                throw new InvalidOperationException("La cola está vacía");

            string value = head.Data;
            head = head.Next;
            return value;
        }

        // Revisar si está vacía
        public bool IsEmpty()
        {
            return head == null;
        }

        // Mostrar todos los elementos
        public void PrintQueue()
        {
            if (head == null)
            {
                Console.WriteLine("La cola está vacía");
                return;
            }

            PriorityNode h = head;
            while (h != null)
            {
                Console.Write($"[{h.Data}, prioridad: {h.Priority}] -> ");
                h = h.Next;
            }
            Console.WriteLine(" Null ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue pq = new PriorityQueue();

            pq.Enqueue("Tarea1", 3);
            pq.Enqueue("Tarea2", 1);
            pq.Enqueue("Tarea3", 2);
            pq.Enqueue("Tarea4", 1);

            pq.PrintQueue();
            Console.WriteLine("Eliminamos el elemento con mayor prioridad: " + pq.Dequeue());
            pq.PrintQueue();

            Console.ReadLine();
        }
    }
}
