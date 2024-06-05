using System;
using System.Diagnostics;
using System.Threading.Tasks;
using enumexample = Day34Concepts.EnumExamples;
using enumvalues = Day34Concepts.EnumValuesAndNamesExample;

namespace Day34Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EnumExample();
            //EnumEmployeeExample();
            //EnumProductExample();
            //EnumValuesAndNamesEmployeeExample();
            //EnumValuesAndNamesVehicleExample();
            //EnumValuesAndNamesColorsExample();
            //AsynchronousExample();            
            //AsynchronousExample1();
            //Methods();
            //DebuggVsRelease();
            //PrintArrayNumbers();
            //PrintArrayNumbers();
            //PrintPlanetNames();
            //ModifyPlanetName();
            //PrintMonthNamesUsingReverseMethod();
            ComparingTwoArrays();
        }

        static void EnumExample()
        {
            enumexample.Customer customer = new enumexample.Customer();
            customer.PrintCustomerDetails();
        }

        static void EnumEmployeeExample()
        {
            enumexample.Employee employee = new enumexample.Employee();
            employee.PrintEmployeeDetails();
        }

        static void EnumProductExample()
        {
            enumexample.Product product = new enumexample.Product();
            product.PrintProductDetails();
        }

        static void EnumValuesAndNamesEmployeeExample()
        {
            enumvalues.Employee employee = new enumvalues.Employee();
            employee.PrintMethod();
        }

        static void EnumValuesAndNamesVehicleExample()
        {
            enumvalues.Vehicles employee = new enumvalues.Vehicles();
            employee.PrintMethod();
        }

        static void EnumValuesAndNamesColorsExample()
        {
            enumvalues.Colors colors = new enumvalues.Colors();
            colors.PrintMethod();
        }

        static void AsynchronousExample()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            AsynchronousExamples asynchronous = new AsynchronousExamples();
            asynchronous.PrintMethod1();
            asynchronous.PrintMethod2();
            stopwatch.Stop();

            var timeElapsed = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("Time Elapsed = " + timeElapsed);
        }

        static void AsynchronousExample1()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            AsynchronousExamples asynchronous = new AsynchronousExamples();
            asynchronous.PrintMethod3();
            asynchronous.PrintMethod4();
            Task.WaitAll(asynchronous.PrintMethod3(),asynchronous.PrintMethod4());
            stopwatch.Stop();

            var timeElapsed = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("Time Elapsed = " + timeElapsed);
        }

        static void Methods()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task.WaitAll(AsynchronousExamples.Method1(),AsynchronousExamples.Method2());
            stopwatch.Stop();

            var timeElapsed = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("Time Elapsed = " + timeElapsed);
        }

        static void DebuggVsRelease()
        {
            DebuggVsReleaseExample debugg = new DebuggVsReleaseExample();
            debugg.Method1();
        }

        static void PrintArrayNumbers()
        {
            ArrayExamples array = new ArrayExamples();
            array.PrintArrayNumbersUsingForLoop();
        }

        static void PrintPlanetNames()
        {
            ArrayExamples array = new ArrayExamples();
            array.PrintPlanetNamesUsingForEach();
        }

        static void ModifyPlanetName()
        {
            ArrayExamples array = new ArrayExamples();
            array.ModifyPlanetName();
        }

        static void PrintMonthNamesUsingReverseMethod()
        {
            ArrayExamples array = new ArrayExamples();
            array.PrintMonthNamesUsingReverseMethod();
        }

        static void ComparingTwoArrays()
        {
            ArrayExamples array = new ArrayExamples();
            array.ComparingTwoArrays();
        }

    }
}
