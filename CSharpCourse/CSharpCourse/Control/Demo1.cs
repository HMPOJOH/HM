using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCourse.Control
{
    class Demo1
    {
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("Enter your favorite color: ");
                var answer = Console.ReadLine();

                if (answer == "green" || answer == "blue" || answer == "red") // check for answer is red
                {
                    Console.WriteLine($"You like the color {answer}");
                    break;
                }

                Console.WriteLine("I don't know that color, try again");

            }

        }
    }
}
