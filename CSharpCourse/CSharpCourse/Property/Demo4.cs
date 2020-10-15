using System;

namespace CSharpCourse.Property
{
    public class Demo4
    {
        class Phone
        {

            public decimal Price { get; set; }
            public decimal VAT => Price * 0.25M;       // Alt-Enter (use expression body for properties)
            public decimal TotalPrice => Price + VAT;

        }

        public static void Run()
        {
            // 9:26

            var telefon = new Phone();
            telefon.Price = 1000;
            Console.WriteLine($"The VAT for the phone is {telefon.VAT}kr");
            Console.WriteLine($"Total price for the phone is {telefon.TotalPrice}kr");
        }
    }
}
