using System;
using System.Collections.Generic;

namespace Day39Concepts.EmployeeProperties
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }

    public class EmployeeType : Employee
    {
        public List<string> programming { get; set; }
        public List<TechnologySkills> programmingSkills { get; set; }

    }

    public class TechnologySkills
    {
        public string technology { get; set; }
    }
}
