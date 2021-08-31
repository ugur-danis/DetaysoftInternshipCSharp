using System;
using System.Collections.Generic;

namespace DetaysoftIntern.Collections.Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach (int item in queue)
                Console.WriteLine(item);
        }
    }
}
