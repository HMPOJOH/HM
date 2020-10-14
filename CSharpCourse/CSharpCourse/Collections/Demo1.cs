using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Collections
{
    public class Demo1
    {
        public static void Run()
        {
            //var fishes = new List<string>();
            //fishes.Add("Makrill");
            //fishes.Add("Torsk");
            //fishes.Add("Sill");
            //fishes.Add("Lax");

            var fishes = new List<string>
            {
                "Makrill",
                "Torsk",
                "Sill",
                "Lax"
            };

            int nrOfFishes = fishes.Count; // 4
            string firstFish = fishes[0]; // "Makrill"
            string thirdFish = fishes[2]; // "Sill"

            fishes.Remove("Sill");
            nrOfFishes = fishes.Count; // 3

            fishes.Add("Sej");
            nrOfFishes = fishes.Count; // 4

            var importantYears = new List<int> { 570, 1492, 1789 };
            importantYears.Add(1917);
            int count1 = importantYears.Count; // 4

            var importantYears_array = new int[] { 570, 1492, 1789 };
            int count2 = importantYears_array.Length; // 3
            // importantYears_array.Add(1917); // not possible :(

            // HashSet

            var importantYears_hash = new HashSet<int> { 570, 1492, 1789 };
            importantYears_hash.Add(1111);
            bool found = importantYears_hash.Contains(1789);


        }
    }
}
