using System;

namespace Day29Concepts
{
    public class ConsoleClassIntroduction
    {
        public void WriteLineAndReadLine()
        {
            Console.WriteLine("Enter First Name ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}", firstName, lastName);
        }

        public void WriteLineAndWrite()
        {
            Console.WriteLine("Savar");
            Console.WriteLine("Technologies");
            Console.WriteLine("------------");

            Console.Write("Savar");
            Console.WriteLine("Technologies");
        }

        public void ReadLineAndRead()
        {
            Console.WriteLine("Please enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Entered Name is " + name);

            Console.WriteLine("Enter the Character");
            int value = Console.Read();
            Console.WriteLine(value);
        }

        public void Concatenation()
        {
            Console.WriteLine("Please enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter Last Name");
            string lastName = Console.ReadLine();

            //Concatenation using by '+' Operator
            Console.WriteLine("Provided First Name" + firstName + " and Last Name " + lastName);
            // Placeholder syntax
            Console.WriteLine("Provided First Name {0} and Last Name {1}", firstName, lastName);
            // Interpolation
            Console.WriteLine($"Provided First Name {firstName} and Last Name {lastName}");
        }
    }
}
