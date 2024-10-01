namespace _4_MatchBrcket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your arithmetic expression:");

            /*
            1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5	
            (2 + 3)
            (3 + 1)
            (2 - (2 + 3) * 4 / (3 + 1))
            */

            string expression = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int start = stack.Pop();
                    int len = i - start + 1;
                    Console.WriteLine(expression.Substring(start, len));
                }
            }

            /*
             Hints
               • Scan through the expression searching for brackets
                   o If you find an opening bracket, push the index into the stack
                   o If you find a closing bracket pop the topmost element from the stack. This is the index of the
                   opening bracket.
                   o Use the current and the popped index to extract the sub-expression
             */
        }
    }
}
