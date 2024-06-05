using System;
using System.Collections.Generic;
using System.Linq;

namespace Day40Concepts
{
    public class TakeWhileMethodExamples
    {
        public void TakeWhileExampleMethodSyntax()
        {
            int[] numbers = DataSource.NumbersMethod1();

            var methodSyntax = numbers.TakeWhile(number => number < 7).ToList();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void TakeWhileExampleMethodSyntax1()
        {
            List<string> names = DataSource.NamesMethod();

            var methodSyntax = names.TakeWhile((name, index) => name.Length >index).ToList();

            foreach (var name in methodSyntax)
            {
                Console.WriteLine(name);
            }

        }

        public void TakeWhileExampleLinqQuery()
        {
            int[] numbers = DataSource.NumbersMethod1();

            var querySyntax = (from number in numbers
                               select number).TakeWhile(number => number < 7).ToList();

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void TakeWhileExampleLinqQuery1()
        {
            List<string> names = DataSource.NamesMethod();

            var querySyntax = (from name in names
                               select name).TakeWhile((name, index) => name.Length > index).ToList();

            foreach (var name in querySyntax)
            {
                Console.WriteLine(name);
            }

        }
    }
}
