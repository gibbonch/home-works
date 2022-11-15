using System;

namespace Vector
{
    class Program
    {
        public static double SquareSummation(double[] anArray, double someP)
        {
            double x = 0;
            foreach(double i in anArray)
            {
                x += Math.Pow(i, someP);
            }
            return x;
        }
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            int n = int.Parse(nums[0]);
            double p = double.Parse(nums[1]);

            double[] array = Console.ReadLine().Split(' ').Select(s => double.Parse(s)).ToArray();

            double p_norm = Math.Pow(SquareSummation(array, p), 1 / p);

            Console.WriteLine(p_norm);
            Console.ReadKey();
        }
    }
}