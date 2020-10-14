using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Collections
{
    public class Demo2
    {
        public static void Run()
        {
            /*
             
            Bookstore 1:

                Pricecategory A costs 35kr
                Pricecategory B costs 45kr
                Pricecategory C costs 68kr
            
            Bookstore 2:

                Pricecategory A costs 35kr
                Pricecategory B costs 35kr
                Pricecategory C costs 77kr
             
            Bookstore 3:

                Pricecategory A costs 35kr
                Pricecategory A costs 45kr
                Pricecategory C costs 68kr

            string prislista = "A:35kr B:45kr C:68kr"  (not good)

             */

            //var prices = new Dictionary<char, int>();
            //prices.Add('A', 35);
            //prices.Add('B', 45);
            //prices.Add('C', 68);

            // Mini-exercise: write the above in a more compact way ---->10:36

            var prices = new Dictionary<char, int>
            {
                { 'A', 35 },
                { 'B', 45 },
                { 'C', 68 }
            };

            int hint1 = prices['A'];

            // Mini-exercise: print all price categories (three lines of console.writeline)
            // ------> 10:39

            Console.WriteLine($"The books in price category A costs {prices['A']}kr");
            Console.WriteLine($"The books in price category B costs {prices['B']}kr");
            Console.WriteLine($"The books in price category C costs {prices['C']}kr");

            // Exercise: do the same but loop over the dictionary -----> 10:45

            // foreach tab tab

            foreach (var item in prices)
            {
                Console.WriteLine($"The books in price category {item.Key} costs {item.Value}kr");
            }

            foreach (KeyValuePair<char, int> item in prices)
            {
                Console.WriteLine($"The books in price category {item.Key} costs {item.Value}kr");
            }

            // Exercice: check (and write) if price category B and/or D exist  ----> 10:50

            // Hint: "prices.SomeThing"

            if (prices.ContainsKey('B'))
            {
                Console.WriteLine("Price category B exist");
            }

            if (!prices.ContainsKey('D'))
            {
                Console.WriteLine("Price category D doesn't exist");
            }

            /* 
                 Exercise: ---> 10:55

                 Add a new price category D (with price 150kr)
                 Remove price category B
                 Change price of pricecategory A
             */

            prices.Add('D', 150);
            prices.Remove('B');
            prices['A'] = 20;

            Console.WriteLine($"Price category A now costs {prices['A']}kr");

        }
    }
}
