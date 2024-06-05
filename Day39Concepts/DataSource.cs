using System;
using System.Collections.Generic;

namespace Day39Concepts
{
    public class DataSource
    {
        public List<int> NumbersMethod()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            return numbers;
        }

        public List<int> NumbersMethod2()
        {
            var numbers = new List<int> { 10, 21, 63, 14, 35, 86, 27, 8, 39, 100 };

            return numbers;
        }

        public int[] NumbersMethod3()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return numbers;
        }

        public List<string> NamesMethod()
        {
            var words = new List<string> { "Tom", "Harry", "Adam", "Sachin", "Ponting" };
            return words;
        }

        public List<object> ObjectMethod()
        {
            var dataSource = new List<object>() { "Adam", "Harry", "Kim", "John", 1, 2, 3, 4, 5 };
            return dataSource;
        }
    }
}
