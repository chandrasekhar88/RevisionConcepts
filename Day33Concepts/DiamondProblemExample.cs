using System;

namespace Day33Concepts.DiamondProblemExample
{
    public class ClassA
    {
        public virtual void Method()
        {
            Console.WriteLine("Class A method");
        }
    }

    public class ClassB : ClassA
    {
        public override void Method()
        {
            Console.WriteLine("Class B Method");
        }

    }

    public class ClassC : ClassA
    {
        public override void Method()
        {
            Console.WriteLine("Class C Method");
        }

    }

    public class ClassD : ClassB //, ClassC 
    {
        public override void Method()
        {
            Console.WriteLine("Class D Method");
        }
    }
}
