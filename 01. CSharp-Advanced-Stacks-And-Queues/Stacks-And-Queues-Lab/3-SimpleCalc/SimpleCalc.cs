namespace _3_SimpleCalc
{
    internal class SimpleCalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your expressions:");

            string[] expression = Console.ReadLine().Split();

            #region Without Stack
            /*
            //2 + 5 + 10 - 2 - 1     // 14
            int result = int.Parse(expression[0]);

            for (int i = 1; i < expression.Length - 1; i++)
            {
                if (expression[i] == "+")
                {
                    result += int.Parse(expression[i + 1]);
                }
                else if (expression[i] == "-")
                {
                    result -= int.Parse(expression[i + 1]);
                }
            }

            Console.WriteLine(result);
            */
            #endregion


            #region Using 2stacks (one for operators and another for numbers)

            Stack<int> stackOfNums = new Stack<int>();
            Stack<string> stackOfOprators = new Stack<string>();

            for (int i = expression.Length - 1; i >= 0; i--)
            {
                if (int.TryParse(expression[i], out int num))
                {
                    stackOfNums.Push(num);
                }
                else
                {
                    stackOfOprators.Push(expression[i]);
                }
            }

            //2 + 5 + 10 - 2 - 1     // 14

            int result = stackOfNums.Pop();

            while (stackOfOprators.Count > 0)
            {
                if (stackOfOprators.Peek() == "+")
                {
                    result += stackOfNums.Pop();
                }
                else if (stackOfOprators.Peek() == "-")
                {
                    result -= stackOfNums.Pop();
                }
                stackOfOprators.Pop();
            }

            Console.WriteLine(result);

            #endregion
        }
    }
}
