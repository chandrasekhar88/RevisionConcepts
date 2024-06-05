using System;
using System.Collections.Generic;
using System.Linq;
using Day39Concepts.EmployeeProperties;
using Day39Concepts.EmployeeInformation;

namespace Day39Concepts
{
    public class OrderByExamples
    {
        public void OrderByExampleInLinqQuery()
        {
            DataSource dataSource = new DataSource();
            var numbers = dataSource.NumbersMethod2();

            var querySyntax = (from number in numbers
                               orderby number
                               select number).ToList();

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void OrderByExampleInMethodSyntax()
        {
            DataSource dataSource = new DataSource();
            var numbers = dataSource.NumbersMethod2();

            var methodSyntax = numbers.OrderBy(number => number).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void OrderByWithWhereInLinqQuery()
        {
            DataSource dataSource = new DataSource();
            var numbers = dataSource.NumbersMethod2();

            var querySyntax = (from number in numbers
                               where number > 20
                               orderby number
                               select number).ToList();

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void OrderByWithWhereInMethodSyntax()
        {
            DataSource dataSource = new DataSource();
            var numbers = dataSource.NumbersMethod2();

            var methodSyntax = numbers.Where(number => number > 20).OrderBy(number => number).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void OrderByWordsInLinqQuery()
        {
            DataSource dataSource = new DataSource();
            var names = dataSource.NamesMethod();

            var querySyntax = (from name in names
                               where name.Length > 4
                               orderby name
                               select name).ToList();

            foreach (var name in querySyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void OrderByWordsInMethodSyntax()
        {
            DataSource dataSource = new DataSource();
            var names = dataSource.NamesMethod();

            var methodSyntax = names.Where(name => name.Length > 4).OrderBy(name => name).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void OrderByEmployeeDetailsInLinqQuery()
        {
            List<Employee> employees = EmployeeDetails.GetEmployees();

            var querySyntax = (from employee in employees
                               where employee.id > 2
                               orderby employee.name
                               select employee).ToList();

            foreach (var employee in querySyntax)
            {
                Console.WriteLine($"{employee.id}, {employee.name} and {employee.email}");
            }
        }

        public void OrderByEmployeeDetailsInMethodSyntax()
        {
            List<Employee> employees = EmployeeDetails.GetEmployees();

            var methodSyntax = employees.Where(employee => employee.id > 2).OrderBy(employee => employee.name).ToList();

            foreach (var employee in methodSyntax)
            {
                Console.WriteLine($"{employee.id}, {employee.name} and {employee.email}");
            }
        }
    }
}
