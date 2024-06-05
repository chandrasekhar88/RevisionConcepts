using System;
using System.Linq;

namespace Day40Concepts
{
    public class AllOperatorExamples
    {
        public void AllOperatorInMethodSyntax()
        {
            Student[] students = StudentDetails.GetStudents();

            var methodSyntax = students.All(student => student.marks > 70);

            Console.WriteLine("All Students got above 70 Marks ?  " + methodSyntax);
        }

        public void AllOperatorInLinqQuery()
        {
            Student[] students = StudentDetails.GetStudents();

            var querySyntax = (from student in students
                               select student).All(student => student.marks > 70);

            Console.WriteLine("All Students got above 70 Marks ?  " + querySyntax);
        }

        public void StudentRecordsUsingAllOperatorInMethodSyntax()
        {
            Student[] students = StudentDetails.GetSubjects();

            var methodSyntax = students.Where(student => student.subject.All(marks => marks.subjectMarks > 70)).
                Select(student => student).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine(student.name);
            }
        }

        public void StudentRecordsUsingAllOperatorInLinqQuery()
        {
            Student[] students = StudentDetails.GetSubjects();

            var querySyntax = (from student in students
                               where student.subject.All(marks => marks.subjectMarks > 70)
                               select student).ToList();

            foreach (var student in querySyntax)
            {
                Console.WriteLine(student.name);
            }
        }
    }
}
