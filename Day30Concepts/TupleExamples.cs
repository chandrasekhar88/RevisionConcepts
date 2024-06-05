using System;

namespace Day30Concepts
{
    public class TupleExamples
    {

        public void EmployeeDetails1()
        {
            DateTime dateTime = new DateTime(2023, 05, 11);
            Tuple<int, string, double, long, float, decimal, DateTime> employee = new Tuple<int, string, double, long, float, decimal, DateTime>
                (1, "Peter", 60000, 6665655, 5400.00F, 5000.00M,dateTime);

            Console.WriteLine($"Employee Id = {employee.Item1} \n Name = {employee.Item2} \n Salary = {employee.Item3} \n" +
                $"Incentives = {employee.Item4} \n Allowances = {employee.Item5} \n" +
                $"Bank A/C No = {employee.Item6} \n Date of Join = {employee.Item6}");

        }

        public (int id, string name, double salary, long acNumber,float incentives, decimal allowances, 
            DateTime doj) EmployeeDetails()
        {
            DateTime dateTime = new DateTime(2023,05,11);
            
            var employee = (id: 1,
                            name: "Peter",
                            salary: 86000,
                            acNumber: 96575265,
                            incentives : 5400.00F,
                            allowances: 5000.00M,
                            doj: dateTime);
            return employee;
        }
    }
}
