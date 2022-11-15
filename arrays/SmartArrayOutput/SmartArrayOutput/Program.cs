using System;

namespace SmartArrayOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input n >> ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("input array >> ");
            int[] array = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            Console.Write("input [begin:end:step] >> ");
            int[] borders = Console.ReadLine().Split(':').Select(s => int.Parse(s)).ToArray();

            int begin = borders[0];
            int end = borders[1];
            int step = borders[2];

            if (step > 0)
            {
                for (int i = begin; i <= end; i += step)
                {
                    Console.Write(array[i] + " ");
                }
            }
            else
            {
                for (int i = end; i >= begin; i += step)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}