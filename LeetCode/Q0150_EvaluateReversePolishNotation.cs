public static class Q0150
{
    public static int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        foreach (var token in tokens)
        {
            if (Int32.TryParse(token, out int value))
            {
                stack.Push(value);
            }
            else
            {
                int x = stack.Pop();
                int y = stack.Pop();
                switch (token)
                {
                    case "+": stack.Push(y + x); break;
                    case "-": stack.Push(y - x); break;
                    case "*": stack.Push(y * x); break;
                    case "/": stack.Push(y / x); break;
                }
            }
        }
        return stack.Pop();
    }
}