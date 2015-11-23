class Solution
{
    static void Main(string[] args)
    {
        string input = "45+445*+";

        Console.WriteLine(ProcessString(input));
    }

    static public int ProcessString(string input)
    {
        var stack = new Stack<int>();
        try
        {
            foreach(char c in input)
            {
                if (c == '+')
                {
                    stack.Push(stack.Pop() + stack.Pop());
                }
                else if (c == '*')
                {
                    stack.Push(stack.Pop() * stack.Pop());
                }
                else
                {
                    stack.Push((int)Char.GetNumericValue(c));
                }
            }
        }
        catch (Exception)
        {
            return -1;
        }

        return stack.Pop();
    }
}
