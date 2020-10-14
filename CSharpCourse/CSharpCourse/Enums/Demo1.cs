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
            bool valid = false;
            if (answer == "Plastic")
                valid = true;
            if (answer == "Wood")
                valid = true;
            if (answer == "Metal")
                valid = true;
            if (answer == "Glass")
                valid = true;

            return valid;
        }

        private static bool IsValidMaterial2(string answer)
        {
            bool valid = false;
            if (answer == "Plastic" || answer == "Wood" || answer == "Metal" || answer == "Glass")
                valid = true;

            return valid;
        }

        private static bool IsValidMaterial3(string answer)
        {
            if (answer == "Plastic" || answer == "Wood" || answer == "Metal" || answer == "Glass")
                return true;

            return false;
        }

        private static bool IsValidMaterial4(string answer)
        {
            return answer == "Plastic" || answer == "Wood" || answer == "Metal" || answer == "Glass";
        }

        private static bool IsValidMaterial5(string answer) 
            
            => answer == "Plastic" || answer == "Wood" || answer == "Metal" || answer == "Glass";


        private static bool IsValidMaterial6(string answer)

            => new [] { "Plastic", "Wood", "Metal", "Glass" }.Contains(answer);


    }
}
