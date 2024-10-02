namespace _7_HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter list of children");

            string[] input = Console.ReadLine().Split();

            int toss = int.Parse(Console.ReadLine());



            CircularLinkedList<string> children = new CircularLinkedList<string>();

            foreach (string s in input)
            {
                children.Add(s);
            }

            //children.Display();
            //Console.WriteLine();
            //Gosho Pesho Misho Stefan Krasi
            // 1

            while (children.Count() > 1)
            {
                //int len = children.Count();
                //Console.WriteLine($"len = {len}");

                //int outChildPosition = ((toss + len) % toss);
                //Console.WriteLine($"outChildPosition = {outChildPosition}");

                //Console.WriteLine($"head = {children.Head()}");

                string outChild = children.Delete(toss - 1);
                Console.WriteLine($"removed {outChild}");
            }

            Console.WriteLine($"Last is {children.Head()}");
        }
    }
}