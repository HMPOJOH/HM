using System;

namespace CSharpCourse.Property
{
    public class Demo6
    {
        class Tshirt
        {
            private decimal _discount = 0;


            public void SetDiscount(decimal d)
            {
                if (d >= 0 && d <= 1)
                {
                    _discount = d;
                }
            }

            public decimal GetDiscount()
            {
                return _discount;
            }

            public decimal Price { get; set; }
        }
        
        // (Until 9:41)

        public static void Run()
        {
            var t = new Tshirt();
            t.Price = 400;
            t.SetDiscount(0.3M);

            // Exercise: create "priceWithDiscount"  

            var priceWithDicount = t.Price * (1 - t.GetDiscount());

            Console.WriteLine($"Price of the tshirt with discount: {priceWithDicount}");

        }
    }
}
