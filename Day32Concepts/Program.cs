using System;
using inheritance = Day32Concepts.InheritanceExamples;
using methodHiding = Day32Concepts.MethodHidingExamples;
using getSet = Day32Concepts.GetAndSetMethodsExample;
using properties = Day32Concepts.PropertiesExample;
using structure = Day32Concepts.StructuresExample;
using overRide = Day32Concepts.MethodOverRidingExamples;

namespace Day32Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InheritanceExample1();
            //InheritanceExample2();
            //InheritanceExample3();
            //MethodHidingExample1();
            //MethodHidingExample2();
            //MethodOverLoadingExample();
            //GetSetMethodsExample();
            //PropertiesExample();
            StructureExample();
        }

        static void InheritanceExample1()
        {
            inheritance.FullTimeEmployee employeeObj = new inheritance.FullTimeEmployee();
            employeeObj.firstName = "Savar";
            employeeObj.lastName = "Technologies";
            employeeObj.PrintFullName();
            Console.WriteLine(employeeObj.yearlySalary = 5000000);
        }

        static void InheritanceExample2()
        {
            inheritance.PartTimeEmployee employeeObj1 = new inheritance.PartTimeEmployee();
            employeeObj1.firstName = "Chandra";
            employeeObj1.lastName = "Sekhar";
            employeeObj1.PrintFullName();
            Console.WriteLine(employeeObj1.hourlyPay = 500);
        }

        static void InheritanceExample3()
        {
            inheritance.StudentOtherDetails student = new inheritance.StudentOtherDetails();
            student.PrintStudentDetails();
        }

        static void MethodHidingExample1()
        {
            methodHiding.FullTimeEmployee fullTimeEmployee = new methodHiding.FullTimeEmployee();
            fullTimeEmployee.firstName = "FullTime";
            fullTimeEmployee.lastName = "Employee";
            fullTimeEmployee.PrintFullName();

            methodHiding.PartTimeEmployee partTimeEmployee = new methodHiding.PartTimeEmployee();
            partTimeEmployee.firstName = "PartTime";
            partTimeEmployee.lastName = "Employee";
            partTimeEmployee.PrintFullName();
        }

        static void MethodHidingExample2()
        {
            methodHiding.FullTimeEmployee1 fullTimeEmployee = new methodHiding.FullTimeEmployee1();
            fullTimeEmployee.id = 101;
            fullTimeEmployee.firstName = "FullTime";
            fullTimeEmployee.lastName = "Employee";
            fullTimeEmployee.salary = 100000;
            fullTimeEmployee.accountNumber = 652762541;
            fullTimeEmployee.tax = 5;
            fullTimeEmployee.allowances = 5000;
            fullTimeEmployee.dateOfJoin = new DateTime(2023,05,2);
            fullTimeEmployee.PrintFullDetails();

            methodHiding.PartTimeEmployee1 partTimeEmployee = new methodHiding.PartTimeEmployee1();
            partTimeEmployee.id = 102;
            partTimeEmployee.firstName = "PartTime";
            partTimeEmployee.lastName = "Employee";
            partTimeEmployee.salary = 500;
            partTimeEmployee.accountNumber = 645875541;
            partTimeEmployee.tax = 5;
            partTimeEmployee.allowances = 2000;
            partTimeEmployee.dateOfJoin = new DateTime(2023, 12, 21);
            partTimeEmployee.PrintFullDetails();
        }

        static void MethodOverLoadingExample()
        {
            MethodOverLoadingExamples overLoading = new MethodOverLoadingExamples();
            overLoading.Add(1, 1);
            overLoading.Add(165, 531);
            overLoading.Add(15.0, 10.0);
            overLoading.Add(13.05F, 10.2F);
            overLoading.Add(63.05M, 14.2M);
            overLoading.Add(12, 10.2);
            overLoading.Add(12, 10.2, 5.6F);
            overLoading.Add(10.2, 5.6F);
            overLoading.Concatenation("Chandra", "Sekhar");
            overLoading.Concatenation("Chandra", "Sekhar", 'A');
            overLoading.Concatenation("Chandra", "Sekhar", 'A', new DateTime(2024, 05, 11));
        }

        static void GetSetMethodsExample()
        {
            getSet.Student student = new getSet.Student();
            student.SetId(101);
            student.SetName("Mark");
            
            Console.WriteLine("Id = " + student.GetId());
            Console.WriteLine("Name = " + student.GetName());
            Console.WriteLine("Marks = " + student.GetPassMarks());

            Console.WriteLine("-----------------");

            getSet.Employee employee = new getSet.Employee();
            employee.SetId(102);
            employee.SetName("Rama");
            employee.SetSalary(50000);
            employee.SetTax(6.5F);
            employee.SetAllowances(5600.00M);

            Console.WriteLine("Id = {0}", employee.GetId());
            Console.WriteLine("Name = {0}", employee.GetName());
            Console.WriteLine("Salary = {0}", employee.GetSalary());
            Console.WriteLine("Age = {0}", employee.GetAge());
            Console.WriteLine("Tax = {0}", employee.GetTax());
            Console.WriteLine("Allowances = {0}", employee.GetAllowances());
            Console.WriteLine("Date Of Join = {0}", employee.GetDateOfJoin());
        }

        static void PropertiesExample()
        {
            properties.Student student = new properties.Student();
            student._id = 236;
            student._name = "JACK";

            Console.WriteLine("Id = " + student._id);
            Console.WriteLine("Name = " + student._name);
            Console.WriteLine("Marks = " + student._passMarks);

            Console.WriteLine("-----------------");

            properties.Employee employee = new properties.Employee();
            employee._id = 54;
            employee._name = "Prop Mark";
            employee._salary = 65725;
            employee._age = 25;
            employee._tax = 3.5F;
            employee._allowances = 5000.05M;
            employee._date = new DateTime(2023, 04, 11);


            Console.WriteLine("Id = {0}", employee._id);
            Console.WriteLine("Name = {0}", employee._name);
            Console.WriteLine("Salary = {0}", employee._salary);
            Console.WriteLine("Age = {0}", employee._age);
            Console.WriteLine("Tax = {0}", employee._tax);
            Console.WriteLine("Allowances = {0}", employee._allowances);
            Console.WriteLine("Date Of Join = {0}", employee._date);
        }

        static void StructureExample()
        {
            structure.Customer customer = new structure.Customer();
            customer.id = 1;
            customer.name = "Test";
            customer.PrintDetails();
            Console.WriteLine("-------------------------");

            structure.Employee employee = new structure.Employee();
            employee._id = 54;
            employee._name = "Prop Mark";
            employee._salary = 65725;
            employee._accountNumber = 25;
            employee._tax = 3.5F;
            employee._allowances = 5000.05M;
            employee._dateOfJoin = new DateTime(2023, 04, 11);
            employee.EmployeeDetails();
        }

        static void MethodOverRideExample()
        {
            overRide.Employee[] employees = new overRide.Employee[4];
            employees[0] = new overRide.Employee();
            employees[1] = new overRide.FullTimeEmployee();
            employees[2] = new overRide.PartTimeEmployee();
            employees[3] = new overRide.TemporaryEmployee();

            foreach (overRide.Employee employee in employees)
            {
                employee.PrintFullName();
            }
        }
    }
}
