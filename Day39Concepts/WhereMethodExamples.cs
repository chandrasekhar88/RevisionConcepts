using System;
using System.Collections.Generic;
using System.Linq;
using Day39Concepts.EmployeeProperties;
using Day39Concepts.EmployeeInformation;


namespace Day39Concepts
{
    public class WhereMethodExamples
    {
        public void WhereUsingInLinqQuery()
        {
            DataSource dataSource = new DataSource();
            var numbers = dataSource.NumbersMethod();

            var querySyntax = (from number in numbers
                               where number > 5  
                               select number).ToList();
            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void WhereUsingInMethodSyntax()
        {
            DataSource dataSource = new DataSource();
            var numbers = dataSource.NumbersMethod();

            var methodSyntax = numbers.Where(x => x > 5).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void WhereInLinqQueryWithMultipleConditions()
        {
            DataSource dataSource = new DataSource();
            var numbers = dataSource.NumbersMethod();

            var querySyntax = (from number in numbers
                               where number <= 5 || number > 9
                               select number).ToList();

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void WhereInMethodSyntaxWithMultipleConditions()
        {
            DataSource dataSource = new DataSource();
            var numbers = dataSource.NumbersMethod();

            var methodSyntax = numbers.Where(number => number <= 5 || number > 9).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void WhereInLinqQueryWithConditions()
        {
            DataSource dataSource = new DataSource();
            var words = dataSource.NamesMethod();

            var querySyntax = (from word in words
                               where word.Length <= 4 || word == "Sachin"
                               select word).ToList();

            foreach (var word in querySyntax)
            {
                Console.WriteLine(word);
            }
        }

        public void WhereInMethodSyntaxWithConditions()
        {
            DataSource dataSource = new DataSource();
            var words = dataSource.NamesMethod();

            var methodSyntax = words.Where(word => word.Length <= 4 || word == "Sachin").ToList();

            foreach (var word in methodSyntax)
            {
                Console.WriteLine(word);
            }
        }

        public void LinqQueryEmployeeDetailsWithWhere()
        {
            List<EmployeeType> employees = EmployeeDetails.GetTechnologies();

            var querySyntax = (from employee in employees
                               where employee.programmingSkills.Count == 0
                               select employee).ToList();

            foreach (var employee in querySyntax)
            {
                Console.WriteLine($"{employee.name}");
            }
        }

        public void MethodSyntaxEmployeeDetailsWithWhere()
        {
            List<EmployeeType> employees = EmployeeDetails.GetTechnologies();

            var methodSyntax = employees.Where(employee => employee.programmingSkills.Count == 0).ToList();

            foreach (var employee in methodSyntax)
            {
                Console.WriteLine($"{employee.name}");
            }
        }

        public void LinqQueryEmployeeSkillsWithMultipleConditionsUsingWhere()
        {
            List<EmployeeType> employees = EmployeeDetails.GetTechnologies();

            var querySyntax = (from employee in employees
                               where employee.programmingSkills.Count == 0 && employee.id == 4
                               select employee).ToList();

            foreach (var employee in querySyntax)
            {
                Console.WriteLine($"{employee.name}");
            }
        }

        public void MethodSyntaxEmployeeSkillsWithMultipleConditionsUsingWhere()
        {
            List<EmployeeType> employees = EmployeeDetails.GetTechnologies();

            var methodSyntax = employees.Where(employee => employee.programmingSkills.Count >= 3 ||
            employee.name == "KIm").ToList();

            foreach (var employee in methodSyntax)
            {
                Console.WriteLine($"{employee.name}");
            }
        }
    }
}
