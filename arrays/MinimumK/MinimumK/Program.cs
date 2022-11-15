using System;

namespace MinimumK
{
    class Program
    {
        public static int[] Sort(int[] anArray)
        {
            for (int i = 1; i < anArray.Length; i++)
            {
                int x = anArray[i];
                int j = i;
                while ((j > 0) && (x < anArray[j - 1]))
                {
                    anArray[j] = anArray[j - 1];
                    j--;
                }
                anArray[j] = x;
            }
            return anArray;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sort(array)[k - 1]);
            Console.ReadKey();
        }
    }
}