using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCourse.Control
{
    class Demo3
    {
        public static void Run()
        {                     
            // var planets = new string[4];
            // planets[0] = "Mercury";
            // planets[1] = "Venus";
            // planets[2] = "Earth";
            // planets[3] = "Mars";
            
            var planets = new [] { "Mercury", "Venus", "Earth", "Mars"};

            // (Shift-Alt-Arrow)

            // foreach tab tab

            foreach (var item in planets)
            {
                Console.WriteLine(item);
            }

            var importantYears = new[] { 570, 1492, 1789, 1917 };

            for (int i = 0; i < importantYears.Length; i++)
            {
                Console.WriteLine(importantYears[i]);
            }

            foreach (var item in importantYears)
            {
                Console.WriteLine(item);
            }

            // for + tab + tab
            for (int i = 10; i <= 20; i++)
            {
                if (i == 15)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
