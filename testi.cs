using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei. Mikä on nimesi?");
            var nimi = Console.ReadLine();
            Console.WriteLine($"Hei {nimi}");
        }
    }
}
