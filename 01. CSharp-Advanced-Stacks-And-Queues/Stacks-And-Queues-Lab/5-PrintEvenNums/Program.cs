namespace PrintEvenNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter nums:");

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(nums);

            while (queue.Count > 0)
            {
                if (queue.Peek() % 2 == 0)
                {
                    Console.Write(queue.Peek() + ", ");
                }

                queue.Dequeue();
            }
        }
    }
}
