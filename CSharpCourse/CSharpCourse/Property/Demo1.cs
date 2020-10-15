using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Property
{
    public class Demo1
    {
        class Phone
        {
            // prop + prop + tab

            public decimal Price { get; set; } // Ctrl-D (duplicate)
            public decimal VAT { get; set; } 
            public decimal TotalPrice { get; set; } // Ctrl-W (mark a word)
        }

        public static void Run()
        {
            // (8:48)

            // Create a phone with price 1000 and VAT 250 and total price 1250
            var telefon = new Phone();
            telefon.Price = 1000;
            telefon.VAT = 250;
            telefon.TotalPrice = 1250;

            // Write "Total price for the phone: 1250"
            Console.WriteLine($"Total price for the phone: {telefon.TotalPrice}");
        }
    }
}
