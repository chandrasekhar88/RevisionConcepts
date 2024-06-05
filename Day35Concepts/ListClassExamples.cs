using System;
using System.Collections.Generic;

namespace Day35Concepts
{
    public class ListClassExamples
    {
        public void GetCustomers()
        {
            Customer customer1 = new Customer()
            {
                id = 1,
                name = "Ram",
                salary = 60000
            };

            Customer customer2 = new Customer()
            {
                id = 2,
                name = "Ramesh",
                salary = 50000
            };

            Customer customer3 = new Customer()
            {
                id = 3,
                name = "Kiran",
                salary = 40000
            };

            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            
            // To Print one Customer record
            Customer oneCustomer = customers[0];
            Console.WriteLine($"Id = {oneCustomer.id} , Name = {oneCustomer.name}, Salary = {oneCustomer.salary}");

            foreach (var customer in customers)
            {
                Console.WriteLine($"Id = {customer.id} , Name = {customer.name}, Salary = {customer.salary}");
            }
        }
    }
}
