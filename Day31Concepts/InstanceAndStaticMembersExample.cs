using System;

namespace Day31Concepts.InstanceAndStaticMembersExample
{
    public class InstanceCircle
    {
        float pi = 3.141F;
        int radius;

        public InstanceCircle(int radius)
        {
            this.radius = radius;
        }

        public float CalculateArea()
        {
            return this.pi * this.radius * this.radius;
        }
    }

    public class StaticCircle
    {
        static float pi;
        int radius;

        static StaticCircle()
        {
            StaticCircle.pi = 3.141F;
        }

        public StaticCircle(int radius)
        {
            this.radius = radius;
        }

        public float CalculateArea()
        {
            return StaticCircle.pi * this.radius * this.radius;
        }
    }

    public class InstanceMembers
    {
        int id = 10;
        string name = "John";
        long accountNumber = 125476345;
        double salary = 56500.00;
        float incentives = 6000.00F;
        decimal allowances = 3000.00M;
        DateTime dateOfJoining = new DateTime(2024,05,01);

        public void PrintDetails()
        {
            Console.WriteLine($"{id} \n{name}\n{accountNumber}\n{salary}\n{incentives}\n{allowances}\n{dateOfJoining}");
        }
    }

    public static class StaticMembers
    {
        static int id = 10;
        static string name = "John";
        static long accountNumber = 125476345;
        static double salary = 56500.00;
        static float incentives = 6000.00F;
        static decimal allowances = 3000.00M;
        static DateTime dateOfJoining = new DateTime(2024, 05, 01);

        public static void PrintDetails()
        {
            Console.WriteLine($"{id} \n{name}\n{accountNumber}\n{salary}\n{incentives}\n{allowances}\n{dateOfJoining}");
        }
    }
}
