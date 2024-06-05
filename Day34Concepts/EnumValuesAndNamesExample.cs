using System;

namespace Day34Concepts.EnumValuesAndNamesExample
{
    public class Employee
    {
        public enum Gender
        {
            unknown,
            male,
            female
        }

        public void PrintMethod()
        {
            int[] values = (int[])Enum.GetValues(typeof(Gender));

            foreach (int value in values)
            {
                Console.WriteLine(value);
            }

            string[] names = Enum.GetNames(typeof(Gender));

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }

    public class Vehicles
    {
        public enum Type
        {
            train,
            bus,
            plane,
            ship
        }

        public void PrintMethod()
        {
            int[] values = (int[])Enum.GetValues(typeof(Type));

            foreach (int value in values)
            {
                Console.WriteLine(value);
            }

            string[] names = Enum.GetNames(typeof(Type));

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }

    public class Colors
    {
        public enum Color
        {
            Red,
            Green,
            Orange,
            Yellow
        }

        public void PrintMethod()
        {
            int[] values = (int[])Enum.GetValues(typeof(Color));

            foreach (double value in values)
            {
                Console.WriteLine(value);
            }

            string[] names = Enum.GetNames(typeof(Color));

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}