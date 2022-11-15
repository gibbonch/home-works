using System;

namespace FurtherLess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input n >> ");

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write((n - Math.Abs(i - j)) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}