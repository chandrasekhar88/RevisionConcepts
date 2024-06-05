using System;
using System.Collections.Generic;
using System.Linq;

namespace Day40Concepts
{
    public class LastVsLastOrDefaultExamples
    {
        public void LastMethodExample()
        {
            List<int> numbers = DataSource.NumbersList();
            var methodSyntax = numbers.Last();
            Console.WriteLine(methodSyntax);
        }

        /// <summary>
        /// //var methodSyntax = numbers.Where(number => number >9).Last();
        /// </summary>
        public void LastVsLastOdDefaultMethodExample()
        {
            List<int> numbers = DataSource.NumbersList();
            
            var methodSyntax1 = numbers.Last(number => number > 1);
            Console.WriteLine(methodSyntax1);

            var methodSyntax2 = numbers.LastOrDefault(number => number > 10);
            Console.WriteLine(methodSyntax2);
        }

        /// <summary>
        /// LastOrDefault can handles exception
        /// </summary>
        public void LastVsLastOrDefaultMixedQuery()
        {
            List<int> numbers = DataSource.NumbersList();

            var mixedSyntax = (from number in numbers
                               where number > 9
                               select number).Last();

            var mixedSyntax1 = (from number in numbers 
                                where number > 10
                                select number).LastOrDefault();
        }
    }
}
