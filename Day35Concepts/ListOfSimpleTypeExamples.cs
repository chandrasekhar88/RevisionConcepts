using System;
using System.Collections.Generic;

namespace Day35Concepts
{
    public class ListOfSimpleTypeExamples
    {
        public void SortAndReverseIntegers()
        {
            List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Console.WriteLine("Numbers before Sorting");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Numbers after Sorting");

            numbers.Sort();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Numbers in Descending Order");

            numbers.Reverse();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void SortAndReverseStrings()
        {
            List<string> alphabets = new List<string>() { "A", "G", "F", "B", "E", "D", "C" };

            Console.WriteLine("Alphabets before Sorting");

            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            Console.WriteLine("Alphabets After Sorting");

            alphabets.Sort();

            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            Console.WriteLine("Alphabets in Descending order");

            alphabets.Reverse();

            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }
        }

        public void SortAndReverseDouble()
        {
            List<double> numbers = new List<double>() { 1.0, 2.8, 7.6, 5.7, 2.5 };

            Console.WriteLine("Double Numbers before Sorting");

            foreach (double number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Double Numbers after Sorting");

            numbers.Sort();

            foreach (double number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Double Numbers in Descending Order");

            numbers.Reverse();

            foreach (double number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void SortAndReverseFloat()
        {
            List<float> numbers = new List<float>() { 1.0F, 2.8F, 7.6F, 5.7F, 2.5F };

            Console.WriteLine("Double Numbers before Sorting");

            foreach (float number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Double Numbers after Sorting");

            numbers.Sort();

            foreach (float number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Double Numbers in Descending Order");

            numbers.Reverse();

            foreach (float number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void SortAndReverseDecimals()
        {
            List<decimal> numbers = new List<decimal>() { 1.0M, 2.8M, 7.6M, 5.7M, 2.5M };

            Console.WriteLine("Double Numbers before Sorting");

            foreach (decimal number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Double Numbers after Sorting");

            numbers.Sort();

            foreach (decimal number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Double Numbers in Descending Order");

            numbers.Reverse();

            foreach (decimal number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void SortAndReverseCharacters()
        {
            List<char> alphabets = new List<char>() { 'A', 'D', 'F','S', 'L' };

            Console.WriteLine("Alphabets before Sorting");

            foreach (char alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            Console.WriteLine("Alphabets After Sorting");

            alphabets.Sort();

            foreach (char alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            Console.WriteLine("Alphabets in Descending order");

            alphabets.Reverse();

            foreach (char alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }
        }
    }
}
