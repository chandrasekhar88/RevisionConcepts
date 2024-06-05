using System;
using System.Collections.Generic;
using System.Linq;

namespace Day40Concepts
{
    public class ExceptMethodExamples
    {
        public void ExceptBasicExample()
        {
            List<string> alphabets1 = DataSource.Alphabets1();
            List<string> alphabets2 = DataSource.Alphabets2();

            var methodQuery = alphabets1.Except(alphabets2).ToList();

            foreach (var alphabet in methodQuery)
            {
                Console.WriteLine(alphabet);
            }
        }

        public void ExceptExampleUsingMethodSyntax()
        {
            List<Student> students1 = StudentDetails.GetStudentsName1();
            List<Student> students2 = StudentDetails.GetStudentsName2();

            var methodSyntax = students1.Except(students2, new StudentComparer()).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine($"Id = {student.id} and Name = {student.name}");
            }
        }

        public void ExceptExampleUsingLinqQuery()
        {
            List<Student> students1 = StudentDetails.GetStudentsName1();
            List<Student> students2 = StudentDetails.GetStudentsName2();

            var querySyntax = (from student in students1
                               select student).Except(students2, new StudentComparer()).ToList();
            
            foreach (var student in querySyntax)
            {
                Console.WriteLine($"Id = {student.id} and Name = {student.name}");
            }
        }
    }
}
