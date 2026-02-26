using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Unit (C/F): ");
            string unit = Console.ReadLine();
            
            switch (unit)
            {
                case "F":
                    Console.WriteLine(temp + " F = " + Math.Round((temp - 32) / 1.8, 3) + " C");
                    break;

                case "f":
                    Console.WriteLine(temp + " F = " + Math.Round((temp - 32) / 1.8, 3) + " C");
                    break;

                case "C":
                    Console.WriteLine(temp + " C = " + Math.Round(temp * 1.8 + 32, 3) + " F");
                    break;

                case "c":
                    Console.WriteLine(temp + " C = " + Math.Round(temp * 1.8 + 32, 3) + " F");
                    break;
            }
        }
    }
}
