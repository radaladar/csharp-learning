using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            helloWorld();
            randomNumber();
        }

        static void helloWorld()
        {
            Console.WriteLine("What is your name?");
            Console.Write("> ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
        }

        static void randomNumber()
        {
            Random random = new Random();
            Console.WriteLine("Random Number between 1 and 10: " + (random.Next(1,11)));
        }
    }
}