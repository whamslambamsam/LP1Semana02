using System;
using System.Runtime.Intrinsics.X86;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insira altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            Console.WriteLine(Math.Round(volume, 3));

            double areaSuperficie = 2 * Math.PI * raio * (raio + altura);
            Console.WriteLine(Math.Round(areaSuperficie, 3));
        }
    }
}
