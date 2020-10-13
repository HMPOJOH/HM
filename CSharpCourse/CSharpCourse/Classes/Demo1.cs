using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Classes
{
    public class Demo1
    {
        class Car
        {
            private string _color;

            public void SetColor(string v)
            {
                _color = v;
            }

            public string GetColor()
            {
                return _color;
            }
        }

        public static void Run()
        {
            // Ctrl K C for comment

            var c1 = new Car();
            var c2 = new Car();
            var c3 = new Car();

            c1.SetColor("blue");
            c2.SetColor("red");
            
            Console.WriteLine($"The color of car1 is {c1.GetColor()}");
            Console.WriteLine($"The color of car2 is {c2.GetColor()}");
            Console.WriteLine($"The color of car3 is {c3.GetColor()}");

        }

    }
}
