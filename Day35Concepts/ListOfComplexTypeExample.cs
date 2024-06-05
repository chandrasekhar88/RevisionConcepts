using System;
using System.Collections.Generic;

namespace Day35Concepts
{
    public class ListOfComplexTypeExample
    {
        public void PrintCustomerInfoUsingSortMethod()
        {
            List<Customer> customers = CustomerDetails.GetCustomers();

            Console.WriteLine("Before Sorting");

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.salary);
            }

            Console.WriteLine("After Sorting");

            customers.Sort();

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.salary);
            }

            Console.WriteLine("After Descending Order");

            customers.Reverse();

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.salary);
            }

            Console.WriteLine("Sorting using by SortByName class");

            SortByName sortByName = new SortByName();
            customers.Sort(sortByName);

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.name);
            }
        }

        public void UsingComparisonDelegate()
        {
            List<Customer> customers = CustomerDetails.GetCustomers();

            Console.WriteLine("Before Sorting");

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.id);
            }

            Console.WriteLine("After Sorting Using Delegate");

            Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);
            customers.Sort(customerComparer);

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.id);
            }
        }

        private int CompareCustomer(Customer x, Customer y)
        {
            return x.id.CompareTo(y.id);
        }

        public void UsingLambdaExpression()
        {
            List<Customer> customers = CustomerDetails.GetCustomers();

            Console.WriteLine("Before Sorting");

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.id);
            }

            Console.WriteLine("After Sorting");
            customers.Sort((x, y) => x.id.CompareTo(y.id));

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.id);
            }
        }
    }

    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.name.CompareTo(y.name);
        }
    }
}

