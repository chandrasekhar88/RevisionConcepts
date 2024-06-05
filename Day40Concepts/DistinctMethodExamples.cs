using System;
using System.Collections.Generic;
using System.Linq;

namespace Day40Concepts
{
    public class DistinctMethodExamples
    {
        public void DistinctExampleWithMethodSyntax()
        {
            List<int> numbers = DataSource.Numbers();

            var methodSyntax = numbers.Distinct().ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void DistinctExampleWithQuerySyntax()
        {
            List<int> numbers = DataSource.Numbers();

            var querySyntax = (from number in numbers
                               select number).Distinct().ToList();

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }
        
        public void StudentRecordsDistinctExampleWithMethodSyntax()
        {
            List<Student> students = StudentDetails.GetStudentsList();

            var methodSyntax = students.Distinct(new StudentComparer()).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine(student.name);
            }
        }
    }
}
