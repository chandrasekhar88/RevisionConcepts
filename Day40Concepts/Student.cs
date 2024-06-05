using System;
using System.Collections.Generic;

namespace Day40Concepts
{
    public class Student : IEquatable<Student>
    {
        public int id { get; set; }
        public string name { get; set; }
        public int marks { get; set; }

        public List<Subject> subject { get; set; }

        public bool Equals(Student other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this,other))
            {
                return true;
            }

            return id.Equals(other.id) && name.Equals(other.name);
        }

        public override int GetHashCode()
        {
            int idHashCode = id.GetHashCode();
            int nameHashCode = name.GetHashCode();

            return idHashCode ^ nameHashCode;
        }        
    }

    public class Subject
    {
        public string subjectName { get; set; }
        public int subjectMarks { get; set; }
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student reference1, Student reference2)
        {
            if (object.ReferenceEquals(reference1,reference2))
            {
                return true;
            }

            if (object.ReferenceEquals(reference1,null) || object.ReferenceEquals(reference2,null))
            {
                return false;
            }
            return reference1.id == reference2.id && reference1.name == reference2.name;
        }

        public int GetHashCode(Student student)
        {
            if (Object.ReferenceEquals(student , null))
            {
                return 0; 
            }

            int idHashCode = student.id.GetHashCode();
            int nameHashCode = student.name == null ? 0 : student.name.GetHashCode();
            
            return idHashCode ^ nameHashCode;
        }
    }
}
