namespace _7_HotPotato
{
    // Make Node class generic
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T _data, Node<T> _next)
        {
            data = _data;
            next = _next;
        }
    }

    // Make CircularLinkedList generic
    public class CircularLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int size;

        public CircularLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Count()
        {
            return size;
        }

        private bool IsEmpty()
        {
            return size == 0;
        }

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data, null);
            if (IsEmpty())
            {
                newNode.next = newNode; // Point to itself if it's the only node
                head = newNode;
            }
            else
            {
                newNode.next = tail.next; // Point to the head
                tail.next = newNode;      // The previous tail points to the new node
            }

            tail = newNode; // Update the tail
            size += 1;
        }


        public T Delete(int toss)
        {
            int position = ((toss + size) % size);

            //Console.WriteLine($"outChildPosition = {position}");

            T data;
            int i = 1;
            Node<T> p = tail;

            while (i <= position)
            {
                p = p.next;
                i++;
            }

            //Console.WriteLine($"p = {p.data}");
            data = p.next.data;  // Get the data of the node to be removed
            p.next = p.next.next; // Remove the node by skipping it
            head = p.next;
            //Console.WriteLine($"head = {head.data}");
            tail = p;
            size -= 1;
            return data;

        }










        //public T DeleteAt(int position)
        //{
        //    if (position < 1 || position > size)
        //    {
        //        throw new ArgumentException("Invalid position!");
        //    }
        //    else
        //    {
        //        T data;
        //        int i = 1;
        //        Node<T> p = tail;

        //        while (i < position)
        //        {
        //            p = p.next;
        //            i++;
        //        }

        //        Console.WriteLine($"p = {p.data}");
        //        data = p.next.data;  // Get the data of the node to be removed
        //        p.next = p.next.next; // Remove the node by skipping it
        //        head = p.next;
        //        Console.WriteLine($"head = {head.data}");
        //        tail = p;
        //        size -= 1;
        //        return data;
        //    }
        //}

        public T Head()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("List is empty!");
            }
            return head.data;
        }

        public void Display()
        {
            int i = 0;
            Node<T> temp = head;
            while (i < size)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                i++;
            }
        }

    }
}
