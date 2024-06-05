using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.StructuresExample
{
    public struct Customer
    {
        public int id;
        public string name;

        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int _id
        {
            get { return id; }
            set { this.id = value; }
        }

        public string _name
        {
            get { return name; }
            set { this.name = value; }
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} and Name = {1}", this.id, this.name );
        }
    }

    public struct Employee
    {
        int id;
        string name;
        double salary;
        long accountNumber;
        float tax;
        decimal allowances;
        DateTime dateOfJoin;

        public Employee(int id, string name, double salary, long accountNumber,float tax, decimal allowances,
            DateTime date)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.accountNumber = accountNumber;
            this.tax = tax;
            this.allowances = allowances;
            this.dateOfJoin = date;            
        }

        public int _id 
        { 
            get { return id; } 
            set { this.id = value; }
        }

        public string _name
        {
            get { return name; }
            set { this.name = value; }
        }

        public double _salary
        {
            get { return salary; }
            set { this.salary = value; }
        }

        public long _accountNumber
        {
            get { return accountNumber; }
            set { this.accountNumber = value; }
        }

        public float _tax
        {
            get { return  tax; }
            set { this.tax = value; }
        }

        public decimal _allowances
        {
            get { return allowances; }
            set { this.allowances = value; }
        }

        public DateTime _dateOfJoin
        {
            get { return dateOfJoin; }
            set { this.dateOfJoin = value; }
        }



        public void EmployeeDetails()
        {
            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}, Account Number = {3}, Tax = {4}, Allowances = {5}, " +
                "Date of join = {6}", this.id, this.name, this.salary, this.accountNumber, this.tax, this.allowances, this.dateOfJoin);
        }
    }
}
