using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_DobleEntradaR_L
{
    public class InputRestrictedDeque
    {
        private DNode head; 

        public InputRestrictedDeque()
        {
            head = null;
        }

        
        public bool IsEmpty()
        {
            return head == null;
        }

        //solo se puede agregar por un extremo (al final)
        public void Enqueue(int data)
        {
            DNode newNode = new DNode(data);

            if (IsEmpty()) 
            {
                head = newNode;
                return;
            }

            
            DNode h = head;
            while (h.Next != null)
            {
                h = h.Next;
            }

            
            h.Next = newNode;
            newNode.Prev = h;
        }

        // se puede eliminar por ambos extremos
        // Eliminamos por el frente (head)
        public int DequeueFront()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La deque está vacía");

            int value = head.Data;

            if (head.Next == null) 
            {
                head = null;
            }
            else
            {
                head = head.Next;
                head.Prev = null; // rompemos la referencia hacia el anterior
            }

            return value;
        }

        // Eliminamos por el final
        public int DequeueRear()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La deque está vacía");

            
            DNode h = head;
            while (h.Next != null)
            {
                h = h.Next;
            }

            int value = h.Data;

            if (h.Prev == null) 
            {
                head = null;
            }
            else
            {
                h.Prev.Next = null; // desconectamos el último nodo
            }

            return value;
        }

        
        public void Show()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La deque está vacía");
                return;
            }

            DNode h = head;
            while (h != null)
            {
                Console.Write(h.Data + " <-> ");
                h = h.Next;
            }
            Console.WriteLine("null");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            InputRestrictedDeque deque = new InputRestrictedDeque();

            deque.Enqueue(10);
            deque.Enqueue(20);
            deque.Show();
            Console.WriteLine("Agregamos por la cola...");
            deque.Enqueue(30);

            deque.Show(); // 10 <-> 20 <-> 30 <-> null

            Console.WriteLine("Elimianmos por el frente: " + deque.DequeueFront());
            deque.Show(); // 20 <-> 30 <-> null

            Console.WriteLine("Eliminamos por la cola: " + deque.DequeueRear());
            deque.Show(); // 20 <-> null

            Console.ReadLine();
        }
    }
}
