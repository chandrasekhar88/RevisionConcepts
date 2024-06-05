using System;

namespace Day32Concepts.MethodHidingExamples
{
    public class Employee
    {
        public string firstName;
        public string lastName;

        public virtual void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Permanent");

        }
    }

    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Contractor");

        }
    }

    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("This is Base Class Print Method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public new void Print()
        {
            Console.WriteLine("This is Derived Class Print Method");
        }
    }

    public class Employee1
    {
        public int id;
        public string firstName;
        public string lastName;
        public double salary;
        public float tax;
        public long accountNumber;
        public decimal allowances;
        public DateTime dateOfJoin;

        public virtual void PrintFullDetails()
        {
            Console.WriteLine(id + " " + firstName + " " + lastName + " " + salary + " " + tax + " " + accountNumber
                + " " + allowances + " " + dateOfJoin);
        }
    }

    public class FullTimeEmployee1 : Employee1
    {
        public new void PrintFullDetails()
        {
            Console.WriteLine(id + " " + firstName + " " + lastName + " " + salary + " " + tax + " " + accountNumber
                + " " + allowances + " " + dateOfJoin + " - Full-Time");
        }
    }

    public class PartTimeEmployee1 : Employee1
    {
        public new void PrintFullDetails()
        {
            Console.WriteLine(id + " " + firstName + " " + lastName + " " + salary + " " + tax + " " + accountNumber
                + " " + allowances + " " + dateOfJoin + " - Part-Time");
        }
    }
}
