using System;
using System.Collections.Generic;
using System.Linq;

namespace Day40Concepts
{
    public class SkipMethodExamples
    {
        public void SkipMethodExample()
        {
            int[] numbers = DataSource.NumbersMethod1();

            var methodSyntax = numbers.Skip(3).ToArray();
            //var methodSyntax1 = numbers.Where(number => number > 3).Skip(3).ToArray();
            //var methodSyntax2 = numbers.Skip(3).Where(number => number > 3).ToArray();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void SkipMethodExample2()
        {
            List<string> names = DataSource.NamesMethod();

            var mixedSyntax = (from name in names select name).Skip(3).ToList();

            foreach (var name in mixedSyntax)
            {
                Console.WriteLine(name);
            }
        }
    }
}
