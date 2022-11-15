using System;

namespace Replacement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input n >> ");

            ulong n = Convert.ToUInt64(Console.ReadLine());

            Console.Write("input m >> ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("input k >> ");
            int k = Convert.ToInt32(Console.ReadLine());

            ulong[] array = new ulong[8];
            ulong new_n = 0;

            for (int i = 0; i < 8; i++)
            {
                array[i] = (n >> i * 8) & 255;
            }

            for (int i = 7; i >= 0; i--)
            {
                if (i == k - 1)
                {
                    new_n = (new_n << 8) | array[m - 1];

                }
                else
                {
                    if (i == m - 1)
                    {
                        new_n = (new_n << 8) | array[k - 1];
                    }
                    else
                    {
                        new_n = (new_n << 8) | array[i];
                    }
                }
            }

            Console.WriteLine(new_n);
            Console.ReadKey();
        }
    }

}