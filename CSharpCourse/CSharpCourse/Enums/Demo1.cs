using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Enums
{
    public class Demo1
    {

        class CoffeMachine
        {
            // prop tab tab 

            public DateTime Ordered { get; set; }
            public string ProductName { get; set; }

            // Exercise: add some more properties... (9.18)
            public decimal Price { get; set; }
            public bool NeedMaintenance { get; set; }
            public string Color { get; set; }
            public string Material { get; set; }

        }

        public static void Run()
        {
            //var x = new CoffeMachine();
            //x.Ordered = new DateTime(2020, 10, 14);
            //x.ProductName = "Sage the Barista";
            //x.NeedMaintenance = false;

            // Alt-Enter = magic stuff will happen
            var x = new CoffeMachine
            {
                Ordered = new DateTime(2020, 10, 14),
                Price = 123,
                ProductName = "Sage the Barista",
                NeedMaintenance = false,
                Color = "Red",
                Material = "Plastic"
            };

            if (x.Color == "Red")
            {
                Console.WriteLine("It's red!");
            }
            else
            {
                Console.WriteLine("It's not red!");
            }

            Console.Write("Change material: ");
            var answer = Console.ReadLine();

            if (IsValidMaterial(answer))
            {
                x.Material = answer;
            }
            else
            {
                Console.WriteLine("Invalid material!");
            }

            Console.WriteLine($"The machine is made of {x.Material}");

        }

        private static bool IsValidMaterial(string answer)
        {
            // Exercise: create this method

            // ---------> 9:32

            // Plastic, Wood, Metal, Glass

            throw new NotImplementedException();
        }
    }
}
