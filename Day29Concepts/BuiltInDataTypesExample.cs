using System;

namespace Day29Concepts
{
    public class BuiltInDataTypesExample
    {
        public void DataTypes()
        {
            sbyte byteNumber = 1;
            short shortNumber = 24;
            int number = 123;
            long longNumber = 2500L;
            float floatNumber = 23.45F;
            double doubleNumber = 45.34;
            decimal decimalNumber = 76.38M;
            bool isValid = true;
            char letter = 'A';
            string name = "Savar Technologies";
            string password = "hello$#2456%&^*";
            DateTime dateTime = DateTime.Now;
            
            int maxValueOfInt = 2147483647;
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine($"Size of long DataType is {sizeof(long)}");
            Console.WriteLine($"Min Value of long is {long.MinValue}");
            Console.WriteLine($"Max Value of long is {long.MaxValue}\n");

            Console.WriteLine($"Size of float DataType is {sizeof(float)}");
            Console.WriteLine($"Min Value of float is {float.MinValue}");
            Console.WriteLine($"Max Value of float is {float.MaxValue}\n");

            Console.WriteLine($"Size of double DataType is {sizeof(double)}");
            Console.WriteLine($"Min Value of double is {double.MinValue}");
            Console.WriteLine($"Max Value of double is {double.MaxValue}\n");

            Console.WriteLine($"Size of decimal DataType is {sizeof(decimal)}");
            Console.WriteLine($"Min Value of decimal is {decimal.MinValue}");
            Console.WriteLine($"Max Value of decimal is {decimal.MaxValue}\n");

            Console.WriteLine($"Min Value of Date Time is = {DateTime.MinValue}");
            Console.WriteLine($"Max Value of Date Time is = {DateTime.MaxValue}");
        }
    }
}
