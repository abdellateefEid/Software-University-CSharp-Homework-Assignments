namespace _7_HotPotato
{
    internal class HotPotato
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter list of children");

            string[] input = Console.ReadLine().Split();

            int toss = int.Parse(Console.ReadLine());



            #region HotPotato Version1 Using CircularLinkedList
            /*
            CircularLinkedList<string> children = new CircularLinkedList<string>();

            foreach (string s in input)
            {
                children.Add(s);
            }

            while (children.Count() > 1)
            {
                string outChild = children.Delete(toss - 1);
                Console.WriteLine($"removed {outChild}");
            }

            Console.WriteLine($"Last is {children.Head()}");
            */
            #endregion


            Queue<string> children = new Queue<string>(input);
            while (children.Count > 1)
            {
                for (int i = 0; i < toss - 1; i++)
                {
                    children.Enqueue(children.Dequeue());
                }

                Console.WriteLine($"Removed {children.Dequeue()}");
            }

            Console.WriteLine($"Last is {children.Dequeue()}");

        }
    }
}