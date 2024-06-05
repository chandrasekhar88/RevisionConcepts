using System;
using interface1 = Day33Concepts.InterfaceExamples;
using abstract1 = Day33Concepts.AbstractClassExamples;
using diamond = Day33Concepts.DiamondProblemExample;
using multipleIheritance = Day33Concepts.MultipleInheritanceExample;


namespace Day33Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfaceExamples();
            //InterfaceExplicitExample();
            //AbstractExample();
            //DiamondProblemExample();
            //MultipleInheritanceExample();
            //ParameterArrayExample();
            //MethodOverloadingExample();
            //MethodParameterDefaultExample();
            //OptionalAttributeExample();
            //OverRideToStringExample();
            //ConvertToStringAndToStringExample();
            ConstantAndReadOnlyExamples();

        }

        static void InterfaceExamples()
        {
            interface1.Customer customer = new interface1.Customer();
            customer.Print1();
            customer.Print2();
            Console.WriteLine("-----------------------");

            interface1.Customer2 customer2 = new interface1.Customer2();
            customer2.Print3();
            customer2.Print4();
        }

        static void InterfaceExplicitExample()
        {
            interface1.Employee employee = new interface1.Employee();

            employee.id = 11;
            employee.firstName = "Ram";
            employee.lastName = "Kumar";
            employee.salary = 500;
            employee.tax = 1;
            employee.accountNumber = 6799552;
            employee.allowances = 1500;
            employee.dateOfJoin = DateTime.Now;
            ((interface1.IPartTimeEmployee)employee).PartTimeDetails();

            employee.id = 1;
            employee.firstName = "Raj";
            employee.lastName = "Kumar";
            employee.salary = 50000;
            employee.tax = 5;
            employee.accountNumber = 67952;
            employee.allowances = 6500;
            employee.dateOfJoin = new DateTime(2023,01,11);
            ((interface1.IFullTimeEmployee)employee).FullTimeDetails();
        }

        static void AbstractExample()
        {
            abstract1.Class customer = new abstract1.Class();
            customer.Print();
        }

        static void DiamondProblemExample()
        {
            diamond.ClassD diamond = new diamond.ClassD();
            diamond.Method();
        }

        static void MultipleInheritanceExample()
        {
            multipleIheritance.CustomerC customer = new multipleIheritance.CustomerC();
            customer.MethodA();
            customer.MethodB();
        }

        static void  ParameterArrayExample()
        {
            ParameterArrayExamples parameterArray = new ParameterArrayExamples();
            parameterArray.AddNumbers(1,2);
            parameterArray.AddDoubleNumbers(1,2);
            parameterArray.AddLongNumbers(1,2);
            parameterArray.AddFloatNumbers(1,2);
            parameterArray.AddDecimalNumbers(1,2);
            parameterArray.AddTwoStrings("RAM ","KUMAR");
            parameterArray.AddTwoCharacters('R', 'B', 'K');

        }

        static void MethodOverloadingExample()
        {
            MethodOverLoadingExamples overLoading = new MethodOverLoadingExamples();
            overLoading.AddNumbers(1, 2, 3);
            overLoading.AddDoubleNumbers(1, 2,12);
            overLoading.AddLongNumbers(1, 2,15);
            overLoading.AddFloatNumbers(1, 6, 2);
            overLoading.AddDecimalNumbers(1, 2);
            overLoading.AddTwoStrings("RAM ", "KUMAR", "Test");
            overLoading.AddTwoCharacters('A','E','C');
        }

        static void MethodParameterDefaultExample()
        {
            MethodParameterDefaultExamples parameterDefault = new MethodParameterDefaultExamples();
            parameterDefault.AddNumbers(10, 200);
            parameterDefault.AddDoubleNumbers(10, 2);
            parameterDefault.AddLongNumbers(1, 20);
            parameterDefault.AddFloatNumbers(10, 2);
            parameterDefault.AddDecimalNumbers(1, 20);
            parameterDefault.AddTwoStrings("RAM ", "KUMAR");
            parameterDefault.AddTwoCharacters('C', 'B');

        }

        static void OptionalAttributeExample()
        {
            OptionalAttributeExamples optionalAttribute = new OptionalAttributeExamples();
            optionalAttribute.AddNumbers(10, 200);
            optionalAttribute.AddDoubleNumbers(10, 2);
            optionalAttribute.AddLongNumbers(1, 20);
            optionalAttribute.AddFloatNumbers(10, 2);
            optionalAttribute.AddDecimalNumbers(1, 20);
            optionalAttribute.AddTwoStrings("RAM ", "KUMAR");
            optionalAttribute.AddTwoCharacters('C', 'B');

        }

        static void OverRideToStringExample()
        {
            OverRideToStringExamples overRideToString = new OverRideToStringExamples();
            int number = 10;
            Console.WriteLine(number.ToString());

            overRideToString.firstName = "Mark";
            overRideToString.lastName = "Test";
            Console.WriteLine( overRideToString.ToString() );
        }

        static void ConvertToStringAndToStringExample()
        {
            ConvertToStringAndToStringExamples convertToString = new ConvertToStringAndToStringExamples();
            string word = Convert.ToString(convertToString);
            Console.WriteLine(word);
        }

        static void StringAndStringBuilderExamples()
        {
            StringAndStringBuilderExample stringAndStringBuilder = new StringAndStringBuilderExample();
            stringAndStringBuilder.StringExample();
            stringAndStringBuilder.StringBuilderExample();
        }

        static void ConstantAndReadOnlyExamples()
        {
            ConstantAndReadOnlyExample constant = new ConstantAndReadOnlyExample();
            constant.ConstantExample();
        }
    }
}
