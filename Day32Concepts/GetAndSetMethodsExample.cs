using System;

namespace Day32Concepts.GetAndSetMethodsExample
{
    public class Student
    {
        private int id;
        private string name;
        private int passMarks = 35;

        public void SetId(int _id)
        {
            if (_id <= 0)
            {
                throw new Exception("Student Id cannot be Negative");
            }

            this.id = _id;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetName(string _name)
        {
            if (string.IsNullOrEmpty(_name))
            {
                throw new Exception("Name cannot be Null or Empty");
            }
            else
            {
                this.name = _name;
            }

        }

        public string GetName()
        {
            #region MyRegion
            /*if (string.IsNullOrEmpty(this.name))
            {
                return "No Name";
            }
            else
            {
                return this.name;
            }*/
            #endregion

            return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
        }

        public int GetPassMarks()
        {
            return this.passMarks;
        }
    }

    public class Employee
    {
        private int id;
        private string name;
        private double salary;
        private long age = 25;
        private float tax;
        private decimal allowances;
        private DateTime date = new DateTime(2022, 11, 02);

        public void SetId(int _id)
        {
            if (_id <= 0)
            {
                throw new Exception("Employee Id cannot be Negative");
            }

            this.id = _id;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetName(string _name)
        {
            if (string.IsNullOrEmpty(_name))
            {
                throw new Exception("Name cannot be Null or Empty");
            }
            else
            {
                this.name = _name;
            }

        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
        }

        public void SetSalary(double _salary)
        {
            if (_salary <= 0)
            {
                throw new Exception("Salary Cannot be Negative and Null");
            }
            else
            {
                this.salary = _salary;
            }
        }
        public double GetSalary()
        {
            return this.salary;
        }

        public long GetAge()
        {
            return this.age;
        }

        public void SetTax(float _tax)
        {
            if (_tax <= 0)
            {
                throw new Exception("Tax Cannot be Negative Or Null");
            }
            else
            {
                this.tax = _tax;
            }
        }

        public float GetTax()
        {
            return this.tax;
        }

        public void SetAllowances(decimal _allowances)
        {
            if (_allowances <= 0)
            {
                throw new Exception("Allowances cannot be Empty or Negative");
            }
            else
            {
                this.allowances = _allowances;
            }
        }

        public decimal GetAllowances()
        {
            return (decimal)this.allowances;
        }

        public DateTime GetDateOfJoin()
        {
            return this.date;
        }
    }
}
