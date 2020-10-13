// Added validation so you can't enter to early times
using System;

namespace CSharpCourse.Methods
{
    public class Demo3
    {
        // until ---------> 10:10
        public static void Run()
        {
            TimeSpan start = AskForTime("When do start to work in the morning?", TimeSpan.Zero);
            TimeSpan lunch = AskForTime("When do you go for lunch?", start);
            TimeSpan lunchEnd = AskForTime("When does your lunch end?", lunch);
            TimeSpan end = AskForTime("When do you go home from work?", lunchEnd);

            TimeSpan worktime = CalculateWorkTime(start, lunch, lunchEnd, end);

            Console.WriteLine();
            Console.WriteLine($"You have worked {worktime.Hours}h and {worktime.Minutes} minutes");

        }

        private static TimeSpan CalculateWorkTime(TimeSpan start, TimeSpan lunch, TimeSpan lunchEnd, TimeSpan end)
        {
            return lunch - start + end - lunchEnd;
        }

        private static TimeSpan AskForTime(string question, TimeSpan mustBeLaterThan)
        {
            while(true)
            {
                Console.Write(question + " ");
                var answer = Console.ReadLine();

                // (Alt-Enter for inline declaration) 
                bool correctFormat = TimeSpan.TryParse(answer, out TimeSpan time);

                if (correctFormat && time.Days == 0 &&  time > mustBeLaterThan)
                {
                    return time;
                }
            }
        }
    }
}

