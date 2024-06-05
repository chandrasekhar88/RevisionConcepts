using System;
using System.Collections.Generic;
using System.Linq;
using Day39Concepts.EmployeeProperties;
using Day39Concepts.EmployeeInformation;

namespace Day39Concepts
{
    public class ProjectionOperatorsSelectExamples
    {
        public void BasicLinqQueryExample()
        {
            List<Employee> employees = EmployeeDetails.GetEmployees();

            var basicQuery = (from employee in employees
                              select employee).ToList();

            foreach (var employee in basicQuery)
            {
                Console.WriteLine($"Id = {employee.id}, Name = {employee.name} and Email = {employee.email}");
            }
        }

        public void BasicMethodSyntaxExample()
        {
            List<Employee> employees = EmployeeDetails.GetEmployees();

            var basicMethod = employees.ToList();

            var basicMethod1 = employees.Select(employee => employee.id).ToList();

            foreach (var employee in basicMethod)
            {
                Console.WriteLine($"Id = {employee.id}, Name = {employee.name} and Email = {employee.email}");
            }
        }

        public void BasicLinqQueryExample1()
        {
            List<Employee> employees = EmployeeDetails.GetEmployees();

            var basicPropertyQuery1 = (from employee in employees
                                       select employee.id).ToList(); // Fetching particular record from the list using Linq Query

            var basicPropertyQuery2 = (from employee in employees
                                       select employee.id + 1).ToList(); // We can apply Arithmetic operations also.

            var basicPropertyQuery3 = (from employee in employees
                                       select employee.id.ToString()).ToList();

            foreach (var employeeId in basicPropertyQuery1)
            {
                Console.WriteLine(employeeId);
            }
        }

        public void BasicMethodSyntaxExample1()
        {
            List<Employee> employees = EmployeeDetails.GetEmployees();

            var basicPropertyMethod1 = employees.Select(employee => employee.id).ToList();

            var basicPropertyMethod2 = employees.Select(employee => employee.id.ToString()).ToList();

            foreach (var employeeId in basicPropertyMethod2)
            {
                Console.WriteLine(employeeId);
            }
        }

        public void BasicLinqQueryExample2()
        {
            List<Employee> employees = EmployeeDetails.GetEmployees();

            var selectQuery = (from employee in employees
                               select new Employee
                               {
                                   id = employee.id,
                                   email = employee.email
                               }).ToList();

            foreach (var employee in selectQuery)
            {
                Console.WriteLine($"Id = {employee.id} and Email = {employee.email}");
            }
        }

        public void AssigningExistingDataToOtherClassUsingLinqQuery()
        {
            List<Employee> employees = EmployeeDetails.GetEmployees();

            var selectQuery = (from employee in employees
                               select new Student
                               {
                                   studentId = employee.id,
                                   studentFullName = employee.name,
                                   studentEmail = employee.email
                               }).ToList();
            foreach (var student in selectQuery)
            {
                Console.WriteLine($"Student Id = {student.studentId},Full Name = {student.studentFullName}" +
                    $" and Email = {student.studentEmail}");
            }
        }

        public void AssigningExistingDataToOtherClassUsingMethodSyntax()
        {
            List<Employee> employees = EmployeeDetails.GetEmployees();

            var selectMethod = employees.Select(employee => new Student
            {
                studentId = employee.id,
                studentFullName = employee.name,
                studentEmail = employee.email
            }).ToList();

            foreach (var student in selectMethod)
            {
                Console.WriteLine($"Student Id = {student.studentId},Full Name = {student.studentFullName}" +
                    $" and Email = {student.studentEmail}");
            }
        }

        public void AnonymousTypeInLinqQuery()
        {
            List<Employee> employees = EmployeeDetails.GetEmployees();

            var selectQuery = (from employee in employees
                               select new
                               {
                                   customId = employee.id,
                                   customName = employee.name,
                                   customEmail = employee.email

                               }).ToList();

            foreach (var anonymous in selectQuery)
            {
                Console.WriteLine($"Id = {anonymous.customId},Full Name = {anonymous.customId}" +
                    $" and Email = {anonymous.customEmail}");
            }
        }

        public void AnonymousTypeInMethodSyntax()
        {
            List<Employee> employees = EmployeeDetails.GetEmployees();

            var selectMethod = employees.Select(employee => new
            {
                customId = employee.id,
                customFullName = employee.name,
                customEmail = employee.email

            }).ToList();

            var query = employees.Select((employee, index) => new { Index = index, Name = employee.name }).ToList();

            foreach (var anonymous in selectMethod)
            {
                Console.WriteLine($"Id = {anonymous.customId},Full Name = {anonymous.customId}" +
                    $" and Email = {anonymous.customEmail}");
            }
        }
    }
}
