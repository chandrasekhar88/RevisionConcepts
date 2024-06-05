using System;
using System.Linq;

namespace Day34Concepts
{
    public class ArrayExamples
    {
        public void PrintArrayNumbersUsingForLoop()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Print numbers Using For Loop");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public void PrintPlanetNamesUsingForEach()
        {
            string[] planets = {"Mercury", "Venus", "Earth", "Mars","Jupitar", "Saturn","Uranus", "Neptune" };

            Console.WriteLine("Planet names using for each Loop \n");

            foreach (var planet in planets)
            {
                Console.WriteLine(planet);
            }
        }

        public void ModifyPlanetName()
        {
            string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupitar", "Saturn", "Uranus", "Neptune" };
            Console.WriteLine("Type the Planet Number you want to modify ");
            Console.WriteLine("1 = Mercury");
            Console.WriteLine("2 = Venus");
            Console.WriteLine("3 = Earth");

            int planetNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(planets[planetNumber - 1]+ "\n" );
            planets[0] = "Mercury Planet";

            foreach (var planet in planets)
            {
                Console.WriteLine(planet);
            }
        }

        public void PrintMonthNamesUsingReverseMethod()
        {
            string[] months = { "January", "February", "March", "April" };
            Array.Reverse(months);
            foreach (var month in months)
            {
                Console.WriteLine(month);
            }
        }

        public void ComparingTwoArrays()
        {
            string[] daysOfWeek1 =
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };

            string[] daysOfWeek2 =
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };

            bool isEqual = daysOfWeek1 == daysOfWeek2;
            Console.WriteLine("is daysOfWeek1 == daysOfWeek2 ? = " + isEqual);

            bool isArrayEqual = true;

            if (daysOfWeek1.Length == daysOfWeek2.Length)
            {
                for (int i = 0; i < daysOfWeek2.Length; i++)
                {
                    if (daysOfWeek1[i] == daysOfWeek2[i])
                    {
                        isArrayEqual = false;
                    }
                }
            }
            else
            {
                isArrayEqual = false;
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("Compare using for loop - each item of Two arrays");

            if (isArrayEqual)
            {
                Console.WriteLine("\n Both Arrays are Equal");
            }
            else
            {
                Console.WriteLine("\n Both Arrays are not Equal");
            }

            Console.WriteLine("--------------------------");

            // Comparing two arrays using SequenceEqual Method
            bool isSequenceEqual = daysOfWeek1.SequenceEqual(daysOfWeek2);

            Console.WriteLine($"\n Is Sequence Equal : {isSequenceEqual}");
        }
    }
}
