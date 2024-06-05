using System;

namespace Day31Concepts.AccessModifiersExample
{
    public class Customer
    {
        protected int id;
    }

    public class CorporateCustomer : Customer 
    {
        public void PrintId()
        {
            // we can use base or this or creating object for accessing base class members
            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.id = 101;
            Console.WriteLine(corporateCustomer.id);
            base.id = 102; 
            Console.WriteLine(base.id); ;
            this.id = 103;
            Console.WriteLine(this.id);
        }
    }

    public class Employee
    {
        protected int id;
        protected string name;
        protected double salary;
        protected float tax;
        protected long accountNumber;
        protected decimal allowances;
        protected DateTime dateOfJoin;
    }

    public class PermanentEmployee : Employee
    {
        public void PrintDetails()
        {
           PermanentEmployee employee = new PermanentEmployee();
            employee.id = 123;
            employee.name = "Ram";
            employee.salary = 500000;
            employee.tax = 5;
            employee.accountNumber = 96547514;
            employee.allowances = 5200;
            employee.dateOfJoin = new DateTime(2024, 05, 05);

            Console.WriteLine($" Id = {employee.id} \n Name = {employee.name} \n Salary = {employee.salary} \n " +
                $"Account number ={employee.accountNumber} \n Tax = {employee.tax}% \n " + 
                $"Allowances = {employee.allowances} \n Date Of Join = {employee.dateOfJoin}");
        }
    }

}
