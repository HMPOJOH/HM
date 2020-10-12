using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCourse.Fundamentals
{
    // Break until 10:38!

    // Ctrl K D ==> format document
    class Demo3
    {
        public static void Run()
        { // F9 for breakpoint
            Console.Write("Enter your weight in kilo: ");

            //string answer = Console.ReadLine();
            var answer = Console.ReadLine();

            //decimal kilo = decimal.Parse(answer);
            var kilo = decimal.Parse(answer);

            // The same:     decimal kilo = decimal.Parse(Console.ReadLine());

            if (kilo < 0)
                Console.WriteLine("You can't have negative weight");
            else if (kilo > 100)
                Console.WriteLine("You weigh more than 100");
            else
                Console.WriteLine("You weigh less than 100");

        }
    }
}
