using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_DobleSalida_L
{
    public class OutputRestrictedDeque
    {
        private DNode head; 

        public OutputRestrictedDeque()
        {
            head = null;
        }

        
        public bool IsEmpty()
        {
            return head == null;
        }

        
        public void InsertFront(int data)
        {
            DNode newNode = new DNode(data);

            if (IsEmpty())
            {
                head = newNode;
                return;
            }

            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }

        
        public void InsertRear(int data)
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

        
        public int DeleteFront()
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
                head.Prev = null;
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
            OutputRestrictedDeque deque = new OutputRestrictedDeque();

            // Insertar por ambos extremos
            deque.InsertRear(10);
            deque.InsertFront(5);
            deque.Show();
            Console.WriteLine("Agregamos por la cola");
            deque.InsertRear(20);
            deque.Show();
            Console.WriteLine("Agregamos por el frente");
            deque.InsertFront(2);

            deque.Show(); // 2 <-> 5 <-> 10 <-> 20 <-> null

            Console.WriteLine("Delete Front: " + deque.DeleteFront());
            deque.Show(); // 5 <-> 10 <-> 20 <-> null

            Console.WriteLine("Delete Front: " + deque.DeleteFront());
            deque.Show(); // 10 <-> 20 <-> null

            Console.ReadLine();
        }
    }
}
