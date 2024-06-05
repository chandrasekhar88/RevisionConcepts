using System;
using System.Collections.Generic;
using System.Linq;

namespace Day39Concepts
{
    public class LinqExamples
    {
        public void PrintNumbersUsingQuerySyntax()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var querySyntax = from number in numbers
                              select number;

            foreach (int number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void PrintDoubleNumbersUsingQuerySyntax()
        {
            List<double> numbers = new List<double>() { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0 };

            var querySyntax = from number in numbers
                              select number;

            foreach (double number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void PrintFloatNumbersUsingQuerySyntax()
        {
            List<float> numbers = new List<float>() { 1.0F, 2.0F, 3.0F, 4.0F, 5.0F, 6.0F, 7.0F, 8.0F, 9.0F, 10.0F };

            var querySyntax = from number in numbers
                              select number;

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void PrintDecimalNumbersUsingQuerySyntax()
        {
            List<decimal> numbers = new List<decimal>() { 1.0M, 2.0M, 3.0M, 4.0M, 5.0M, 6.0M, 7.0M, 8.0M, 9.0M, 10.0M };

            var querySyntax = from number in numbers
                              select number;

            foreach (decimal number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void PrintDatesUsingQuerySyntax()
        {
            List<DateTime> numbers = new List<DateTime>() { };

            var querySyntax = from number in numbers
                              select number;

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

    }
}
