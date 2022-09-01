using System; 

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            Console.WriteLine("Hello, what's your name?");

            Console.ReadLine();

            Console.WriteLine("My name is RX-9000.\n I'm an AI sent from the future to help you.");
            Console.WriteLine("What is your favorite color?");

            Console.ReadLine();

            Console.WriteLine("That is nice. My favorite color is White and Blue.");

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}