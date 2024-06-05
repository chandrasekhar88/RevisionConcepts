using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass1
    {
        internal int id;
    }

    public class AssemblyTwoClass2
    {
        public void SimpleMethod()
        {
            AssemblyOneClass2 assemblyOne = new AssemblyOneClass2();
            assemblyOne.SimpleMethod();
            Console.WriteLine();

            AssemblyOneEmployee2 employee = new AssemblyOneEmployee2();
            employee.PrintEmployeeDetails();
        }
    }

    public class AssemblyTwoProtectedInternal : AssemblyOneProtectedInternal
    {
        public void Print()
        {
            AssemblyOneProtectedInternal _protectedInternal = new AssemblyOneProtectedInternal();
            base.id = 121;

            AssemblyTwoProtectedInternal _protectedInternal2 = new AssemblyTwoProtectedInternal();
            _protectedInternal2.id = 123;
        }
    }

    public class AssemblyTwoProtectedInternalEmployee : AssemblyOneProtectedInternalEmployee
    {
        public void PrintEmployeeDetails()
        {
            AssemblyTwoProtectedInternalEmployee employee = new AssemblyTwoProtectedInternalEmployee();
            employee.id = 1234;
            employee.name = "Shyam";
            employee.salary = 600000;
            employee.tax = 5;
            employee.accountNumber = 965475214;
            employee.allowances = 6200;
            employee.dateOfJoin = new DateTime(2024, 05, 02);

            Console.WriteLine($" Id = {employee.id} \n Name = {employee.name} \n Salary = {employee.salary} \n " +
                $"Account number ={employee.accountNumber} \n Tax = {employee.tax}% \n " +
                $"Allowances = {employee.allowances} \n Date Of Join = {employee.dateOfJoin}");
        }
    }
}
