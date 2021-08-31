using System;

namespace DetaysoftIntern.Arrays.SingleDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            // int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
                Console.Write(numbers[i] + (i == numbers.Length - 1 ? "" : ", "));
            }
        }
    }
}
