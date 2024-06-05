using System;

namespace Day31Concepts.TypeAndTypeMembersExample
{
    public class Customer
    {
        #region Fields
        private int id;
        private string firstName;
        private string lastName;
        #endregion

        #region Properties
        public int _id
        {
            get { return id; }
            set { id = value;}
        }

        public string _firstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string _lastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        #endregion

        #region Methods
        public string GetFullName()
        {
            return this.firstName + " " + this.lastName;
        }
        #endregion
    }


    public class Employee
    {
        private int id;
        private string name;
        private long accountNumber;
        private double salary;
        private float tax;
        private decimal allowances;
        private DateTime dateOfJoin;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        public string _name
        {
            get { return name; }
            set { name = value; }
        }

        public long _accountNumber
        { 
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public double _salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public float _tax
        {
            get { return tax; }
            set { tax = value; }
        }

        public decimal _allowances
        {
            get { return allowances; }
            set { allowances = value; }
        }

        public DateTime _dateOfJoin
        {
            get { return dateOfJoin; }
            set { dateOfJoin = value; }
        }

        public void  EmployeeDetails()
        {
            id = 10;
            name = "Joe";
            salary = 50000;
            accountNumber = 6645;
            tax = 5;
            allowances = 5500;
            dateOfJoin = DateTime.Now;

            Console.WriteLine($" Id = {id} \n Name = { name} \n Salary = { salary} \n Account number ={ accountNumber}" +
                $" \n Tax { tax}% \n Allowances = { allowances} \n Date Of Join = {dateOfJoin}");
        }
    }
}
