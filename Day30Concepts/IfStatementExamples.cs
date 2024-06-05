using System;

namespace Day30Concepts
{
    internal class IfStatementExamples
    {
        public void IfStatementExample()
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("Your number is One");
            }

            if (number == 2)
            {
                Console.WriteLine("Your number is two");
            }

            if (number == 3)
            {
                Console.WriteLine("Your number is three");
            }

            if (number != 1 && number != 2 && number != 3)
            {
                Console.WriteLine("Your number is not between 1 and 3");
            }

            Console.WriteLine("--------------------------------------------------");

            long numberL = 10L;

            if (numberL == 10L)
            {
                Console.WriteLine("Your number is {0}", numberL);
            }

            if (numberL != 10L)
            {
                Console.WriteLine("Invalid Number");
            }

            Console.WriteLine("-----------------------------------");

            float numberF = 10.25F;

            if (numberF == 10.25F)
            {
                Console.WriteLine("Your number is {0}", numberF);
            }

            if (numberF != 10.25F)
            {
                Console.WriteLine("Invalid Number");
            }

            Console.WriteLine("------------------------------------");

            double numberD = 10.25;

            if (numberD == 10.25)
            {
                Console.WriteLine("Your number is {0}", numberD);
            }

            if (numberD != 10.25)
            {
                Console.WriteLine("Invalid Number");
            }

            Console.WriteLine("--------------------------------------");

            decimal numberM = 10.25M;

            if (numberM == 10.25M)
            {
                Console.WriteLine("Your number is {0}", numberM);
            }

            if (numberM != 10.25M)
            {
                Console.WriteLine("Invalid Number");
            }
        }

        public void ElseIfStatementExample()
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("Your number is One");
            }

            else if (number == 2)
            {
                Console.WriteLine("Your number is two");
            }

            else if (number == 3)
            {
                Console.WriteLine("Your number is three");
            }

            else
            {
                Console.WriteLine("Your number is not between 1 and 3");
            }

        }

        public void NestedIfExample()
        {
            Console.WriteLine("Please enter a first number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second number");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 != number2)
            {
                if (number1 < number2)
                {
                    Console.WriteLine($"{number1} is less than {number2}");
                }
                else if (number1 > number2)
                {
                    Console.WriteLine($"{number1} is greater than {number2}");
                }
            }
            else
                Console.WriteLine($"{number1} is equal to {number2}");

            Console.WriteLine("--------------------------------------------------");

            long numberL1 = 25L;
            long numberL2 = 35L;

            if (numberL1 != numberL2)
            {
                if (numberL1 < numberL2)
                {
                    Console.WriteLine($"{numberL1} is less than {numberL2}");
                }
                else if (numberL1 > numberL2)
                {
                    Console.WriteLine($"{numberL1} is greater than {numberL2}");
                }
            }
            else
                Console.WriteLine($"{numberL1} is equal to {numberL2}");

            Console.WriteLine("--------------------------------------------------");

            double numberD1 = 25.355D;
            double numberD2 = 35.355D;

            if (numberD1 != numberD2)
            {
                if (numberD1 < numberD2)
                {
                    Console.WriteLine($"{numberD1} is less than {numberD2}");
                }
                else if (numberD1 > numberD2)
                {
                    Console.WriteLine($"{numberD1} is greater than {numberD2}");
                }
            }
            else
                Console.WriteLine($"{numberD1} is equal to {numberD2}");

            Console.WriteLine("--------------------------------------------------");

            float numberF1 = 25.427F;
            float numberF2 = 35.427F;

            if (numberF1 != numberF2)
            {
                if (numberF1 < numberF2)
                {
                    Console.WriteLine($"{numberF1} is less than {numberF2}");
                }
                else if (numberF1 > numberF2)
                {
                    Console.WriteLine($"{numberF1} is greater than {numberF2}");
                }
            }
            else
                Console.WriteLine($"{numberF1} is equal to {numberF2}");

            Console.WriteLine("--------------------------------------------------");

            decimal numberM1 = 25.345M;
            decimal numberM2 = 35.345M;

            if (numberM1 != numberM2)
            {
                if (numberM1 < numberM2)
                {
                    Console.WriteLine($"{numberM1} is less than {numberM2}");
                }
                else if (numberM1 > numberM2)
                {
                    Console.WriteLine($"{numberM1} is greater than {numberM2}");
                }
            }
            else
                Console.WriteLine($"{numberM1} is equal to {numberM2}");
        }
    }    
}
