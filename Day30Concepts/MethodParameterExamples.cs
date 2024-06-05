using System;

namespace Day30Concepts
{
    public class MethodParameterExamples
    {
        public void MethodWithValueParameterExample(int number)
        {
            number = 101;
        }

        public void MethodWithLongParameterExample(long number)
        {
            number = 101;
        }

        public void MethodWithDoubleParameterExample(double number)
        {
            number = 101.12;
        }

        public void MethodWithFloatParameterExample(float number)
        {
            number = 101.12F;
        }

        public void MethodWithDecimalParameterExample(decimal number)
        {
            number = 101.12M;
        }

        public void MethodWithDateTimeParameterExample(DateTime date)
        {
            date = Convert.ToDateTime(20240510);
        }
    }
}
