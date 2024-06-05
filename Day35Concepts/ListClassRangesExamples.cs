using System;
using System.Collections.Generic;

namespace Day35Concepts
{
    public class ListClassRangesExamples
    {
        public void AddRangeMethodExample()
        {
            List<CustomerType> customerTypeList = new List<CustomerType>();

            List<CustomerType> listCorporateCustomers = new List<CustomerType>();

            CustomerType customer4 = new CustomerType() { id = 104, name = "Rob", salary = 6500, type = "Corporate Customer" };
            CustomerType customer5 = new CustomerType() { id = 105, name = "Sam", salary = 3500, type = "Corporate Customer" };

            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            customerTypeList.AddRange(listCorporateCustomers);

            foreach (CustomerType customer in customerTypeList)
            {
                Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}, Type = {customer.type}");
            }
        }

        public void GetRangeMethodExample()
        {

            List<CustomerType> customerTypeList = CustomerDetails.GetCustomerTypes();

            List<CustomerType> listCorporateCustomers = new List<CustomerType>();

            CustomerType customer4 = new CustomerType() { id = 104, name = "Rob", salary = 6500, type = "Corporate Customer" };
            CustomerType customer5 = new CustomerType() { id = 105, name = "Sam", salary = 3500, type = "Corporate Customer" };

            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            customerTypeList.AddRange(listCorporateCustomers);
            List<CustomerType> customers = customerTypeList.GetRange(3, 2);

            foreach (CustomerType customer in customers)
            {
                Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}, Type = {customer.type}");
            }
        }

        public void InsertRangeMethodExample()
        {
            List<CustomerType> customerType = CustomerDetails.GetCustomerTypes();

            List<CustomerType> listCorporateCustomers = new List<CustomerType>();

            CustomerType customer4 = new CustomerType() { id = 104, name = "Rob", salary = 6500, type = "Corporate Customer" };
            CustomerType customer5 = new CustomerType() { id = 105, name = "Sam", salary = 3500, type = "Corporate Customer" };

            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            customerType.InsertRange(0, listCorporateCustomers);

            foreach (CustomerType customer in customerType)
            {
                Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}, Type = {customer.type}");
            }
        }

        public void RemoveRelatedMethodExample()
        {
            List<CustomerType> customerTypeList = CustomerDetails.GetCustomerTypes();

            CustomerType customer4 = new CustomerType() { id = 104, name = "Rob", salary = 6500, type = "Corporate Customer" };
            CustomerType customer5 = new CustomerType() { id = 105, name = "Sam", salary = 3500, type = "Corporate Customer" };

            customerTypeList.Add(customer4);
            customerTypeList.Add(customer5);

            customerTypeList.RemoveAt(3);
            /*Different Way Remove Scenarios
            customerTypeList.Remove(customer4);
            customerTypeList.RemoveAll(x => x.Type == "Corporate Customer");*/

            foreach (CustomerType customer in customerTypeList)
            {
                Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}, Type = {customer.type}");
            }
        }

    }
}
