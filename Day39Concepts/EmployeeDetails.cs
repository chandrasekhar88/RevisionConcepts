using System;
using System.Collections.Generic;
using Day39Concepts.EmployeeProperties;

namespace Day39Concepts.EmployeeInformation
{
    public class EmployeeDetails
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { id = 1, name = "Tom", email = "tom@gmail.com" },
                new Employee() { id = 5, name = "John", email = "john@gmail.com" },
                new Employee() { id = 3, name = "Mark", email = "mark@gmail.com" },
                new Employee() { id = 2, name = "Kim", email = "kim@gmail.com" },
                new Employee() { id = 4, name = "Adam", email = "adam@gmail.com" }
            };

            return employees;
        }

        public static List<EmployeeType> GetEmployeeTypes()
        {
            List<EmployeeType> employeeType = new List<EmployeeType>()
            {
                new EmployeeType()
                {
                    id = 1,
                    name = "Tom",
                    email = "tom@gmail.com",
                    programming = new List<string>(){ "C#", "PHP", "JAVA"}
                },

                new EmployeeType()
                {
                    id = 2,
                    name = "John",
                    email = "john@gmail.com",
                    programming = new List<string>(){ "LINQ", "C#", "MVC"}
                },

                new EmployeeType()
                {
                    id = 3,
                    name = "Mark",
                    email = "mark@gmail.com",
                    programming = new List<string>(){ "LINQ", "VB", "SQL"}
                }

            };

            return employeeType;
        }

        public static List<EmployeeType> GetTechnologies()
        {
            List<EmployeeType> technologies = new List<EmployeeType>()
            {
                new EmployeeType()
                {
                    id = 1,
                    name = "Tom",
                    email = "tom@gmail.com",
                    programmingSkills = new List<TechnologySkills>(){
                        new TechnologySkills() { technology = "C#" },
                        new TechnologySkills() { technology = "PHP" },
                        new TechnologySkills() { technology = ".NET" }

                    }
                },

                new EmployeeType()
                {
                    id = 2,
                    name = "John",
                    email = "john@gmail.com",
                    programmingSkills = new List<TechnologySkills>(){
                        new TechnologySkills() { technology = "C#" },
                        new TechnologySkills() { technology = "VB" },
                        new TechnologySkills() { technology = "SQL" }

                    }
                },

                new EmployeeType()
                {
                    id = 3,
                    name = "Mark",
                    email = "mark@gmail.com",
                    programmingSkills = new List<TechnologySkills>(){
                        new TechnologySkills() { technology = "LINQ" },
                        new TechnologySkills() { technology = "MVC" },
                        new TechnologySkills() { technology = ".NET" }

                    }
                },

                new EmployeeType()
                {
                    id = 4,
                    name = "KIm",
                    email = "kim@gmail.com",
                    programmingSkills = new List<TechnologySkills>(){}
                },

                new EmployeeType()
                {
                    id = 5,
                    name = "Adam",
                    email = "adam@gmail.com",
                    programmingSkills = new List<TechnologySkills>(){}
                }

            };

            return technologies;
        }
    }
}