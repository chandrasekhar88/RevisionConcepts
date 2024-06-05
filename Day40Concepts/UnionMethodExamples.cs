using System;
using System.Collections.Generic;
using System.Linq;

namespace Day40Concepts
{
    public class UnionMethodExamples
    {
        public void UnionMethodBasicExample()
        {
            List<string> alphabets1 = DataSource.Alphabets1();
            List<string> alphabets2 = DataSource.Alphabets2();

            var methodSyntax = alphabets1.Union(alphabets2);

            foreach (var alphabet in methodSyntax)
            {
                Console.WriteLine(alphabet);
            }
        }

        public void UnionMethodComplexExample()
        {
            List<Student> students1 = StudentDetails.GetStudentsName1();
            List<Student> students2 = StudentDetails.GetStudentsName2();

            var methodSyntax = students1.Union(students2, new StudentComparer()).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine(student.name);
            }
        }

        public void UnionMethodComplexExampleUsingLinqQuery()
        {
            List<Student> students1 = StudentDetails.GetStudentsName1();
            List<Student> students2 = StudentDetails.GetStudentsName2();

            var querySyntax = (from student in students1
                               select student).Union(students2, new StudentComparer()).ToList();

            foreach (var student in querySyntax)
            {
                Console.WriteLine(student.name);
            }
        }
    }
}
