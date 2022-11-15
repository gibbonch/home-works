using System;

namespace ShortPacking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input x1 >> ");
            ulong x1 = Convert.ToUInt64(Console.ReadLine());

            Console.Write("input x2 >> ");
            ulong x2 = Convert.ToUInt64(Console.ReadLine());

            Console.Write("input x3 >> ");
            ulong x3 = Convert.ToUInt64(Console.ReadLine());

            Console.Write("input x4 >> ");
            ulong x4 = Convert.ToUInt64(Console.ReadLine());

            ulong pack;
            pack = x4 << 48 | x3 << 32 | x2 << 16 | x1;
            Console.WriteLine("pack: " + pack);
            Console.ReadKey();
        }
    }
}