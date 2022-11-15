using System;

namespace ShortUnpacking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input pack >> ");
            ulong pack = Convert.ToUInt64(Console.ReadLine());

            ulong x1 = pack & 65535;
            ulong x2 = (pack >> 16) & 65535;
            ulong x3 = (pack >> 32) & 65535;
            ulong x4 = (pack >> 48) & 65535;

            Console.WriteLine("x1 -> " + x1);
            Console.WriteLine("x2 -> " + x2);
            Console.WriteLine("x3 -> " + x3);
            Console.WriteLine("x4 -> " + x4);

            Console.ReadKey();
        }
    }
}