using System;
using System.Text;

namespace Day33Concepts
{
    public class StringAndStringBuilderExample
    {
        public void StringExample()
        {
            string userString = "C#";
            userString += " Video";
            userString += " Tutorial";
            userString += " for";
            userString += " Beginners";

            Console.WriteLine(userString);
        }

        public void StringBuilderExample()
        {
            StringBuilder userString = new StringBuilder();
            userString.Append("C#");
            userString.Append(" Video");
            userString.Append(" Tutorial");
            userString.Append(" for");
            userString.Append(" Beginners");

            Console.WriteLine(userString.ToString());



        }
    }   
}
