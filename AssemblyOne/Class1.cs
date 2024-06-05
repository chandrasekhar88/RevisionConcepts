using System;

namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        internal int id;
    }

    public class AssemblyOneClass2
    {
        public void SimpleMethod()
        {
            AssemblyOneClass1 assemblyOne = new AssemblyOneClass1();
            assemblyOne.id = 1;
            Console.WriteLine("Assembly One Class2 = " + assemblyOne.id);
        }
    }

    public class AssemblyOneEmployee1
    {
        internal int id;
        internal string name;
        internal double salary;
        internal float tax;
        internal long accountNumber;
        internal decimal allowances;
        internal DateTime dateOfJoin;
    }

    public class AssemblyOneEmployee2
    {
        public void PrintEmployeeDetails()
        {
            AssemblyOneEmployee1 employee = new AssemblyOneEmployee1();
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

    public class AssemblyOneProtectedInternal
    {
        protected internal int id;
    }

    public class AssemblyOneProtectedInternalEmployee
    {
        protected internal int id;
        protected internal string name;
        protected internal double salary;
        protected internal float tax;
        protected internal long accountNumber;
        protected internal decimal allowances;
        protected internal DateTime dateOfJoin;
    }
}
