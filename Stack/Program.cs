internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var stack = new Stack.Stack();
            stack.Push(0);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}