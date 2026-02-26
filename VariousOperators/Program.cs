using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro-não negativo: ");
            byte n = Convert.ToByte(Console.ReadLine());
            bool isBigger = false;
            
            Console.WriteLine(n / 2);
            Console.WriteLine(n << 3);
            Console.WriteLine(n ^ 6);
            if (n > 10)
            {
                isBigger = true;
                Console.WriteLine(isBigger);
            }
            else
            {
                Console.WriteLine(isBigger);
            }
        }
    }
}
