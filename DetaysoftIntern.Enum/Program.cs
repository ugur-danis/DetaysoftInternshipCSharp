using System;

namespace DetaysoftIntern.Types.Enum
{
    enum Departments { WEB = 0, MOBILE = 1, }

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine((Departments)i);
            }
        }
    }
}
