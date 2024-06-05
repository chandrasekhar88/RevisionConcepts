using System;
using System.Collections.Generic;
using System.Linq;
using Day39Concepts.EmployeeProperties;
using Day39Concepts.EmployeeInformation;

namespace Day39Concepts
{
    public class ProjectionOperatorsSelectManyExamples
    {
        public void MethodSyntaxUsingSelectManyExample1()
        {
            List<EmployeeType> dataSource = EmployeeDetails.GetEmployeeTypes();

            var methodSyntax = dataSource.SelectMany(employee => employee.programming).ToList();

            foreach (var program in methodSyntax)
            {
                Console.WriteLine("Programming = {0}", program);
            }
        }

        public void LinqQueryUsingSelectManyExample1()
        {
            List<EmployeeType> dataSource = EmployeeDetails.GetEmployeeTypes();

            var querySyntax = (from employee in dataSource
                               from skills in employee.programmingSkills
                               select skills).ToList();

            foreach (var program in querySyntax)
            {
                Console.WriteLine("Programming = {0}", program);
            }
        }

        public void MethodSyntaxUsingSelectManyExample2()
        {
            List<EmployeeType> dataSource = EmployeeDetails.GetTechnologies();

            var methodQuery = dataSource.SelectMany(employee => employee.programmingSkills).ToList();

            foreach (var program in methodQuery)
            {
                Console.WriteLine("Technology = {0}", program.technology);
            }
        }

        public void LinqQueryUsingSelectManyExample2()
        {
            List<EmployeeType> dataSource = EmployeeDetails.GetTechnologies();

            var querySyntax = (from employee in dataSource
                               from skills in employee.programmingSkills
                               select skills).ToList();
            foreach (var program in querySyntax)
            {
                Console.WriteLine("Technology = {0}", program.technology);

            }
        }
    }
}
