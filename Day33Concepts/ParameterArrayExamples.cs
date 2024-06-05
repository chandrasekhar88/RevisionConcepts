using System;

namespace Day33Concepts
{
    public class ParameterArrayExamples
    {
        public void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
        {
            int  result = firstNumber + secondNumber;

            if (restOfNumbers != null)
            {
                foreach (int number in restOfNumbers)
                {
                    result += number;
                }
            }

            Console.WriteLine(" Sum = {0} ", result);
        }

        public void AddDoubleNumbers(double number1, double number2, params object[] restOfNumbers)
        {
            double result = number1 + number2;

            if (restOfNumbers != null)
            {
                foreach (double number in restOfNumbers)
                {
                    result += number;
                }
            }

            Console.WriteLine(" Sum = {0} ", result);
        }

        public void AddLongNumbers(long number1, long number2, params object[] restOfNumbers)
        {
            long result = number1 + number2;

            if (restOfNumbers != null)
            {
                foreach (long number in restOfNumbers)
                {
                    result += number;
                }
            }

            Console.WriteLine(" Sum = {0} ", result);
        }

        public void AddFloatNumbers(float number1, float number2, params object[] restOfNumbers)
        {
            float result = number1 + number2;

            if (restOfNumbers != null)
            {
                foreach (float number in restOfNumbers)
                {
                    result += number;
                }
            }

            Console.WriteLine(" Sum = {0} ", result);
        }

        public void AddDecimalNumbers(decimal number1, decimal number2, params object[] restOfNumbers)
        {
            decimal result = number1 + number2;

            if (restOfNumbers != null)
            {
                foreach (decimal number in restOfNumbers)
                {
                    result += number;
                }
            }

            Console.WriteLine(" Sum = {0} ", result);
        }

        public void AddTwoStrings(string firstWord, string secondWord, params object[] restOfWords)
        {
            string result = firstWord + secondWord;

            if (restOfWords != null)
            {
                foreach (string number in restOfWords)
                {
                    result += number;
                }
            }

            Console.WriteLine(" Words = {0} ", result);
        }

        public void AddTwoCharacters(char firstCharacter, char secondCharacter, params object[] restOfCharacters)
        {
            string result = firstCharacter.ToString() + secondCharacter.ToString();

            if (restOfCharacters != null)
            {
                foreach (char character in restOfCharacters)
                {
                    result += character;
                }
            }

            Console.WriteLine(" Characters = {0} ", result);
        }
    }
}
