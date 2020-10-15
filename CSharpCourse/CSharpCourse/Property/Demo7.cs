using System;

namespace CSharpCourse.Property
{
    public class Demo7
    {
        class Tshirt
        {

            public decimal Price { get; set; }

            private decimal _discount = 0;

            public decimal Discount
            {
                get
                {
                    return _discount;
                }
                set
                {
                    if (value >= 0 && value <= 1)
                    {
                        _discount = value;  
                    }
                }
            }

            public decimal PriceWithDiscount => Price * (1 - Discount);

        }
        
        // --------> Break until 10:13

        public static void Run()
        {
            var t = new Tshirt();
            t.Price = 400;
            t.Discount = 0.3M;
            t.Discount = 123456; // <----- Nothing will change
            Console.WriteLine($"Price of the tshirt with discount: {t.PriceWithDiscount}");
        }
    }
}
