using System;

namespace Day32Concepts.MethodOverRidingExamples
{
    class Employee
    {
        public string firstName = "FirstName";
        public string lastName = "LastName";

        public virtual void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Part Time");
        }
    }

    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Full Time");
        }
    }

    class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Temporary");
        }
    }
}
