using System;
using System.Linq;

namespace Day40Concepts
{
    public class TakeMethodExamples
    {
        public void TakeExampleMethodSyntax()
        {
            int[] numbers = DataSource.NumbersMethod();

            var methodSyntax = numbers.Take(5).ToArray();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void TakeExampleLinqQuery()
        {
            int[] numbers = DataSource.NumbersMethod();

            /*var querySyntax = (from number in numbers
                              select number).Take(5).ToList();*/

            var querySyntax = (from number in numbers // Applying filters
                               where number > 3
                               select number).Take(5).ToList();

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void FilterApplyingOnTakeUsingMethodSyntax()
        {
            int[] numbers = DataSource.NumbersMethod();

            var methodSyntax = numbers.Where(number => number > 3).Take(5).ToArray();

            //based on the Take method position before Where method we can see the difference of the data
            //var methodSyntax1 = numbers.Take(5).Where(number => number > 3).ToArray();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }
    }
}
