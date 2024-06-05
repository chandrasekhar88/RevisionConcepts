using System;

namespace Day32Concepts
{
    public class MethodOverLoadingExamples
    {
        public void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Sum = {0} ", firstNumber + secondNumber);
        }

        public void Add(long firstNumber, long secondNumber)
        {
            Console.WriteLine("Sum = {0} ", firstNumber + secondNumber);
        }

        public void Add(double firstNumber, double secondNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber);
        }

        public void Add(float firstNumber, float secondNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber);
        }

        public void Add(decimal firstNumber, decimal secondNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber);
        }

        public void Add(int firstNumber, double secondNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber);
        }

        public void Add(double number1, float number2)
        {

            Console.WriteLine("Sum = {0}", number1 + number2);
        }
        
        public void Add(int number1, double number2, float number3)
        {
            
            Console.WriteLine("Sum = {0}", number1 + number2 + number3);
        }       

        public void Concatenation(string firstName, string lastName)
        {
            Console.WriteLine("FullName = {0} {1}", firstName,lastName);
        }

        public void Concatenation(string firstName, string lastName, char character)
        {
            Console.WriteLine("FullName = {0} {1} - {2}", firstName, lastName,character);
        }

        public void Concatenation(string firstName, string lastName, char character, DateTime date)
        {
            Console.WriteLine("FullName = {0} {1} - {2} - {3} ", firstName, lastName, character,date);
        }

    }
}
