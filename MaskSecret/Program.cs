using System;

namespace MaskSecret
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your secret?");
            var secret = Console.ReadLine();
            var result = secret.Substring(secret.Length - 4).PadLeft(secret.Length, '*');
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
