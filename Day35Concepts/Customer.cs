using System;
using System.Collections.Generic;

namespace Day35Concepts
{
    public class Customer : IComparable<Customer>
    {
        public int id { get; set; }
        public int age { get; set; }
        public string name { get; set; }
        public double salary { get; set; }


        public int CompareTo(Customer other)
        {
            List<Customer> customers = CustomerDetails.GetCustomers();
            return this.salary.CompareTo(other.salary);

        }
    }
    
    public class CustomerType : Customer
    {
         public string type { get; set; }
    }
}
