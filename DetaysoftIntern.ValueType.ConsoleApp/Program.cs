using System;

namespace DetaysoftIntern.Types.ValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a;
            b++;

            Console.WriteLine(string.Format("a:{0} b:{1}", a, b));
        }
    }
}
