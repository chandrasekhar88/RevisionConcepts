using System;
using System.Collections.Generic;

namespace Day40Concepts
{
    public class StudentDetails
    {
        public static Student[] GetStudents()
        {
            Student[] students = {
                new Student {name = "Kim", marks = 90},
                new Student {name = "John", marks = 80},
                new Student {name = "Lee", marks = 75}
            };

            return students;
        }

        public static List<Student> GetStudentsList()
        {
            List<Student> students = new List<Student>()
            {
                new Student {id = 1 , name = "Kim", marks = 90 },
                new Student {id = 2 , name = "John", marks = 80 },
                new Student {id = 3 , name = "Lee", marks = 77 },
                new Student {id = 4 , name = "Lee", marks = 65 },
                new Student {id = 3 , name = "Lee", marks = 77 },
                new Student {id = 1 , name = "Kim", marks = 90 }
            };
            return students;
        }

        public static Student[] GetSubjects()
        {
            Student[] students =
            {
                new Student {name = "Kim", marks = 90,
                subject = new List<Subject>(){
                    new Subject {subjectName = "Math", subjectMarks = 75 },
                    new Subject {subjectName = "English", subjectMarks = 80 },
                    new Subject {subjectName = "Art", subjectMarks = 86 },
                    new Subject {subjectName = "History", subjectMarks = 90 }
                } },

                new Student {name = "John", marks = 80,
                subject = new List<Subject>(){
                    new Subject {subjectName = " Math", subjectMarks = 89},
                    new Subject {subjectName = " English", subjectMarks = 91},
                    new Subject {subjectName = " Art", subjectMarks = 90},
                    new Subject {subjectName = " History", subjectMarks = 91}
                } },

                new Student {name = "Lee", marks = 75,
                subject = new List<Subject>(){
                    new Subject {subjectName = " Math", subjectMarks = 75},
                    new Subject {subjectName = " English", subjectMarks = 80},
                    new Subject {subjectName = " Art", subjectMarks = 61},
                    new Subject {subjectName = " History", subjectMarks = 95}
                } },


            };

            return students;
        }

        public static List<Student> GetStudentsName1()
        {
            List<Student> students1 = new List<Student>()
            {
                new Student {id = 1 , name = "Kim"},
                new Student {id = 2 , name = "John" },
                new Student {id = 3 , name = "Lee"},
                new Student {id = 4 , name = "Mark"},
            };

            return students1;
        }

        public static List<Student> GetStudentsName2()
        {
            List<Student> students2 = new List<Student>()
            {
                new Student {id = 1 , name = "Kim"},
                new Student {id = 2 , name = "John" },
                new Student {id = 5 , name = "Peter"},
                new Student {id = 6 , name = "Stephen"},
            };

            return students2;
        }
    }
}
