using System;

namespace CSharpCourse.Property
{
    public class Demo2
    {
        class Phone
        {
            public decimal Price { get; set; }

            public decimal GetVAT()
            {
                return Price * 0.25M;
                // Exercise: create this method (always 25%)
            }

            public decimal GetTotalPrice()
            {
                return Price + GetVAT();
                //return Price * 1.25M;
            }
        }

        public static void Run()
        {
            // (8:58)
            var telefon = new Phone();
            telefon.Price = 1000;
            Console.WriteLine($"The VAT for the phone is {telefon.GetVAT()}kr");
            Console.WriteLine($"Total price for the phone is {telefon.GetTotalPrice()}kr");
        }
    }
}
