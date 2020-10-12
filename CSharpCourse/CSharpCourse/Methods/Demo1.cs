using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCourse.Methods
{
    class Demo1
    {
        public static void Run()
        {
            Console.Write("When do you start in the morning? ");
            string startString = Console.ReadLine();
            var start = TimeSpan.Parse(startString);

            Console.Write("When do you go for lunch? ");
            string lunchString = Console.ReadLine();
            TimeSpan lunch = TimeSpan.Parse(lunchString);

            Console.Write("When does your lunch end? ");
            string lunchEndString = Console.ReadLine();
            TimeSpan lunchEnd = TimeSpan.Parse(lunchEndString);

            Console.Write("When do you go home from work? ");
            string endString = Console.ReadLine();
            TimeSpan end = TimeSpan.Parse(endString);

            Console.WriteLine();
            
            TimeSpan worktime = lunch - start + end - lunchEnd;

            // 6h 20min

            // Hours: 6
            // TotalHours: 6.33h

            Console.WriteLine($"You have worked {worktime.Hours}h and {worktime.Minutes} minutes");
            Console.WriteLine($"Total hours: {worktime.TotalHours}");
        }
    }
}
