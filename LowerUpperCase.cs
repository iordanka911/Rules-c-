using System;

namespace LowerOrUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = "Hello, C#";

            Console.WriteLine(b.IndexOf("c#",StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
