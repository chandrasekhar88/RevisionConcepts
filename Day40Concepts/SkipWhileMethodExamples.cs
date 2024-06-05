using System;
using System.Collections.Generic;
using System.Linq;


namespace Day40Concepts
{
    public class SkipWhileMethodExamples
    {
        public void SkipWhileExampleUsingMethodSyntax()
        {
            int[] numbers = DataSource.NumbersMethod1();

            var methodSyntax = numbers.SkipWhile(number => number < 6).ToArray();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void SkipWhileExampleUsingMixedSyntax()
        {
            int[] numbers = DataSource.NumbersMethod1();

            var mixedSyntax = (from number in numbers select number).SkipWhile(number => number < 6).ToList();

            foreach (var number in mixedSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void SkipWhileExampleWithMethodSyntax()
        {
            List<string> names = DataSource.NamesMethod();

            var methodSyntax = names.SkipWhile(name => name.Length < 4).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }

        public void SkipWhileComplexTypeUsingMethodSyntax()
        {
            List<string> names = DataSource.NamesMethod();

            var methodSyntax = names.SkipWhile((value, index) => value.Length > index).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }
        }
    }
}
