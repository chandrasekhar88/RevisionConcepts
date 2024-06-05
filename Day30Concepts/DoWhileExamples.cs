using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts
{
    public class DoWhileExamples
    {

        public void PrintNumbers()
        {
            int number = 0;

            do
            {
                Console.WriteLine("i = {0}", number);
                number++;

            } while (number < 5);
        }

        public void PrintLongNumbers()
        {
            long number = 0;

            do
            {
                Console.WriteLine("i = {0}", number);
                number++;

            } while (number < 10);
        }

        public void PrintDoubleNumbers()
        {
            double number = 0;

            do
            {
                Console.WriteLine("i = {0}", number);
                number++;

            } while (number < 10D);
        }

        public void PrintDecimalNumbers()
        {
            decimal number = 0;

            do
            {
                Console.WriteLine("i = {0}", number);
                number++;

            } while (number < 10M);
        }

        public void PrintFloatNumbers()
        {
            float number = 0;

            do
            {
                Console.WriteLine("i = {0}", number);
                number++;

            } while (number < 10F);
        }
    }
}
