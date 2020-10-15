using System;

namespace CSharpCourse.Property
{
    public class Demo5
    {
        class Tshirt
        {
            public decimal Price { get; set; }
            public decimal Discount { get; set; }
        }

        public static void Run()
        {
            var t = new Tshirt();
            t.Price = 400;
            t.Discount = 0.3M;

            // Exercise: create "priceWithDiscount"  

            var priceWithDicount = t.Price * (1 - t.Discount);

            Console.WriteLine($"Price of the tshirt with discount: {priceWithDicount}");

        }
    }
}
