using System;

namespace Day34Concepts
{
    public class DebuggVsReleaseExample
    {
        public void Method1()
        {
            Method2();
        }

        public void Method2()
        {
            Method3();
        }

        public void Method3()
        {
            throw new Exception("Some Error");
        }
    }
}
