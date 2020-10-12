using System;

// (Alt-Enter to remove usings)

namespace CSharpCourse.Fundamentals
{
    class Demo1
    {
        public static void Run()
        {
            // Ctrl-tab (switch between recent windows)

            Console.Write("Enter you weight in kilo: ");

            // cw tab tab   (called a "snippet")

            string answer = Console.ReadLine();

            // Small exercise:
            // Write: "You weigh 123kg"

            Console.WriteLine("You weigh " + answer + " kg");
        }
    }
}
