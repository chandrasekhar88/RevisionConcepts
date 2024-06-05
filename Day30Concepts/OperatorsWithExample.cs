using System;

namespace Day30Concepts
{
    public class OperatorsWithExample
    {
        public void ArithmeticExample()
        {
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());          

            int addition = firstNumber + secondNumber;
            int subtraction = firstNumber - secondNumber;
            int division = firstNumber / secondNumber;
            int modulus = firstNumber % secondNumber;

            Console.WriteLine("Addition of {0} and {1} = {2} ",firstNumber,secondNumber, addition);
            Console.WriteLine("Subtraction of {0} and {1} = {2} ", firstNumber, secondNumber, subtraction);
            Console.WriteLine("Division of {0} and {1} = {2} ", firstNumber, secondNumber, division);
            Console.WriteLine("Modulus of {0} and {1} = {2}", firstNumber, secondNumber, modulus);
            
            long numberL1 = 695L;
            long numberL2 = 367L;
            
            long additionL = numberL1 + numberL2;
            long subtractionL = numberL1 - numberL2;
            long divisionL = numberL1 * numberL2;
            long modulusL = numberL1 % numberL2;

            Console.WriteLine(additionL);
            Console.WriteLine(subtractionL);
            Console.WriteLine(divisionL);
            Console.WriteLine(modulusL);

            double number1 = 24.56D;
            double number2 = 36.7D;

            double additionD = number1 + number2;
            double subtractionD = number1 - number2;
            double divisionD = number1 * number2;
            double modulusD = number1 % number2;
            Console.WriteLine(additionD);
            Console.WriteLine(subtractionD);
            Console.WriteLine(divisionD);
            Console.WriteLine(modulusD);

            decimal numberM1 = 9469.56M;
            decimal numberM2 = 3624.17M;
             
            decimal additionM = numberM1 + numberM2;
            decimal subtractionM = numberM1 - numberM2;
            decimal divisionM = numberM1 * numberM2;
            decimal modulusM = numberM1 % numberM2;

            Console.WriteLine(additionM);
            Console.WriteLine(subtractionM);
            Console.WriteLine(divisionM);
            Console.WriteLine(modulusM);

        }

        

        public void UnaryArithmeticExample()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            result = number++; // post increment
            Console.WriteLine("number is {0} and result is {1}", result);

            result = number--; // post decrement 
            Console.WriteLine("number is {0} and result is {1}", result);

            result = ++number; // post increment
            Console.WriteLine("number is {0} and result is {1}", result);

            result = --number; // pre decrement 
            Console.WriteLine("number is {0} and result is {1}", result);
        }

        public void ComparisonExample()
        {
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            bool isEqual = firstNumber == secondNumber;
            bool isGreaterThan = firstNumber > secondNumber;
            bool isLessThan = firstNumber < secondNumber;
            bool isGreaterThanOrEqual = firstNumber >= secondNumber;
            bool isLessThanOrEqual = firstNumber <= secondNumber;
            bool isNotEqual = firstNumber != secondNumber;

            Console.WriteLine("{0} and {1} are equal = {2}?", firstNumber, secondNumber, isEqual);
            Console.WriteLine("{0} is greater than {1} ? = {2}", firstNumber, secondNumber, isGreaterThan);
            Console.WriteLine("{0} is less than  {1} ? = {2}", firstNumber, secondNumber, isLessThan);
            Console.WriteLine("{0} is greater than Or Equal to {1} ? = {2}", firstNumber, secondNumber, isGreaterThanOrEqual);
            Console.WriteLine("{0} is less than Or Equal to {1} ? = {2}", firstNumber, secondNumber, isLessThanOrEqual);
            Console.WriteLine("{0} is Equal to {1} ? = {2}", firstNumber, secondNumber, isLessThanOrEqual);
            Console.WriteLine("{0} is Equal to {1} ? = {2}", firstNumber, secondNumber, isNotEqual);

            long numberL1 = 635L;
            long numberL2 = 546L;

            bool isEqualL = numberL1 == numberL2;
            bool isGreaterThanL = numberL1 > numberL2;
            bool isLessThanL = numberL1 < numberL2;
            bool isGreaterThanOrEqualL = numberL1 >= numberL2;
            bool isLessThanOrEqualL = numberL1 <= numberL2;
            bool isNotEqualL = numberL1 != numberL2;

            Console.WriteLine(isEqualL);
            Console.WriteLine(isGreaterThanL);
            Console.WriteLine(isLessThanL);
            Console.WriteLine(isGreaterThanOrEqualL);
            Console.WriteLine(isLessThanOrEqualL);
            Console.WriteLine(isNotEqualL);

            double numberD1 = 735.54D;
            double numberD2 = 346.36D;

            bool isEqualD = numberD1 == numberD2;
            bool isGreaterThanD = numberD1 > numberD2;
            bool isLessThanD = numberD1 < numberD2;
            bool isGreaterThanOrEqualD = numberD1 >= numberD2;
            bool isLessThanOrEqualD = numberD1 <= numberD2;
            bool isNotEqualD = numberD1 != numberD2;

            Console.WriteLine(isEqualD);
            Console.WriteLine(isGreaterThanD);
            Console.WriteLine(isLessThanD);
            Console.WriteLine(isGreaterThanOrEqualD);
            Console.WriteLine(isLessThanOrEqualD);
            Console.WriteLine(isNotEqualD);

            decimal numberM1 = 654.45M;
            decimal numberM2 = 245.67M;

            bool isEqualM = numberM1 == numberM2;
            bool isGreaterThanM = numberM1 > numberM2;
            bool isLessThanM = numberM1 < numberM2;
            bool isGreaterThanOrEqualM = numberM1 >= numberM2;
            bool isLessThanOrEqualM = numberM1 <= numberM2;
            bool isNotEqualM = numberM1 != numberM2;

            Console.WriteLine(isEqualM);
            Console.WriteLine(isGreaterThanM);
            Console.WriteLine(isLessThanM);
            Console.WriteLine(isGreaterThanOrEqualM);
            Console.WriteLine(isLessThanOrEqualM);
            Console.WriteLine(isNotEqualM);
        }

        public void LogicalExample()
        {
            bool atrue = true;
            bool bfalse = false;
            bool result;

            result = atrue && bfalse;
            result = atrue || bfalse;
            result = !atrue;

            Console.WriteLine("And Operator result {0}", result);
            Console.WriteLine("OR Operator result {0}", result);
            Console.WriteLine("NOT Operator result {0}", result);

            int number1 = 20;
            int number2 = 10;

            bool isBothEqual = number1 == 20 && number2 == 10;
            bool isOneEqual = number1 == 15 || number2 == 10;
            bool isNot = number1 != number2;

            Console.Write(isBothEqual);
            Console.Write(isOneEqual);
            Console.Write(isNot);

            long numberL1 = 15L;
            long numberL2 = 10L;

            bool isBothEqualL = numberL1 == 15L && numberL2 == 10L;
            bool isOneEqualL = numberL1 == 15 || numberL2 == 65L;
            bool isNotL = numberL1 != numberL2;

            Console.Write(isBothEqualL);
            Console.Write(isOneEqualL);
            Console.Write(isNotL);

            float numberF1 = 20.67F;
            float numberF2 = 20.25F;

            bool isBothEqualF = numberF1 == 20.67F && numberF2 == 20.25F;
            bool isOneEqualF = numberF1 == 56.35F || numberF2 == 20.25F;
            bool isNotF = numberF1 != numberF2;

            Console.Write(isBothEqualF);
            Console.Write(isOneEqualF);
            Console.Write(isNotF);

            double numberD1 = 15.67;
            double numberD2 = 10.25;

            bool isBothEqualD = numberD1 == 15.67 && numberD2 == 10.25;
            bool isOneEqualD = numberD1 == 56.35 || numberD2 == 10.25;
            bool isNotD = numberD1 != numberD2;

            Console.Write(isBothEqualD);
            Console.Write(isOneEqualD);
            Console.Write(isNotD);

            decimal numberM1 = 15.67M;
            decimal numberM2 = 10.25M;

            bool isBothEqualM = numberM1 == 15.67M && numberM2 == 10.25M;
            bool isOneEqualM = numberM1 == 56.35M || numberM2 == 10.25M;
            bool isNotM = numberM1 != numberM2;

            Console.Write(isBothEqualM);
            Console.Write(isOneEqualM);
            Console.Write(isNotM);

        }

        public void BitwiseExample()
        {
            int number1 = 10;
            int number2 = 5;
            int result;

            result = number1 & number2;
            result = number1 | number2;
            result = ~number1;
            result = number1 << 2;
            result = number1 >> 2;

            Console.WriteLine("Bitwise AND = {0}",result);
            Console.WriteLine("Bitwise OR = {0}",result);
            Console.WriteLine("Bitwise XOR = {0}",result);
            Console.WriteLine("Bitwise Complement = {0}",result);
            Console.WriteLine("Bitwise Left Shift = {0}",result);
            Console.WriteLine("Bitwise Right Shift = {0}",result);
        }

        public void AssignmentExample()
        {
            int number = 15;

            number += 10;
            Console.WriteLine("Add Assignment Operator = {0}", number);

            number = 20;
            number -= 5;
            Console.WriteLine("Subtract Assignment Operator = {0}", number);
            number = 5;
            number *= 10;
            Console.WriteLine("Multiply Assignment Operator = {0}", number);

            number = 35;
            number /= 5;
            Console.WriteLine("Division Assignment Operator = {0}", number);

            number = 20;
            number %= 5;
            Console.WriteLine("Modulus Assignment Operator = {0}", number);

            number = 8;
            number <<= 2;
            Console.WriteLine("Left Shift Assignment Operator = {0}", number);

            number = 8;
            number >>= 2;
            Console.WriteLine("Right Shift Assignment Operator = {0}", number);

            number = 12;
            number &= 4;
            Console.WriteLine("Bitwise AND Assignment Operator = {0}", number);

            number = 12;
            number ^= 4;
            Console.WriteLine("Bitwise Exclusive OR Assignment Operator = {0}", number);

            number = 12;
            number |= 4;
            Console.WriteLine("Bitwise Inclusive OR Assignment Operator = {0}", number);
        }

        public void TernaryExample()
        {
            int number1 = 10; 
            int number2 = 15;
            
            int result = number1 > number2 ? number1 : number2;
            int result1 = number1 < number2 ? number1 : number2;

            Console.WriteLine("Greater number is {0}", result);
            Console.WriteLine("Small number is {0}", result1);
        }

        public void DateTimeExample()
        {
            DateTime dateTime = new DateTime(2023, 12, 10);
            TimeSpan timeSpan = new TimeSpan(15, 10, 5, 1);
            DateTime addResult = dateTime + timeSpan; 
            Console.WriteLine(addResult);

            DateTime substractResult = dateTime - timeSpan;
            Console.WriteLine(substractResult);

            DateTime date1 = new DateTime(2022, 2, 25);
            DateTime date2 = new DateTime(2015, 12, 15);

            bool areEqual = date1 == date2;
            Console.WriteLine(areEqual);            
        }
    }
}
