using System;

namespace CSharpCourse.Fundamentals
{
    class Demo2
    {
        public static void Run()
        {
            Console.Write("Enter you weight in kilo: ");

            string answer = Console.ReadLine();

            decimal ton = decimal.Parse(answer) / 1000;

            //string response = "You weigh " + ton + "tons"; // 70-s
            //string response = string.Format("You weigh {0} tons", ton); // 90's

            string response = $"You weigh {ton}tons"; // string interpolation 2000's

            Console.WriteLine(response);
        }

    }
}
