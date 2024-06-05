using System;
using System.Collections.Generic;
using System.Linq;

namespace Day40Concepts
{
    public class FirstVsFirstOrDefaultExamples
    {
        public void FirstMethodExample()
        {
            int[] numbers = DataSource.NumbersMethod();
            var methodSyntax = numbers.First();
            Console.WriteLine(methodSyntax);
        }

        public void FirstVsFirstOrDefault1()
        {
            int[] numbers = DataSource.NumbersMethod1();

            var methodSyntax = numbers.First(number => number > 10);
            Console.WriteLine(methodSyntax);

            var methodSyntax1 = numbers.Where(number => number > 10).FirstOrDefault(); // it can handles the exception
            Console.WriteLine(methodSyntax1);
        }

        public void FirstVsFirstOrDefault2()
        {
            List<User> users = UserDetails.GetUsers();

            var methodSyntax = users.First(user => user.userName == "admin" && user.password == "admin");

            var mixedSyntax = (from user in users
                               select user).FirstOrDefault(user => user.userName == "admin" && user.password == "admin");
            
            Console.WriteLine($"UserName = {mixedSyntax.userName} and Password = { mixedSyntax.password}");
        }
    }
}
