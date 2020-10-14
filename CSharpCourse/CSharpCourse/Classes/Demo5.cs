using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Classes
{
    public class Demo5
    {
        // (F2 to rename a file)

        class Car
        {
            public string Color { get; }
            public int Weight { get; }

            public Car()
            {
                Color = "pink";
                Weight = 999;
            }

            public Car(string c, int w)
            {
                Color = c;
                Weight = w;
            }

            public static void Run()
            {
                var c1 = new Car("blue", 1200);
                var c2 = new Car("red", 800);
                var c3 = new Car(); 

                // Mini-exercise: I don't want to allow these properties to be set:
                //c2.Color = "yellow";
                //c2.Weight = 600;

                Console.WriteLine($"The color of car1 is {c1.Color} and the weight is {c1.Weight}");
                Console.WriteLine($"The color of car2 is {c2.Color} and the weight is {c2.Weight}");
                Console.WriteLine($"The color of car3 is {c3.Color} and the weight is {c3.Weight}");
            }

        }
    }
}
