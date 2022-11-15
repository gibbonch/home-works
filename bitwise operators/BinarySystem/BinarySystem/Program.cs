using System;

namespace BinarySystem
{
    class Program
    {
        public static string ConvertToBinary(int dec)
        {
            string convertion = "";
            if (dec == 0)
            {
                convertion = "0";
            }
            while (dec != 0)
            {
                convertion = (dec & 1) + convertion;
                dec >>= 1;
            }
            return convertion;
        }

        static void Main(string[] args)
        {
            Console.Write("input n >> ");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("binary n: " + ConvertToBinary(n));

            Console.ReadKey();
        } 
    }
}