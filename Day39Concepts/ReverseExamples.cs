using System;
using System.Linq;

namespace Day39Concepts
{
    public class ReverseExamples
    {
        public void ReverseWithMethodSyntax()
        {
            DataSource dataSource = new DataSource();
            var numbers = dataSource.NumbersMethod3();

            var methodSyntax = numbers.Reverse();

            foreach (var number in methodSyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void ReverseWithMixedSyntax()
        {
            DataSource dataSource = new DataSource();
            var numbers = dataSource.NumbersMethod3();

            var querySyntax = (from number in numbers
                              select number).Reverse();

            foreach (var number in querySyntax)
            {
                Console.WriteLine(number);
            }
        }

        public void ReverseWithMultipleQueries()
        {
            DataSource dataSource = new DataSource();
            var names = dataSource.NamesMethod();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("====================");
            
            var reverse = names.AsQueryable().Reverse(); 

            foreach (var name in reverse)
            {
                Console.WriteLine(name);
            }
        }
    }
}
