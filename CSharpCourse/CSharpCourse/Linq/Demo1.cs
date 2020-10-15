using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Linq
{
    public class Demo1
    {
        public static void Run()
        {
            /*
             Doing stuff with collections (e.g lists, arrays, IEnumerable's)

             - Filter a collection 
             - Manipulate a collection
             - Aggregation (e.g sum all element, or take average)
             
             Nice syntax

             Can chain operations (e.g both filter and manipulate)

             */

            var list = new List<int> { 3, 10, 7 };

            Header("The list");
            Display("list", list);

            Header("Without linq");

            var avg = Average(list); // Aggregation
            var sum = Sum(list);     // Aggregation
            var numbersHigherThanFive = NumbersHigherThanFive(list); // Filtering

            // 10:47

            Display("average", avg);
            Display("sum", sum);
            Display("numbersHigherThanFive", numbersHigherThanFive);
        }



        private static double Average(List<int> list)
        {
            //double sum = 0;
            //foreach(var i in list)
            //{
            //    sum += i;
            //}
            return Sum(list) / list.Count;
        }

        private static double Sum(List<int> list)
        {
            double sum = 0;
            foreach (var i in list)
            {
                sum += i;
            }
            return sum;
        }

        private static void Display(string text, double value)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{text} = {value}");
        }

        private static void Display(string text, List<int> list)
        {
            var listAsString = string.Join(",", list); // "3,10,7"

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{text} = {listAsString}");
        }

        private static void Header(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(message.ToUpper());
            Console.WriteLine();
        }
    }
}
