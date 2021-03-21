using System;

namespace data_structure_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>(5);

            Console.WriteLine($"length {stack.Length}\n");

            stack.Push("1");
            Console.WriteLine($"top {stack.Top}");
            stack.Push("2");
            Console.WriteLine($"top {stack.Top}");
            stack.Push("3");
            Console.WriteLine($"top {stack.Top}");
            stack.Push("4");
            Console.WriteLine($"top {stack.Top}\n");
            stack.Pop();
            Console.WriteLine($"item removed");
            Console.WriteLine($"top {stack.Top}\n");
            stack.PrintElements();
            Console.WriteLine();
            stack.Pop();
            Console.WriteLine($"item removed");
            Console.WriteLine($"top {stack.Top}\n");
            stack.PrintElements();
        }
    }
}
