using System;
using System.Collections.Generic;
using System.Linq;

namespace Day40Concepts
{
    public class IntersectMethodExamples
    {
        public void IntersectBasicExampleMethodSyntax()
        {
            List<string> alphabets1 = DataSource.Alphabets1();
            List<string> alphabets2 = DataSource.Alphabets2();

            var methodSyntax = alphabets1.Intersect(alphabets2).ToList();

            foreach (var alphabet in methodSyntax)
            {
                Console.WriteLine(alphabet);
            }
        }

        public void IntersectBasicExampleLinqQuery()
        {
            List<string> alphabets1 = DataSource.Alphabets1();
            List<string> alphabets2 = DataSource.Alphabets2();

            var querySyntax = (from alphabet in alphabets1
                               select alphabet).Intersect(alphabets2).ToList();

            foreach (var alphabet in querySyntax)
            {
                Console.WriteLine(alphabet);
            }
        }

        public void ComplexExampleUsingIntersectWithMethodSyntax()
        {
            List<Student> students1 = StudentDetails.GetStudentsName1();
            List<Student> students2 = StudentDetails.GetStudentsName2();

            var methodSyntax = students1.Intersect(students2, new StudentComparer()).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine(student.name);
            }
        }
    }
}
