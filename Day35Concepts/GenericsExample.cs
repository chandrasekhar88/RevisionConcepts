using System;

namespace Day35Concepts
{
    public class GenericsExample
    {
        //Without Generics
        public static bool IsEqual(object value1, object value2)
        {
            return value1 == value2;
        }

        public void ComparingTwoStrings()
        {
            bool isEqual = IsEqual("DOTNET","DOTNET");

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else 
            {
                Console.WriteLine("Not Equal"); 
            }
        }

        // Using Generics
        public bool AreEqual<Type>(Type value1, Type value2)
        {
            return value1.Equals(value2);
        }

        public void ComparingTwoCharacters()
        {
            bool isEqual = AreEqual<char>('A','A');

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        public void ComparingTwoWords()
        {
            bool isEqual = AreEqual<string>("CSHARP", "CSHARP");

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        public void ComparingTwoIntegers()
        {
            bool isEqual = AreEqual<int>(10,10);

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        public void ComparingTwoDoubles()
        {
            bool isEqual = AreEqual<double>(10D, 10D);

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        public void ComparingTwoFloats()
        {
            bool isEqual = AreEqual<float>(10F, 10F);

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        public void ComparingTwoDecimals()
        {
            bool isEqual = AreEqual<decimal>(10M, 10M);

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        public void ComparingTwoDates()
        {
            bool isEqual = AreEqual<DateTime>(new DateTime(2024,05,21), new DateTime(2024, 05, 21));

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
