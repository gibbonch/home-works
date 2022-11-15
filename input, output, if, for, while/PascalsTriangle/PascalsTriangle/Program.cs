using System;

namespace PascalsTriangle
{
    class Program
    {
        public static void PrintArray(int[] anArray)
        {
            for (int i = 0; i < anArray.Length; i++)
            {
                Console.Write(anArray[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("input n >> ");

            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = { 1 };

            int[] array_temp;

            if (n == 1)
            {
                PrintArray(array);
            }
            else
            {
                PrintArray(array);

                for (int i = 1; i < n; i++)
                {
                    array_temp = array;

                    array = new int[i + 1];

                    array[0] = 1;

                    array[i] = 1;

                    for (int j = 1; j < i; j++)
                    {
                        array[j] = array_temp[j] + array_temp[j - 1];
                    }
                    PrintArray(array);
                }
                
            }
            Console.ReadKey();
        }
    }
}