namespace _1_ReverseStr
{
    internal class ReverseStr
    {
        static void Main(string[] args)
        {
            #region Reverse chars

            string input1 = Console.ReadLine();

            Stack<char> st = new Stack<char>();

            foreach (char ch in input1)
            {
                st.Push(ch);
            }

            while (st.Count > 0)
            {
                Console.Write(st.Peek());
                st.Pop();
            }

            #endregion




            #region Reverse Words
            /*
            string[] input2 = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>();

            foreach (string word in input2)
            {
                stack.Push(word);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Peek() + " ");
                stack.Pop();
            }
            */
            #endregion
        }
    }
}
