using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCourse.Methods
{
    class Demo1
    {
        public static void Run()
        {
            Console.WriteLine("When do you start in the morning?");
            string startString = Console.ReadLine();
            var start = TimeSpan.Parse(startString);

            Console.WriteLine($"Minutes: {start.Minutes}");
        }
    }
}
