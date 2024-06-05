using System;
using System.Collections.Generic;
using System.Linq;

namespace Day39Concepts
{
    public class ExtensionMethodExamples
    {
        public string ChangingFirstLetterCase(string inputWord)
        {
            if (inputWord.Length > 0)
            {
                char[] characters = inputWord.ToCharArray();

                characters[0] = char.IsUpper(characters[0]) ?
                    char.ToLower(characters[0]) : char.ToUpper(characters[0]);

                return new string(characters);
            }

            return inputWord;
        }

        public void PrintIntegerNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> evenNumbers = Enumerable.Where(numbers, number => number % 2 == 0);

            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public void PrintDoubleNumbers()
        {
            List<double> numbers = new List<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<double> doubleNumbers = Enumerable.Where(numbers, number => number > 2);

            foreach (double number in doubleNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public void PrintFloatNumbers()
        {
            List<float> numbers = new List<float> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<float> floatNumbers = Enumerable.Where(numbers, number => number < 5);

            foreach (float number in floatNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public void PrintDecimalNumbers()
        {
            List<decimal> numbers = new List<decimal> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<decimal> decimalNumbers = Enumerable.Where(numbers, number => number > 9);

            foreach (decimal number in decimalNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public void PrintWords()
        {
            List<string> words = new List<string> { "Ram", "Shyam", "Kiran", "Ravi", "Mark" };

            IEnumerable<string> wordString = Enumerable.Where(words, word => word.Length > 3);

            foreach (string word in wordString)
            {
                Console.WriteLine(word);
            }
        }
    }
}
