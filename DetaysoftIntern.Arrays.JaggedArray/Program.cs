using System;

namespace DetaysoftIntern.Arrays.JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine("jaggedArray[{0},{1}]: {2}]", i, j, jaggedArray[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
