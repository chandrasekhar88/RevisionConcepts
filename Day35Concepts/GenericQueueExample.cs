using System;
using System.Collections.Generic;

namespace Day35Concepts
{
    public class GenericQueueExample
    {
        public void QueueMethodsExample()
        {
            var queue = new Queue<string>();
            queue.Enqueue("Task1");
            queue.Enqueue("Task2");
            queue.Enqueue("Task3");

            var task = queue.Dequeue(); // Dequeue method is used to remove first added item  first
            Console.WriteLine(task);

            var taskPeeked = queue.Peek(); // Peek method is used to get the first item 
            Console.WriteLine(taskPeeked);

            queue.Clear();

            Console.ReadLine();
        }

        public void MovieTicketBookingExample()
        {
            MovieTicketBookingSystem bookingSystem = new MovieTicketBookingSystem();

            bookingSystem.AddQueue(new Customer { name = "John", age = 20 });
            bookingSystem.AddQueue(new Customer { name = "Martin", age = 9 });
            bookingSystem.AddQueue(new Customer { name = "Sam", age = 25 });

            Console.ReadKey();
            bookingSystem.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("\nBooking process started");
            bookingSystem.ProcessBooking();
            bookingSystem.ProcessBooking();

            Console.ReadKey();
            bookingSystem.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("Add more customers to the Queue");
            bookingSystem.AddQueue(new Customer { name = "Julie", age = 16 });
            bookingSystem.AddQueue(new Customer { name = "Christin", age = 8 });

            Console.ReadKey();
            bookingSystem.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("\nBooking process started");
            bookingSystem.ProcessBooking();
            bookingSystem.ProcessBooking();

            Console.ReadKey();
            bookingSystem.ShowQueue();

            Console.ReadLine();
        }
    }
}
