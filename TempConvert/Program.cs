using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double output;

            Console.Write("Temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Unit (C/F): ");
            string unit = Console.ReadLine();
        }
    }
}
