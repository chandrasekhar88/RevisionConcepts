using System;

namespace Day35Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ComparingExample();
            //ComparingTwoChars();
            //ComparingTwoIntegers();
            //ComparingTwoChars();
            //ComparingTwoStrings();
            //ComparingTwoDoubless();
            //ComparingTwoFloats();
            //ComparingTwoDecimals();
            //ComparingTwoDates();
            //PrintCustomers();
            //InsertMethod();
            //ContainsMethod();
            //ExistsMethod();
            //FindMethod();
            //FindAllMethod();
            //FindIndexMethod();
            //AddRangeMethodExample();
            //GetRangeMethodExample();
            //InsertRangeMethodExample();
            //RemoveRelatedMethodExample();
            //SortAndReverseIntegers();
            //SortAndReverseStrings();
            //SortAndReverseDouble();
            //SortAndReverseFloat();
            //SortAndReverseDecimals();
            //SortAndReverseCharacters();
            //PrintMonthsUsingList();
            //PrintDays();
            //StackMethods();
            //ShoppingCartExample();
            //QueueMethodsExample();
            //MovieTicketBookingExample();
        }

        static void ComparingExample()
        {
            bool isEqual = GenericsExample.IsEqual("A","A");

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        static void ComparingTwoChars()
        {
            GenericsExample generics = new GenericsExample();
            generics.ComparingTwoCharacters();
        }

        static void ComparingTwoIntegers()
        {
            GenericsExample generics = new GenericsExample();
            generics.ComparingTwoIntegers();
        }

        static void ComparingTwoStrings()
        {
            GenericsExample generics = new GenericsExample();
            generics.ComparingTwoStrings();
        }

        static void ComparingTwoDoubless()
        {
            GenericsExample generics = new GenericsExample();
            generics.ComparingTwoDoubles();
        }

        static void ComparingTwoFloats()
        {
            GenericsExample generics = new GenericsExample();
            generics.ComparingTwoFloats();
        }

        static void ComparingTwoDecimals()
        {
            GenericsExample generics = new GenericsExample();
            generics.ComparingTwoDecimals();
        }

        static void ComparingTwoDates()
        {
            GenericsExample generics = new GenericsExample();
            generics.ComparingTwoDates();
        }

        static void PrintCustomers()
        {
            ListClassExamples customerList = new ListClassExamples();
            customerList.GetCustomers();
        }

        static void InsertMethod()
        {
            ListClassFunctionsExample listFunctions = new ListClassFunctionsExample();
            listFunctions.InsertMethod();
        }

        static void ContainsMethod()
        {
            ListClassFunctionsExample listFunctions = new ListClassFunctionsExample();
            listFunctions.ContainsMethod();
        }

        static void ExistsMethod()
        {
            ListClassFunctionsExample listFunctions = new ListClassFunctionsExample();
            listFunctions.ExistsMethod();
        }

        static void FindMethod()
        {
            ListClassFunctionsExample listFunctions = new ListClassFunctionsExample();
            listFunctions.FindMethod();
        }

        static void FindAllMethod()
        {
            ListClassFunctionsExample listFunctions = new ListClassFunctionsExample();
            listFunctions.FindAllMethod();
        }

        static void FindIndexMethod()
        {
            ListClassFunctionsExample listFunctions = new ListClassFunctionsExample();
            listFunctions.FindIndexMethod();
        }

        static void AddRangeMethodExample()
        {
            ListClassRangesExamples ranges = new ListClassRangesExamples();
            ranges.AddRangeMethodExample();
        }

        static void GetRangeMethodExample()
        {
            ListClassRangesExamples ranges = new ListClassRangesExamples();
            ranges.GetRangeMethodExample();
        }

        static void InsertRangeMethodExample()
        {
            ListClassRangesExamples ranges = new ListClassRangesExamples();
            ranges.InsertRangeMethodExample();

        }

        static void RemoveRelatedMethodExample()
        {
            ListClassRangesExamples ranges = new ListClassRangesExamples();
            ranges.RemoveRelatedMethodExample();
        }

        static void SortAndReverseIntegers()
        {
            ListOfSimpleTypeExamples listOfSimple = new ListOfSimpleTypeExamples();
            listOfSimple.SortAndReverseIntegers();
        }

        static void SortAndReverseStrings()
        {
            ListOfSimpleTypeExamples listOfSimple = new ListOfSimpleTypeExamples();
            listOfSimple.SortAndReverseStrings();
        }

        static void SortAndReverseDouble()
        {
            ListOfSimpleTypeExamples listOfSimple = new ListOfSimpleTypeExamples();
            listOfSimple.SortAndReverseDouble();
        }

        static void SortAndReverseFloat()
        {
            ListOfSimpleTypeExamples listOfSimple = new ListOfSimpleTypeExamples();
            listOfSimple.SortAndReverseFloat();
        }

        static void SortAndReverseDecimals()
        {
            ListOfSimpleTypeExamples listOfSimple = new ListOfSimpleTypeExamples();
            listOfSimple.SortAndReverseDecimals();
        }

        static void SortAndReverseCharacters()
        {
            ListOfSimpleTypeExamples listOfSimple = new ListOfSimpleTypeExamples();
            listOfSimple.SortAndReverseCharacters();
        }

        static void PrintCustomerInfoUsingSortMethod()
        {
            ListOfComplexTypeExample listOfComplex = new ListOfComplexTypeExample();
            listOfComplex.PrintCustomerInfoUsingSortMethod();
        }

        static void UsingComparisonDelegate()
        {
            ListOfComplexTypeExample listOfComplex = new ListOfComplexTypeExample();
            listOfComplex.UsingComparisonDelegate();
        }

        static void UsingLambdaExpression()
        {
            ListOfComplexTypeExample listOfComplex = new ListOfComplexTypeExample();
            listOfComplex.UsingLambdaExpression();
        }

        static void PrintMonthsUsingList()
        {
            DictionaryExample dictionary = new DictionaryExample();
            dictionary.PrintMonthsUsingList();
        }

        static void PrintDays()
        {
            DictionaryExample dictionary = new DictionaryExample();
            dictionary.PrintDays();
        }

        static void StackMethods()
        {
            GenericStackExamples genericStack = new GenericStackExamples();
            genericStack.StackMethods();
        }

        static void ShoppingCartExample()
        {
            GenericStackExamples genericStack = new GenericStackExamples();
            genericStack.ShoppingCartExample();

        }

        static void QueueMethodsExample()
        {
            GenericQueueExample genericQueueExample = new GenericQueueExample();
            genericQueueExample.QueueMethodsExample();

        }

        static void MovieTicketBookingExample()
        {
            GenericQueueExample genericQueueExample = new GenericQueueExample();
            genericQueueExample.MovieTicketBookingExample();
        }
    }
}
