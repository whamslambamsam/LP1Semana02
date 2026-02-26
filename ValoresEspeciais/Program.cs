using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Double: ");
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            Console.WriteLine("");

            Console.WriteLine("SByte: ");
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);

            Console.WriteLine("");

            Console.WriteLine("Byte: ");
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);

            Console.WriteLine("");

            Console.WriteLine("ULong: ");
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);

            Console.WriteLine("");

            Console.WriteLine("Float: ");
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine("");

            Console.WriteLine("Integer: ");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
        }
    }
}
