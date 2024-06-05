using System;

namespace Day29Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConsoleClassExamples();
            //DataTypeExamples();
            //VariableExamples();
            //DataTypeConversionExamples();
            ArrayExamples();
        }

        static void ConsoleClassExamples()
        {
            ConsoleClassIntroduction console = new ConsoleClassIntroduction();
            console.WriteLineAndReadLine();
            console.WriteLineAndWrite();
            console.ReadLineAndRead();            
        }

        static void DataTypeExamples()
        {
            BuiltInDataTypesExample dataTypes = new BuiltInDataTypesExample();
            dataTypes.DataTypes();
        }

        static void VariableExamples()
        {
            VariableExamples variable = new VariableExamples();
            variable.Variables();
        }

        static void DataTypeConversionExamples()
        {
            DataTypeConversionExamples conversion = new DataTypeConversionExamples();
            //conversion.ImplicitConversion();
            //conversion.ImplicitConversion2();
            //conversion.ExplicitConversion();
            //conversion.ConvertClassExample();
            //conversion.BoxingExample();
            //conversion.UnBoxingExample();
            //conversion.ParseExample();
            conversion.TryParseExample();
            
        }

        static void ArrayExamples()
        {
            ArrayExamples array = new ArrayExamples();
            //array.IntArrayExample();
            //array.StringArrayExample();
            //array.LongArrayExample();
            //array.DoubleArrayExample();
            //array.FloatArrayExample();
            //array.DecimalArrayExample();
            //array.CharacterArrayExample();
            //array.BoolArrayExample();
            array.DateTimeArray();



        }

        
    }

}
