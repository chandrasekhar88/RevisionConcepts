using System;

namespace Day30Concepts
{
    public class ForLoopExamples
    {
        public void PrintNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" " + i);
            }
        }

        public void PrintLongNumbers()
        {
            for (long i = 0; i < 10L; i++)
            {
                Console.Write(" " + i);
            }
        }

        public void PrintDoubleNumbers()
        {
            for (double i = 0; i < 10.50D; i++)
            {
                Console.Write(" " + i);
            }
        }

        public void PrintFloatNumbers()
        {
            for (float i = 0; i < 10.50F; i++)
            {
                Console.Write(" " + i);
            }
        }

        public void PrintDecimalNumbers()
        {
            for (decimal i = 0; i < 10.50M; i++)
            {
                Console.Write(" " + i);
            }
        }

        public void PrintDateTimeRange()
        {
            DateTime startDate = new DateTime(2023, 11, 1);
            DateTime endDate = new DateTime(2023, 11, 11);

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                Console.WriteLine(date + " ");
            }
        }
    }
}
