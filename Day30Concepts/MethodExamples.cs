using System;

namespace Day30Concepts
{
    public class MethodExamples
    {
        public void InstanceMethodExample()
        {
            int startNumber = 0;

            while (startNumber <= 20)
            {
                Console.WriteLine(startNumber);
                startNumber = startNumber + 2;
            }
        }

        public void InstanceMethodLongExample()
        {
            long startNumber = 0;

            while (startNumber <= 20)
            {
                Console.WriteLine(startNumber);
                startNumber = startNumber + 2;
            }
        }

        public void InstanceMethodDoubleExample()
        {
            double startNumber = 0;

            while (startNumber <= 20)
            {
                Console.WriteLine(startNumber);
                startNumber = startNumber + 2;
            }
        }

        public void InstanceMethodFloatExample()
        {
            float startNumber = 0;

            while (startNumber <= 20)
            {
                Console.WriteLine(startNumber);
                startNumber = startNumber + 2;
            }
        }

        public void InstanceMethodDecimalExample()
        {
            decimal startNumber = 0;

            while (startNumber <= 20)
            {
                Console.WriteLine(startNumber);
                startNumber = startNumber + 2;
            }
        }

        public void InstanceMethodDateTimeExample()
        {
            DateTime startDate = new DateTime(2024,1,1);
            DateTime endDate = new DateTime(2024,1,10);
            DateTime date = startDate.AddDays(1);

            while (date <= endDate)
            {
                Console.WriteLine(date);
                date = startDate.AddDays(1);
            }
        }

    }
}
