using System;
using System.Collections.Generic;

namespace DetaysoftIntern.Collections.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            foreach (int item in stack)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
