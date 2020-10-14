using MyProject.Core;
using System;

namespace MyProject.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my calculator!");

            var calculator = new Calculator();

            while(true)
            {

                Console.Write("Enter a number: ");
                var number = Console.ReadLine();

                
                Console.Write("Enter a command: ");
                var command = Console.ReadLine();

                switch (command)
                {
                    case "+": 
                        calculator.Add(number);
                        break;

                    default:
                        Console.WriteLine("Sorry don't know the command");
                        continue;
                }

                Console.WriteLine($"Value: {calculator.GetValue()}");

            }
        }
    }
}
