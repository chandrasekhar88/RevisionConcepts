using System;

namespace Day31Concepts.ClassExample
{
    public class Customer
    {
        int id;
        string firstName;
        string lastName;
        double price;
        float discount;
        decimal trackNumber;
        DateTime date;        

        public Customer(int id, string firstName, string lastName, double price, float discount,
            decimal trackNumber, DateTime date)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.price = price;
            this.discount = discount;
            this.trackNumber = trackNumber;
            this.date = date;
        }

        public void PrintFullDetails()
        {
            Console.WriteLine($"Id = {this.id} \n Full Name = {this.firstName} {this.lastName} \n" +
                $"Price = {this.price} \n Discount = {this.discount} \n TrackNumber = {this.trackNumber}" +
                $"Date = {this.date}");
        }
    }
}
