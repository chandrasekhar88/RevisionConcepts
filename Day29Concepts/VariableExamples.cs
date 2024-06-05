using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29Concepts
{
    public class VariableExamples
    {
        //Syntax:- DataType VariableName = InitializingValue

        int userNumber = 10; // Global Variable scope is within the class only

        static int number = 20; // Static Variable
        private int _;
        
        public void Variables()
        {
            int userNumber = 123; // Local Variable Scope is within the method only
            Console.WriteLine(userNumber);

            string userName = "savar";
            Console.WriteLine(userName);

            int[] arrayVariable = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            _ = 12; // discard , discard is local variable which has no name
            Console.WriteLine(_);                       
        }        
    }
}
