using System;

namespace Day30Concepts
{
    public class ForEachExamples
    {
        public void PrintNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void PrintLongNumbers()
        {
            long[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (long number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void PrintDoubleNumbers()
        {
            double[] numbers = { 1.2, 2.35, 3.47, 4.52, 5.42, 6.98, 7.86, 8.42, 9.12, 10.19 };

            foreach (double number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void PrintFloatNumbers()
        {
            float[] numbers = { 1.2F, 2.35F, 3.47F, 4.52F, 5.42F, 6.98F, 7.86F, 8.42F };

            foreach (float number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void PrintDecimalNumbers()
        {
            decimal[] numbers = { 1.2M, 2.35M, 3.47M, 4.52M, 5.42M, 6.98M, 7.86M };

            foreach (decimal number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void PrintWords()
        {
            string[] names = { "Ram", "Shyam", "Jeny", "Prince" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public void PrintCharacters()
        {
            char[] letters = { 'A', 'D', 'S', 'L' };

            foreach (char letter in letters)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
