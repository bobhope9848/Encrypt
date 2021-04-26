using System;

namespace Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string");
            Calculation result = new Calculation()
            {
                Input = Console.ReadLine(),
            };
            result.calculate();
            Console.ReadLine();
        }
    }
}
