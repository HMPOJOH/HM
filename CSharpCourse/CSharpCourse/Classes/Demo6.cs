using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Classes
{
    public class Demo6
    {
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

                if (c == null)
                {
                    throw new ArgumentNullException("The color can't be null");
                }

                // Exercise: Verify "c" (at least one character)

                if (c.Length == 0)
                {
                    throw new ArgumentException("The color must have one character");
                }

                // Exercise: Verify "w" ( a positive number)

                if (w < 0)
                {
                    throw new ArgumentException("The weight can't be negative");
                }

                // F10: step over
                // F11: step into
                // F5: continue

                Color = c;
                Weight = w;
            }
        }
        // 9:05 <------
        public static void Run()
        {
            try
            {
                var c1 = new Car("blue", 1200);
                var c2 = new Car("red", 800);
                var c3 = new Car();

                var c4 = new Car(null, 500);

                Console.WriteLine($"The color of car1 is {c1.Color} and the weight is {c1.Weight}");
                Console.WriteLine($"The color of car2 is {c2.Color} and the weight is {c2.Weight}");
                Console.WriteLine($"The color of car3 is {c3.Color} and the weight is {c3.Weight}");
            }
            catch (ArgumentNullException ex) 
            {
                Console.WriteLine($"Oops, something went wrong. {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Doh! {ex.Message}");
            }

        }
    }
}
