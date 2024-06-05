using System;
using System.Collections.Generic;
using System.Linq;

namespace Day40Concepts
{
    public class AnyOperatorExamples
    {
        public void AnyOperatorBasicExample()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4 };

            var isValid = numbers.Any();

            Console.WriteLine(isValid);
        }

        public void AnyOperatorCheckStudentMarksWithMethodSyntax()
        {
            Student[] students = StudentDetails.GetStudents();

            var methodSyntax = students.Any(student => student.marks > 85);

            Console.WriteLine(methodSyntax);
        }

        public void AnyOperatorCheckStudentMarksWithLinqQuery()
        {
            Student[] students = StudentDetails.GetStudents();

            var querySyntax = (from student in students
                               select student).Any(student => student.marks > 85);

            Console.WriteLine(querySyntax);
        }

        public void CheckStudentMarksUsingAnyOperatorWithMethodSyntax()
        {
            Student[] students = StudentDetails.GetSubjects();

            var methodSyntax = students.Where(student => student.subject.Any(marks => marks.subjectMarks > 94)).Select(student => student.name).ToList();

            foreach (var studentName in methodSyntax)
            {
                Console.WriteLine(studentName);
            }
        }

        public void CheckStudentMarksUsingAnyOperatorWithLinqQuery()
        {
            Student[] students = StudentDetails.GetSubjects();
            var querySyntax = (from student in students
                               where student.subject.Any(marks => marks.subjectMarks > 94)
                               select student.name).ToList();
            foreach (var studentName in querySyntax)
            {
                Console.WriteLine(studentName);
            }
        }
    }
}
