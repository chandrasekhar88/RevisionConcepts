using System;

namespace Day33Concepts.MultipleInheritanceExample
{
    interface ICustomerA
    {
        void MethodA();
    }

    interface ICustomerB
    {
        void MethodB();
    }

    public class CustomerA : ICustomerA
    {
        public void MethodA()
        {
            Console.WriteLine("ICustomerA Implementation in CustomerA");
        }
    }

    public class CustomerB : ICustomerB
    {
        public void MethodB()
        {
            Console.WriteLine("ICustomerA Implementation in CustomerB");
        }
    }

    public class CustomerC : ICustomerA, ICustomerB
    {

        /*public void MethodA()
        {
            Console.WriteLine("ICustomerA Implementation in CustomerA");
        }

        public void MethodB()
        {
            Console.WriteLine("ICustomerA Implementation in CustomerB");
        }*/

        CustomerA customerA = new CustomerA();
        CustomerB customerB = new CustomerB();

        public void MethodA()
        {
            customerA.MethodA();
        }

        public void MethodB()
        {
            customerB.MethodB();
        }
    }
}
