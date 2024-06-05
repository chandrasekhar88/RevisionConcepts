using System;

namespace Day30Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OperatorsExample();
            //IfStatementExamples();
            //WhileLoopExamples();
            //DoWhileExamples();
            //ForLoopExamples();
            //MethodExamples();
            //MethodParameterExamples();
            //MethodRefOutExamples();
            TupleExample();
        }

        static void OperatorsExample()
        {
            OperatorsWithExample operators = new OperatorsWithExample();
            //operators.ArithmeticExample();
            //operators.UnaryArithmeticExample();
            //operators.RelationalExample();
            //operators.LogicalExample();
            //operators.BitwiseExample();
            //operators.AssignmentExample();
            operators.TernaryExample();
        }

        static void IfStatementExamples()
        {
            IfStatementExamples ifStatement = new IfStatementExamples();
            //ifStatement.IfStatementExample();
            //ifStatement.ElseIfStatementExample();
            //ifStatement.NestedIfExample();
            
        }

        static void WhileLoopExamples()
        {
            WhileLoopExamples whileLoop = new WhileLoopExamples();
            //whileLoop.WhileLoopExample();
            //whileLoop.DisplayDecimalNumbers();
            //whileLoop.DisplayDoubleNumbers();
            //whileLoop.DisplayFloatNumbers();
            //whileLoop.DisplayLongNumbers();
            whileLoop.DisplayDateTimeRange();
        }

        static void DoWhileExamples()
        {
            DoWhileExamples doWhile = new DoWhileExamples();
            //doWhile.PrintNumbers();
            //doWhile.PrintLongNumbers();
            //doWhile.PrintDoubleNumbers();
            //doWhile.PrintFloatNumbers();
            //doWhile.PrintDecimalNumbers();
        }

        static void ForLoopExamples()
        {
            ForLoopExamples forLoop = new ForLoopExamples();
            //forLoop.PrintNumbers();
            //forLoop.PrintLongNumbers();
            //forLoop.PrintDoubleNumbers();
            //forLoop.PrintFloatNumbers();
            //forLoop.PrintDecimalNumbers();
            forLoop.PrintDateTimeRange();
        }

        static void MethodExamples()
        {
            MethodExamples method = new MethodExamples();
            method.InstanceMethodExample();
            method.InstanceMethodDoubleExample();
            method.InstanceMethodLongExample();
            method.InstanceMethodFloatExample();
            method.InstanceMethodDecimalExample();
            method.InstanceMethodDateTimeExample();
        }

        static void MethodParameterExamples()
        {
            MethodParameterExamples methodParameter = new MethodParameterExamples();
            
            int number = 20;
            methodParameter.MethodWithValueParameterExample(number);
            Console.WriteLine(number);

            methodParameter.MethodWithLongParameterExample(number);
            Console.WriteLine(number);

            methodParameter.MethodWithDoubleParameterExample(number);
            Console.WriteLine(number);

            methodParameter.MethodWithFloatParameterExample(number);
            Console.WriteLine(number);

            methodParameter.MethodWithDecimalParameterExample(number);
            Console.WriteLine(number);

            DateTime date = DateTime.Now;
            methodParameter.MethodWithDateTimeParameterExample(date);
            Console.WriteLine(date);
        }

        static void MethodRefOutExamples()
        {
            MethodWithRefAndOutParameterExamples refOut = new MethodWithRefAndOutParameterExamples();

            int number1 = 20;
            refOut.RefIntParameterExample(ref number1);
            Console.WriteLine(number1);

            int number2 = 15;
            refOut.OutIntParameterExample(out number2);
            Console.WriteLine(number2);

            long numberL1 = 201;
            refOut.RefLongParameterExample(ref numberL1);
            Console.WriteLine(number1);

            long numberL2 = 151;
            refOut.OutLongParameterExample(out numberL2);
            Console.WriteLine(number2);

            double numberD1 = 20.25;
            refOut.RefDoubleParameterExample(ref numberD1);
            Console.WriteLine(number1);

            double numberD2 = 15.65;
            refOut.OutDoubleParameterExample(out numberD2);
            Console.WriteLine(number2);

            float numberF1 = 20.24F;
            refOut.RefFloatParameterExample(ref numberF1);
            Console.WriteLine(number1);

            float numberF2 = 15.47F;
            refOut.OutFloatParameterExample(out numberF2);
            Console.WriteLine(number2);

            decimal numberM1 = 20.67M;
            refOut.RefDecimalParameterExample(ref numberM1);
            Console.WriteLine(number1);

            decimal numberM2 = 15.5M;
            refOut.OutDecimalParameterExample(out numberM2);
            Console.WriteLine(number2);
        }

        static void TupleExample()
        {
            TupleExamples tuple = new TupleExamples();
            var employee = tuple.EmployeeDetails();
            Console.WriteLine($"Employee Id = {employee.id} \n Name = {employee.name} \n Salary = {employee.salary} \n" +
                $"Incentives = {employee.incentives} \n Allowances = {employee.allowances} \n" +
                $"Bank A/C No = {employee.acNumber} \n Date of Join = {employee.doj}");

            tuple.EmployeeDetails1();
        }
    }
}
