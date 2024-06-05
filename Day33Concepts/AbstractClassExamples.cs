using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.AbstractClassExamples
{
    public abstract class Customer
    {
       public abstract void Print();
    }

    public class Class : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Abstract Class");    
        }
    }
    
}
