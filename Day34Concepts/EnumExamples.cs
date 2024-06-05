using System;

namespace Day34Concepts.EnumExamples
{
    public class Customer
    {
        public string name { get; set; }
        public int gender { get; set; }

        public string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data";
            }
        }

        public void PrintCustomerDetails()
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer { name = "Mark", gender = 1 };
            customers[1] = new Customer { name = "Jessi", gender = 2 };
            customers[2] = new Customer { name = "John", gender = 0 };

            foreach (Customer c in customers)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", c.name, GetGender(c.gender));
            }
        }
    }

    public class Employee
    {
        public string name { get; set; }
        public Gender gender { get; set; }

        public enum Gender
        {
            unknown,
            male,
            female
        }

        public string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.unknown:
                    return "Unknown";

                case Gender.male:
                    return "Male";

                case Gender.female:
                    return "Female";

                default:
                    return "Invalid data";
            }
        }

        public void PrintEmployeeDetails()
        {
            Employee[] employees = new Employee[3];

            employees[0] = new Employee { name = "Ram", gender = Gender.male };
            employees[1] = new Employee { name = "rani", gender = Gender.female };
            employees[2] = new Employee { name = "Sam", gender = Gender.unknown };

            foreach (Employee employee in employees)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", employee.name, GetGender(employee.gender));
            }
        }
    }

    public class Product
    {
        public Type type { get; set; }

        public enum Type
        {
            mobile,
            laptop,
            desktop
        }

        public string GetGender(Type type)
        {
            switch (type)
            {
                case Type.mobile:
                    return "Mobile";

                case Type.laptop:
                    return "Laptop";

                case Type.desktop:
                    return "Desktop";

                default:
                    return "Invalid data";
            }
        }

        public void PrintProductDetails()
        {
            Product[] products = new Product[3];

            products[0] = new Product { type = Type.mobile };
            products[1] = new Product { type = Type.laptop };
            products[2] = new Product { type = Type.desktop };

            foreach (Product product in products)
            {
                Console.WriteLine("Type = {0}", product.type);
            }
        }
    }
}
