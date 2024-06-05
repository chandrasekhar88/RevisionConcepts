using System;

namespace Day33Concepts
{
    public class ConstantAndReadOnlyExample
    {
        const int number1 = 100;
        readonly int number2 = 30;

        public void ConstantExample()
        {
            Console.WriteLine(number1);
        }

        public ConstantAndReadOnlyExample()
        {
            number2 = 10;
            Console.WriteLine(number2);
        }
    }
}
