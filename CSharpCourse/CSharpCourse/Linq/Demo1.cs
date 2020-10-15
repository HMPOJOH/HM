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

            Header("Without LINQ");

            var avg = Average(list); // Aggregation
            var sum = Sum(list);     // Aggregation
            var numbersHigherThanFive = NumbersHigherThanFive(list); // Filtering
            var starslist = StarifyList(list); // Manipulation  *3*  *10*  *7*

            Display("average", avg);
            Display("sum", sum);
            Display("numbersHigherThanFive", numbersHigherThanFive);
            Display("starslist", starslist);


            ExamplesWithLinq();
        }

        private static void ExamplesWithLinq()
        {
            Header("With LINQ");

            var list = new List<int> { 3, 10, 7 };
            var avg = list.Average();  // Aggregation
            var sum = list.Sum();      // Aggregation
            var numbersHigherThanFive = list.Where(x => x > 5); // Filter
            var numbersHigherThanFive2 = list.Where(Kalle); // Filter
            var starslist = list.Select(x => $"*{x}*");         // Manipulation

            Display("average", avg);
            Display("sum", sum);
            Display("numbersHigherThanFive", numbersHigherThanFive);
            Display("starslist", starslist);

        }

        private static bool Kalle(int x)
        {
            return x > 5;
        }

        private static List<string> StarifyList(List<int> list)
        {
            var result = new List<string>();

            foreach (var item in list)
            {
                result.Add($"*{item}*");
            }
            return result;
        }

        private static List<int> NumbersHigherThanFive(List<int> list)
        {
            var result = new List<int>();
            foreach (var item in list)
            {
                if (item > 5)
                {
                    result.Add(item);
                }
            }
            return result;
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

        private static void Display(string text, IEnumerable<int> list)
        {
            var listAsString = string.Join(",", list); // "3,10,7"

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{text} = {listAsString}");
        }

        private static void Display(string text, IEnumerable<string> list)
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
