namespace _2_StackSum
{
    internal class StackSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter arr nums: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();
            foreach (int num in arr)
            {
                stack.Push(num);
            }

            Console.WriteLine("enter your commands: ");


            bool flag = true;

            while (flag)
            {
                string[] fullCommand = Console.ReadLine().Split();

                string command = fullCommand[0].ToLower();

                switch (command)
                {
                    case "add":
                        stack.Push(int.Parse(fullCommand[1]));
                        stack.Push(int.Parse(fullCommand[2]));
                        break;


                    case "remove":
                        int count = int.Parse(fullCommand[1]);
                        if (count <= stack.Count)
                        {
                            while (count > 0)
                            {
                                stack.Pop();
                                count--;
                            }
                        }
                        break;
                    case "end":
                        int sum = 0;
                        while (stack.Count() > 0)
                        {
                            sum += stack.Pop();
                        }

                        Console.WriteLine($"Sum: {sum}");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("enter valid command");
                        break;
                }
            }

        }
    }
}
