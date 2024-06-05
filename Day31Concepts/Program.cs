using System;
using employee = Day31Concepts.EmployeeManagement;
using student = Day31Concepts.StudentManagement;
using Day31Concepts.ClassExample;
using Day31Concepts.InstanceAndStaticMembersExample;
using type = Day31Concepts.TypeAndTypeMembersExample;
using access = Day31Concepts.AccessModifiersExample;
using AssemblyTwo;
using Day31Concepts.PartialClassExample;


namespace Day31Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Department();
            //ClassExample();
            //InstanceMembersExample();
            //StaticMembersExample();
            //TypeAndTypeMembersExample();
            //AccessModifierExamples();
            PartialClassExample();
        }

        static void Department()
        {
            student.Department department = new student.Department();
            department.DisplayDepartmentInfo();

            employee.Department department1 = new employee.Department();
            department1.DisplayDepartmentInfo();
        }

        static void ClassExample()
        {
            DateTime date = new DateTime(2024, 05, 05);
            Customer customer = new Customer(1,"Chandra" , "Sekhar", 50000, 10.00F, 12354.25M,date);
            customer.PrintFullDetails();
        }

        static void InstanceMembersExample()
        {
            InstanceCircle circle = new InstanceCircle(5);
            float area = circle.CalculateArea();
            Console.WriteLine("Circle Area = {0}", area);

            InstanceCircle circle1 = new InstanceCircle(6);
            float area1 = circle.CalculateArea();
            Console.WriteLine("Circle Area = {0}", area1);

            InstanceMembers instanceMembers = new InstanceMembers();
            instanceMembers.PrintDetails();            
        }

        static void StaticMembersExample()
        {
            StaticCircle circle = new StaticCircle(12);
            float area = circle.CalculateArea();
            Console.WriteLine("Circle Area = {0}", area);

            StaticMembers.PrintDetails();
        }

        static void TypeAndTypeMembersExample()
        {
            type.Customer customer = new type.Customer();
            customer._id = 101;
            customer._firstName = "Chandra";
            customer._lastName = "Sekhar";
            Console.WriteLine($" ID = {customer._id} \n FirstName = {customer._firstName} \n LastName = {customer._lastName}");

            type.Employee employee = new type.Employee();
            employee.EmployeeDetails();
        }

        static void AccessModifierExamples()
        {
            access.CorporateCustomer customer = new access.CorporateCustomer();
            customer.PrintId();
            Console.WriteLine("-------------------------------");

            access.PermanentEmployee employee = new access.PermanentEmployee();
            employee.PrintDetails();
            Console.WriteLine("-------------------------------");

            AssemblyTwoClass2 assemblyTwo = new AssemblyTwoClass2();
            assemblyTwo.SimpleMethod();
            Console.WriteLine("-------------------------------");

            AssemblyTwoProtectedInternal protectedInternal = new AssemblyTwoProtectedInternal();
            protectedInternal.Print();
            Console.WriteLine("-------------------------------");

            AssemblyTwoProtectedInternalEmployee employee1 = new AssemblyTwoProtectedInternalEmployee();
            employee1.PrintEmployeeDetails();
        }

        static void PartialClassExample()
        {
            Product product = new Product();
            product.PrintProductDetails();
            Console.WriteLine("----------------");
            product.PrintDetails();
        }
    }
}
