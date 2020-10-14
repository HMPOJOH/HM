using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Enums
{
    public class Demo2
    {
        // Plastic" || answer == "Wood" || answer == "Metal" || answer == "Glass")

        enum CoffeMachineMaterial
        {
            Plastic, Wood, Metal, Glass
        }

        enum CoffeMachineColor
        {
            White, Black, Red
        }
        // Exercise: create a enum for Color  (White, Black, Red)            9:56 <--------------

        class CoffeMachine
        {
            public DateTime Ordered { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public bool NeedMaintenance { get; set; }
            public CoffeMachineColor Color { get; set; }
            public CoffeMachineMaterial Material { get; set; }

        }

        public static void Run()
        {

            var x = new CoffeMachine
            {
                Ordered = new DateTime(2020, 10, 14),
                Price = 123,
                ProductName = "Sage the Barista",
                NeedMaintenance = false,
                Color = CoffeMachineColor.Red,
                Material = CoffeMachineMaterial.Plastic
            };

            if (x.Color == CoffeMachineColor.Red) 
            {
                Console.WriteLine("It's red!");
            }
            else
            {
                Console.WriteLine("It's not red!");
            }

            Console.Write("Change material: ");
            var answer = Console.ReadLine();

            // -------------> 10:08

            // Exercise: fix this 
            // Hint: "Enum.TryParse"

            // bool result = Enum.TryParse(answer, out CoffeMachineMaterial material);

            if (Enum.TryParse(answer, out CoffeMachineMaterial material))
            {
                x.Material = material;
            }
            else
            {
                Console.WriteLine("Invalid material!");
            }

            Console.WriteLine($"The machine is made of {x.Material}");

        }




    }
}
