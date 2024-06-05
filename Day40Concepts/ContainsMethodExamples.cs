using System;
using System.Collections.Generic;
using System.Linq;

namespace Day40Concepts
{
    public class ContainsMethodExamples
    {
        public void ContainsBasicExample()
        {
            List<string> names = new List<string>() {"Kim", "John", "Simon"};
            
            var isExist = names.Contains("Kim");
            
            Console.WriteLine(isExist);
        }

        public void ContainsBasicExample2() 
        {
            Student[]  students = StudentDetails.GetStudents();
            var student = students[0];
            
            var isExist = students.Contains(student);
            Console.WriteLine(isExist);
        }

        public void ContainsMethodSyntaxExample()
        {
            List<Student> students = StudentDetails.GetStudentsList();

            var comparer = new StudentComparer();

            var methodSyntax = students.Contains(new Student {id =1, name = "Kim"}, comparer);

            Console.WriteLine(methodSyntax);
        }

        public void ContainsLinqQueryExample()
        {
            List<Student> students = StudentDetails.GetStudentsList();
            
            var comparer = new StudentComparer();

            var querySyntax = (from student in students
                               select student).Contains(new Student { id = 1, name = "Kim" }, comparer);
            
            Console.WriteLine(querySyntax);
        }
    }
}
