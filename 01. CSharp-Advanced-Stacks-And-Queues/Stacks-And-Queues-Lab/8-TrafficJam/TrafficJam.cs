namespace _8_TrafficJam
{
    internal class TrafficJam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter pass number:");
            int pass = int.Parse(Console.ReadLine());

            Queue<string> trafficJam = new Queue<string>();

            string command = Console.ReadLine().ToLower();

            int count = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < pass && trafficJam.Count > 0; i++)
                    {
                        Console.WriteLine($"{trafficJam.Dequeue()} passed!");
                        count++;
                    }

                }
                else
                {
                    trafficJam.Enqueue(command);
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"{count} cars passed the crossroads");
        }
    }
}
