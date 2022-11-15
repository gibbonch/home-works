using System;

namespace Summation
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
            string n_convert = ConvertToBinary(n);

            Console.Write("input m >> ");

            int m = Convert.ToInt32(Console.ReadLine());
            string m_convert = ConvertToBinary(m);

            string sum_convert = ConvertToBinary(n + m);

            int k1 = sum_convert.Length - n_convert.Length;
            int k2 = sum_convert.Length - m_convert.Length;

            for (int i = 0; i < k1; i++)
            {
                n_convert = "0" + n_convert;
            }

            for (int i = 0; i < k2; i++)
            {
                m_convert = "0" + m_convert;
            }

            Console.WriteLine(n_convert);
            Console.WriteLine(m_convert);
            Console.WriteLine(ConvertToBinary(n + m));
            Console.ReadKey();
        }
    }
}