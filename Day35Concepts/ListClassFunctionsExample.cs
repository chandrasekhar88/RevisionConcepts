using System;
using System.Collections.Generic;

namespace Day35Concepts
{
    public class ListClassFunctionsExample
    {
        public void InsertMethod()
        {
            List<Customer> customers = CustomerDetails.GetCustomers();

            Customer customer3 = new Customer() { id = 103, name = "John", salary = 3500 };
            customers.Insert(1, customer3); // Insert method used to set the object in specific location            
            Console.WriteLine(customers.IndexOf(customer3)); // IndexOf method used to find the Index of an object

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}");
            }
        }

        public void ContainsMethod()
        {
            List<Customer> customers = CustomerDetails.GetCustomers();
            Customer customer3 = new Customer() { id = 103, name = "John", salary = 3500 };
            customers.Add(customer3);

            if (customers.Contains(customer3)) // Contains method used to check item in the List
            {
                Console.WriteLine("Customer3 is Exist");
            }
            else
            {
                Console.WriteLine("Customer3 is does not Exist");
            }
        }

        public void ExistsMethod()
        {
            List<Customer> customers = CustomerDetails.GetCustomers();

            if (customers.Exists(customer => customer.name.StartsWith("P")))
            {
                Console.WriteLine("Customer is Exist");
            }
            else
            {
                Console.WriteLine("Customer is does not Exist");
            }
        }

        public void FindMethod()
        {
            List<Customer> customers = CustomerDetails.GetCustomers();

            Customer customer = customers.Find(customer => customer.salary > 4000);

            Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}");
        }

        public void FindAllMethod()
        {
            List<Customer> customerList = CustomerDetails.GetCustomers();

            List<Customer> customers = customerList.FindAll(customer => customer.salary > 4000);

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}");
            }
        }

        public void FindIndexMethod()
        {
            List<Customer> customers = CustomerDetails.GetCustomers();

            int index = customers.FindIndex(customer => customer.salary > 4000);

            Console.WriteLine("Index = {0}", index);
        }
    }
}
