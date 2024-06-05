using System;

namespace Day31Concepts.PartialClassExample
{
    partial class Product
    {
        public void PrintProductDetails()
        {
           int id = 10;
           string name = "Desktop";
           double  price = 56000;
           long  trackNumber = 664567;
           float  discount = 5;
           DateTime purchaseDate = DateTime.Now;

            Console.WriteLine($" Id = {id} \n Product Name = {name} \n Price = {price} \n Track number ={trackNumber}" +
                $" \n Discount {discount}% \n Date Of Join = {purchaseDate}");
        }
    }
    partial class Product
    {
        public void PrintDetails()
        {
            int id = 10;
            string name = "Laptop";
            double price = 67500;
            decimal discount = 5;
            long trackNumber = 664567;
            DateTime purchaseDate = new DateTime(2024,04,20);
            Console.WriteLine($" Id = {id} \n Product Name = {name} \n Price = {price} \n Discount {discount}% \n" +
                $"Track number ={trackNumber} \n Date Of Join = { purchaseDate}");
        }
    }
}
