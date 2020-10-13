// Less repetition
using System;

namespace CSharpCourse.Methods
{
    public class Demo5
    {
        // Until 10:33

        public static void Run()
        {
            double triangle1Height = GetPositiveNumber("Enter height of triangle1: ");
            double triangle1Width = GetPositiveNumber("Enter width of triangle1: ");

            double triangle2Height = GetPositiveNumber("Enter height of triangle2: ");
            double triangle2Width = GetPositiveNumber("Enter width of triangle2: ");

            double area1 = AreaOfTriangle(triangle1Height, triangle1Width);
            double area2 = AreaOfTriangle(triangle2Height, triangle2Width);

            ReportArea(1, area1);
            ReportArea(2, area2);

        }

        private static double GetPositiveNumber(string question)
        {
            while (true)
            {
                Console.Write(question);
                string answer = Console.ReadLine();
                double num;
                if (double.TryParse(answer, out num) && num > 0)
                    return num;
            }
        }

        private static double AreaOfTriangle(double triangleHeight, double triangleWidth)
        {
            return triangleHeight * triangleWidth / 2;
        }

        private static void ReportArea(int triangleNumber, double area)
        {
            Console.WriteLine($"Area of triangle {triangleNumber} is: {area}");
        }
    }
}
