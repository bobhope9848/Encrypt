using System;

namespace Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Encrypt");
            Console.WriteLine("2) Decrypt");
            Console.WriteLine("\r\nSelect:");
            switch (Console.ReadLine())
            {
                case "1":
                    Calculation EncryptResult = new Calculation();
                    Console.WriteLine("\r\nPlease enter your message");
                    EncryptResult.Input = Console.ReadLine();
                    Console.WriteLine("\n\rPlease enter you passphrase key (text)");
                    EncryptResult.Key = Console.ReadLine();
                    Console.WriteLine($"\n\rEncrypted message: {EncryptResult.calculate()}");
                    
                    break;
                case "2":
                    Calculation DecryptResult = new Calculation();
                    Console.WriteLine("\r\nPlease enter your encrypted message");
                    DecryptResult.Input = Console.ReadLine();
                    Console.WriteLine("\n\rPlease enter you passphrase key (text)");
                    DecryptResult.Key = Console.ReadLine();
                    Console.WriteLine($"\n\rDecrypted message: {DecryptResult.decrypt()}");
                    break;
                default:
                    Console.WriteLine("No acceptable answer");
                    Console.WriteLine("Breaking.....");
                    break;
            }
            Console.WriteLine("\n\rPress any key to continue");
            Console.ReadKey();
        }
    }
}
