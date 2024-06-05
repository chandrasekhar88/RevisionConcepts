using System;
using System.Collections.Generic;

namespace Day40Concepts
{
    public class DataSource
    {
        public static List<int> Numbers()
        {
            List<int> numbers = new List<int>() { 1, 2, 2, 3, 1, 4, 5, 3, 4, 5, 3, 4 };
            
            return numbers;
        }

        public static List<string> Alphabets1()
        {
            List<string> alphabets1 = new List<string>() { "A", "B", "C", "D" };

            return alphabets1;
        }

        public static List<string> Alphabets2()
        {
            List<string> alphabets2 = new List<string>() { "C", "D", "E", "F" };

            return alphabets2;
        }

        public static int[] NumbersMethod()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            return numbers;
        }

        public static int[] NumbersMethod1()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 8, 9, 10, 3, 4, 5 };

            return numbers;
        }

        public static List<int> NumbersList()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            return numbers;
        }

        public static List<string> NamesMethod()
        {
            List<string> words = new List<string> { "Tom", "Harry", "Adam", "Sac", "Ponting" };

            return words;
        }
    }
}
