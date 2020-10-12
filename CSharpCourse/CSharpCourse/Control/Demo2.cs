using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCourse.Control
{
    class Demo2
    {
        // Until 11:03 :)

        public static void Run()
        {
            // The same as in "Demo1"

            var validAnswer = false;

            while(!validAnswer)
            {
                Console.WriteLine("Enter your favorite color: ");
                string answer = Console.ReadLine();

                if (answer == "green" || answer == "blue" || answer == "red")
                {
                    Console.WriteLine($"You like the color {answer}");
                    validAnswer = true;
                }
                else 
                { 
                    Console.WriteLine("I don't know that color, try again");
                }

            }
        }
    }
}
