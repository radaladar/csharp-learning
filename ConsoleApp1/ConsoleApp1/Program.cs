using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            helloWorld();
        }

        static void helloWorld()
        {
            Console.WriteLine("What is your name?");
            Console.Write("> ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
        }
    }
}