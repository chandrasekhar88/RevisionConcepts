using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts
{
    public class MethodWithRefAndOutParameterExamples
    {
        public void RefIntParameterExample(ref int number)
        {
            number = number + 10;
        }

        public void OutIntParameterExample(out int number)
        {
            number = 0;
            number = number + 10;
        }

        public void RefLongParameterExample(ref long number)
        {
            number = number + 10;
        }

        public void OutLongParameterExample(out long number)
        {
            number = 0;
            number = number + 10;
        }

        public void RefDoubleParameterExample(ref double number)
        {
            number = number + 10;
        }

        public void OutDoubleParameterExample(out double number)
        {
            number = 0;
            number = number + 10;
        }

        public void RefFloatParameterExample(ref float number)
        {
            number = number + 10;
        }

        public void OutFloatParameterExample(out float number)
        {
            number = 0;
            number = number + 10;
        }

        public void RefDecimalParameterExample(ref decimal number)
        {
            number = number + 10;
        }

        public void OutDecimalParameterExample(out decimal number)
        {
            number = 0;
            number = number + 10;
        }
    }
}
