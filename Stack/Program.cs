﻿internal class Program
{
    private static void Main(string[] args)
    {
        var stack = new Stack.Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
    }
}