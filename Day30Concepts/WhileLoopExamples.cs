using System;

namespace Day30Concepts
{
    internal class WhileLoopExamples
    {
        public void WhileLoopExample()
        {
            Console.WriteLine("Please enter a number");
            int userTarget = int.Parse(Console.ReadLine());

            int startNumber = 0;

            while (startNumber <= userTarget)
            {
                Console.Write(startNumber + " ");
                startNumber = startNumber + 2;
            }
        }  
        
        public void DisplayDoubleNumbers()
        {
            double targetNumberD = 12.00D;
            double startNumberD = 0;

            while (startNumberD <= targetNumberD)
            {
                Console.Write(startNumberD + " ");
                startNumberD = startNumberD + 2;
            }
        }

        public void DisplayDecimalNumbers() 
        {
            decimal targetNumberM = 12.00M;
            decimal startNumberM = 0;

            while (startNumberM <= targetNumberM)
            {
                Console.Write(startNumberM + " ");
                startNumberM = startNumberM + 2;
            }
        }

        public void DisplayFloatNumbers() 
        {
            float targetNumberF = 12.00F;
            float startNumberF = 0;

            while (startNumberF <= targetNumberF)
            {
                Console.Write(startNumberF + " ");
                startNumberF = startNumberF + 2;
            }
        }

        public void DisplayLongNumbers() 
        {
            long targetNumberL = 12L;
            long startNumberL = 0;

            while (startNumberL <= targetNumberL)
            {
                Console.Write(startNumberL + " ");
                startNumberL = startNumberL + 2;
            }
        }

        public void DisplayDateTimeRange()
        {
            DateTime startDateTime = new DateTime(2023, 1, 10);
            DateTime endDateTime = new DateTime(2023, 1, 20);
            DateTime date = startDateTime;

            while( date <= endDateTime)
            {
                Console.WriteLine(date + " ");
                date = date.AddDays(1);
            }
        }
    }
}
