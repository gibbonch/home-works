using System;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //min magic number is 3210 

            //max magic number is 9876

            for (int a1 = 3; a1 <= 9; a1++)
            {
                for (int a2 = 2; a2 < a1; a2++)
                {
                    for (int a3 = 1; a3 < a2; a3++)
                    {
                        for (int a4 = 0; a4 < a3; a4++)
                        {
                            Console.WriteLine(a1 * 1000 + a2 * 100 + a3 * 10 + a4);
                        }
                    }
                }
            }
        }
    }
}