using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Classes
{
    public class Demo4
    {
        // class tab tab 

        class Car
        {
            // ctor tab tab => constructor

            // prop tab tab => property

            public string Color { get; set; }
            public int Weight { get; set; }

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
                var c3 = new Car(); // ska ge en bil med lila färg som väger 999kg 

                c2.Color = "yellow";
                c2.Weight = 600;

                Console.WriteLine($"The color of car1 is {c1.Color} and the weight is {c1.Weight}");
                Console.WriteLine($"The color of car2 is {c2.Color} and the weight is {c2.Weight}");
                Console.WriteLine($"The color of car3 is {c3.Color} and the weight is {c3.Weight}");
            }

        }
    }
}
