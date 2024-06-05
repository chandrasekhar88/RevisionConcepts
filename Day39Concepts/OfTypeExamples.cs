using System;
using System.Linq;

namespace Day39Concepts
{
    public class OfTypeExamples
    {
        public void OfTypeExampleInLinqQuery()
        {
            DataSource data = new DataSource();
            var dataSource = data.ObjectMethod();

            var querySyntax = (from word in dataSource
                               where word is string
                               select word).ToList();

            foreach (var word in querySyntax)
            {
                Console.WriteLine(word);
            }
        }

        public void OfTypeExampleInMethodSyntax()
        {
            DataSource data = new DataSource();
            var dataSource = data.ObjectMethod();

            var methodSyntax = dataSource.OfType<string>().ToList();
            var methodSyntax1 = dataSource.OfType<string>().Where(word => word.Length >3).ToList();

            foreach (var word in methodSyntax)
            {
                Console.WriteLine(word);
            }
        }
        public void OfTypeWithWhereInMethodSyntax()
        {
            DataSource data = new DataSource();
            var dataSource = data.ObjectMethod();

            var methodSyntax = dataSource.OfType<string>().Where(word => word.Length > 3).ToList();

            foreach (var word in methodSyntax)
            {
                Console.WriteLine(word);
            }
        }
    }
}
