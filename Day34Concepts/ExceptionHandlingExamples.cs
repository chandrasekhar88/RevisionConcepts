using System;

namespace Day34Concepts
{
    public class ExceptionHandlingExamples
    {
        public void DivisionOfTwoNumbers()
        {
            int firstNumber = 0;
            int secondNumber = 0;

            Console.WriteLine("Enter First Number");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            try
            {
                int output = firstNumber / secondNumber;
                Console.WriteLine(output);
            }
            catch (Exception)
            {

                Console.WriteLine("Error has happened please contact for support");
            }
        }

        public int DivisionOfTwoNumbers1(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;

            return result;
        }

        public int Arithmetic(int firstNumber, int secondNumber)
        {
            int result = Divide(firstNumber, secondNumber);

            return result;
        }

        public int Divide(int firstNumber, int secondNumber)
        {
            if ((firstNumber < 0) || (secondNumber < 0))
            {
                throw new Exception("Negative numbers are not allowed");
            }

            if (firstNumber == secondNumber)
            {
                throw new Exception("Numerator and Denominator are same ");
            }

            int result = firstNumber / secondNumber;

            return result;
        }

        public void DivisionOfTwoDoubleNumbers()
        {
            double firstNumber = 0;
            double secondNumber = 0;

            Console.WriteLine("Enter First Number");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            try
            {
                double output = firstNumber / secondNumber;
                Console.WriteLine(output);
            }
            catch (Exception)
            {

                Console.WriteLine("Error has happened please contact for support");
            }
        }

        public double DivisionOfTwoDoubleNumbers1(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;

            return result;
        }

        public double ArithmeticDouble(double firstNumber, double secondNumber)
        {
            double result = DivideDouble(firstNumber, secondNumber);

            return result;
        }

        public double DivideDouble(double firstNumber, double secondNumber)
        {
            if ((firstNumber < 0) || (secondNumber < 0))
            {
                throw new Exception("Negative numbers are not allowed");
            }

            if (firstNumber == secondNumber)
            {
                throw new Exception("Numerator and Denominator are same ");
            }

            double result = firstNumber / secondNumber;

            return result;
        }
    }    
}

