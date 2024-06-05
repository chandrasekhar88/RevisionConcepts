using System;
using System.Collections.Generic;
using System.Linq;
using Day39Concepts.EmployeeProperties;
using Day39Concepts.EmployeeInformation;

namespace Day39Concepts
{
    public class OrderByDescendingExamples
    {
        public void OrderByDescendingInLinqQuery() 
        {
            DataSource dataSource = new DataSource();
            var numbers = dataSource.NumbersMethod2();

            var querySyntax = (from number in numbers
                               orderby number descending
                               select number).ToList();

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void OrderByDescendingInMethodSyntax()
        {
            DataSource dataSource = new DataSource();
            var numbers = dataSource.NumbersMethod2();

            var methodSyntax = numbers.OrderByDescending(number => number).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void OrderByDescendingWithWhereInLinqQuery()
        {
            DataSource dataSource = new DataSource();
            var numbers = dataSource.NumbersMethod2();

            var querySyntax = (from number in numbers
                               where number > 20
                               orderby number descending                               
                               select number).ToList();

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void OrderByDescendingWithWhereInMethodSyntax()
        {
            DataSource dataSource = new DataSource();
            var numbers = dataSource.NumbersMethod2();

            var methodSyntax = numbers.Where(number => number > 20).OrderByDescending(number => number).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void OrderByDescendingWordsInLinqQuery()
        {
            DataSource dataSource = new DataSource();
            var names = dataSource.NamesMethod();

            var querySyntax = (from name in names
                               where name.Length > 4
                               orderby name descending
                               select name).ToList();

            foreach (var name in querySyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void OrderByDescendingWordsInMethodSyntax()
        {
            DataSource dataSource = new DataSource();
            var names = dataSource.NamesMethod();

            var methodSyntax = names.Where(name => name.Length > 4).OrderByDescending(name => name).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void OrderByDescendingEmployeeInfoInLinqQuery()
        {
            List<Employee> employees = EmployeeDetails.GetEmployees();

            var querySyntax = (from employee in employees
                               orderby employee.id descending
                               select employee).ToList();

            foreach (var employee in querySyntax)
            {
                Console.WriteLine($"{employee.id}, {employee.name} and {employee.email}");
            }
        }

        public void OrderByDescendingEmployeeInfoInMethodSyntax()
        {
            List<Employee> employees = EmployeeDetails.GetEmployees();

            var methodSyntax = employees.OrderByDescending(employee => employee.id).ToList();

            foreach (var employee in methodSyntax)
            {
                Console.WriteLine($"{employee.id}, {employee.name} and {employee.email}");
            }

        }
    }
}
