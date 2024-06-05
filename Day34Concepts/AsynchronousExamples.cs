using System;
using System.Threading;
using System.Threading.Tasks;

namespace Day34Concepts
{
    public class AsynchronousExamples
    {
        public void PrintMethod1()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Print Method 1 :- " + i);
            }
        }

        public void PrintMethod2()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Print Method 2 :- " + i);
            }
        }

        public async Task PrintMethod3()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Print Method 3 :- " + i);
            }
        }

        public async Task PrintMethod4()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Print Method 4 :- " + i);
            }
        }

        public static async Task Method1()
        {
            await Task.Delay(5000);
            Console.WriteLine("Static Method1");
        }

        public static async Task Method2()
        {
            await Task.Delay(5500);
            Console.WriteLine("Static Method2");
        }
    }
}
