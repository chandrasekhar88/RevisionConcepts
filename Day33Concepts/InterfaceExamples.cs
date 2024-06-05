using System;

namespace Day33Concepts.InterfaceExamples
{
    interface ICustomer1
    {
        void Print1();
    }

    interface ICustomer2
    {
        void Print2();
    }

    public class Customer : ICustomer1, ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Implementation Interface1");
        }
        public void Print2()
        {
            Console.WriteLine("Implementation Interface2");
        }
    }

    interface ICustomer3
    {
        void Print3();
    }

    interface ICustomer4 : ICustomer3
    {
        void Print4();
    }

    public class Customer2 : ICustomer4
    {
        public void Print3()
        {
            Console.WriteLine("Implementation Interface 3 ");
        }

        public void Print4()
        {
            Console.WriteLine("Implementation Interface 4 ");
        }
    }

    interface IPartTimeEmployee
    {
        void PartTimeDetails();
    }

    interface IFullTimeEmployee
    {
        void FullTimeDetails();
    }

    public class Employee : IPartTimeEmployee, IFullTimeEmployee
    {
        
        public int id;
        public string firstName;
        public string lastName;
        public double salary;
        public float tax;
        public long accountNumber;
        public decimal allowances;
        public DateTime dateOfJoin;
        
        void IPartTimeEmployee.PartTimeDetails()
        {
            Console.WriteLine(id + " " + firstName + " " + lastName + " " + salary + " " + tax + " " + accountNumber
                + " " + allowances + " " + dateOfJoin + " - Part Time");
        }

        void IFullTimeEmployee.FullTimeDetails()
        {
            Console.WriteLine(id + " " + firstName + " " + lastName + " " + salary + " " + tax + " " + accountNumber
                + " " + allowances + " " + dateOfJoin + " - Full Time");
        }
    }
}
