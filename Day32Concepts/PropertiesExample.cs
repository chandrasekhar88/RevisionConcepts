using System;

namespace Day32Concepts.PropertiesExample
{
    public class Student
    {
        private int id;
        private string name;
        private int passMarks = 35;

        public int _id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id cannot be Negative");
                }
                this.id = value;
            }

            get
            {
                return this.id;
            }
        }

        public string _name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be Null or Empty");
                }
                else
                {
                    this.name = value;
                }
            }
            get
            {
                return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
            }

        }

        public int _passMarks
        {
            get
            {
                return this.passMarks;
            }
        }
    }

    public class Employee
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public double _salary { get; set; }
        public long _age { get; set; }
        public float _tax { get; set; }
        public decimal _allowances { get; set; }
        public DateTime _date { get; set; }
    }
}
