using System;

namespace DetaysoftIntern.Arrays.MultidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2d = new int[4, 2];
            int[,,] array3d = new int[4, 2, 3];


            #region array2d
            Console.WriteLine("array2d");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    array2d[i, j] = j;
                    Console.WriteLine("array2d[{0},{1}]: {1}", i, j);
                }
                Console.WriteLine();
            }
            #endregion

            Console.WriteLine("array3d");
            #region array2d
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        array3d[i, j, k] = k;
                        Console.WriteLine("array3d[{0},{1},{2}]: {2}", i, j, k);
                    }
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
