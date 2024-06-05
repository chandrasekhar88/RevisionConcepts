using System.Collections.Generic;
using System.Linq;

namespace Day40Concepts
{
    public class SingleVsSingleOrDefaultExamples
    {
        public void SingleOrSingleDefaultExample() 
        {
            List<int> numbers = new List<int>();
            var methodSyntax = numbers.Single();
            var methodSyntax1 = numbers.SingleOrDefault();            
        }

        /// <summary>
        /// // more than one elements cannot handle by Single/SingleOrDefault
        /// </summary>
        public void SingleOrSingleDefaultExample1()
        {
            List<int> numbers = new List<int> { 1, 2, 3 };            
            
            var methodSyntax = numbers.Where(number => number > 1).Single();
            var methodSyntax1 = numbers.Where(number => number > 1).SingleOrDefault();
        }


    }
}
