namespace Colas_Listas
{
    public class SimpleQueue
    {
        private Node? head;

        public SimpleQueue()
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
            }
            else
            {
                Node h = head;
                while (h.Next != null)
                {
                    h = h.Next;
                }
                h.Next = newNode;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La cola está vacía");

            int value = head.Data;
            head = head.Next;
            return value;
        }

        public void Show()
        {
            Node? h = head;
            while (h != null)
            {
                Console.Write(h.Data + " -> ");
                h = h.Next;
            }
            Console.WriteLine("null");
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            SimpleQueue queue = new SimpleQueue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Show(); // 10 -> 20 -> null
            Console.WriteLine("Agregamos un elemento a la cola...");
            queue.Enqueue(30);

            queue.Show(); // 10 -> 20 -> 30 -> null

            Console.WriteLine("Elemento eliminado: " + queue.Dequeue());
            queue.Show(); // 20 -> 30 -> null

            Console.ReadLine();
        }
    }
}

