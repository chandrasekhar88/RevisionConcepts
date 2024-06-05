using System.Collections.Generic;

namespace Day35Concepts
{
    public class CustomerDetails
    {
        public static List<Customer> GetCustomers()
        {
            Customer customer1 = new Customer() { id = 101, name = "Mark", salary = 5000 };
            Customer customer2 = new Customer() { id = 105, name = "Pam", salary = 6500 };
            Customer customer3 = new Customer() { id = 103, name = "John", salary = 3500 };

            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            return customers;
        }

        public static List<CustomerType> GetCustomerTypes()
        {

            CustomerType customer1 = new CustomerType() { id = 101, name = "Mark", salary = 4000, type = "Retail Customer" };
            CustomerType customer2 = new CustomerType() { id = 102, name = "Pam", salary = 7000, type = "Retail Customer" };
            CustomerType customer3 = new CustomerType() { id = 103, name = "John", salary = 5500, type = "Retail Customer" };
           
            List<CustomerType> customerType = new List<CustomerType>();
            customerType.Add(customer1);
            customerType.Add(customer2);
            customerType.Add(customer3);
            
            return customerType;
        }
    }
}
