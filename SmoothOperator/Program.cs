using System;
using System.Runtime.InteropServices;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro: ");
            sbyte n = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine(--n);
            Console.WriteLine(++n);
        }
    }
}
