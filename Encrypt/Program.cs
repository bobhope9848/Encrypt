using System;

namespace Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation result = new Calculation();
            Console.WriteLine("\r\nPlease enter your message");
            result.Input = Console.ReadLine();
            Console.WriteLine("\n\rPlease enter you passphrase key (text)");
            result.Key = Console.ReadLine();
            Console.WriteLine($"\n\rEncrypted message: {result.calculate()}");
            Console.WriteLine("\n\rPress any key to continue");
            Console.ReadKey();
        }
    }
}
