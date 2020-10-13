using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Methods
{
    public class Demo2
    {

        public static void Run()
        {
            // Alt-Enter => extract method

            TimeSpan start = AskForTime("When do you start in the morning?");
            TimeSpan lunch = AskForTime("When do you go for lunch?");
            TimeSpan lunchEnd = AskForTime("When does your lunch end?");
            TimeSpan end = AskForTime("When do you go home from work?");

            ReportWorkingHours(start, lunch, lunchEnd, end);

        }

        private static void ReportWorkingHours(TimeSpan start, TimeSpan lunch, TimeSpan lunchEnd, TimeSpan end)
        {
            var workTime = lunch - start + end - lunchEnd;
            Console.WriteLine($"You have worked {workTime.Hours}h and {workTime.Minutes} minutes");
        }

        private static TimeSpan AskForTime(string question)
        {
            Console.Write(question + " ");
            var answer = Console.ReadLine();
            var time = TimeSpan.Parse(answer);
            return time;
        }


    }
}
