using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Day35Concepts
{
    
    public class MovieTicketBookingSystem
    {
        Queue<Customer> queue;

        public MovieTicketBookingSystem()
        {
            queue = new Queue<Customer>();
        }

        public void AddQueue(Customer customer)
        {
            queue.Enqueue(customer);
            Thread.Sleep(1000);
            Console.WriteLine($"Added to Queue: {customer.name}");
        }

        public void ProcessBooking()
        {
            if (queue.Any())
            {
                var customer = queue.Dequeue();
                Thread.Sleep(1000);
                Console.WriteLine($"Processed for Booking: {customer.name}");
            }
        }

        public void ShowQueue()
        {
            Console.WriteLine("\n\tCurrent Queue");
            Console.WriteLine("\t--------------");
            foreach (var customer in queue)
            {
                Thread.Sleep(500);
                Console.WriteLine("\t" + customer.name);
            }
        }
    }
}
