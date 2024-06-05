using System;

namespace Day32Concepts.InheritanceExamples
{
    public class Employee
    {
        public string firstName;
        public string lastName;

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float yearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float hourlyPay;
    }

    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Class Constructor Called");
        }

        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Derived Class Controlling Parent Class")
        {
            Console.WriteLine("Child Class Constructor Called");
        }
    }

    public class Student
    {
        public int id;
        public string firstName;
        public string lastName;
        public long marks;
        public double percentage;      
    }

    public class StudentOtherDetails : Student
    {
        public float fees;
        public decimal expenses;
        public DateTime dateOfJoin;

        public void PrintStudentDetails()
        {
            StudentOtherDetails student = new StudentOtherDetails();
            student.id = 121;
            student.firstName = "Ram";
            student.lastName = "Kumar";
            student.marks = 510;
            student.percentage = 75;
            student.fees = 65000;
            student.expenses = 15000;
            student.dateOfJoin = new DateTime(2023,06,1);

            Console.WriteLine("Id = {0} \n FirstName = {1} \n LastName = {2} \n Marks = {3} \n Percentage = {4}% \n" +
                "Fees = {5} \n Other Expenses = {6} \n Date Of Join = {7}" , id,firstName,lastName,marks,percentage,
                fees,expenses,dateOfJoin);
        }
    }
}
