namespace _6_Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter customers name:");

            Queue<string> customers = new Queue<string>();

            string input = Console.ReadLine().ToLower();


            while (input != "end")
            {
                if (input == "paid")
                {
                    while (customers.Count > 0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(input);
                }
                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
