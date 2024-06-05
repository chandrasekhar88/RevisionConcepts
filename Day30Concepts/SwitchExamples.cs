using System;

namespace Day30Concepts
{
    public class SwitchExamples
    {
        static void SwitchStatementExample()
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 10:
                    Console.WriteLine("Your number is 10");
                    break;

                case 20:
                    Console.WriteLine("Your number is 20");
                    break;

                case 30:
                    Console.WriteLine("Your number is 30");
                    break;

                default:
                    Console.WriteLine("Your number is not in 10,20 and 30");
                    break;
            }
            Console.WriteLine("------------------------------------------------------");

            long numberL = 10L;

            switch (numberL)
            {
                case 10L:
                    Console.WriteLine("Your number is 10L");
                    break;

                case 20L:
                    Console.WriteLine("Your number is 20L");
                    break;

                case 30L:
                    Console.WriteLine("Your number is 30L");
                    break;

                default:
                    Console.WriteLine("Your number is not in 10L,20L and 30L");
                    break;
            }

            Console.WriteLine("------------------------------------------------------");

            double numberD = 10.52D;

            switch (numberD)
            {
                case 10.52D:
                    Console.WriteLine("Your number is 10.52D");
                    break;

                case 20.52D:
                    Console.WriteLine("Your number is 20.52D");
                    break;

                case 30.52D:
                    Console.WriteLine("Your number is 30.52D");
                    break;

                default:
                    Console.WriteLine("Your number is not in 10.52D,20.52D and 30.52D");
                    break;
            }

            Console.WriteLine("------------------------------------------------------");

            float numberF = 10.52F;

            switch (numberF)
            {
                case 10.52F:
                    Console.WriteLine("Your number is 10.52F");
                    break;

                case 20.52F:
                    Console.WriteLine("Your number is 20.52F");
                    break;

                case 30.52F:
                    Console.WriteLine("Your number is 30.52F");
                    break;

                default:
                    Console.WriteLine("Your number is not in 10.52F,20.52F and 30.52F");
                    break;
            }

            Console.WriteLine("------------------------------------------------------");

            decimal numberM = 10.52M;

            switch (numberM)
            {
                case 10.52M:
                    Console.WriteLine("Your number is 10.52M");
                    break;

                case 20.52M:
                    Console.WriteLine("Your number is 20.52M");
                    break;

                case 30.52M:
                    Console.WriteLine("Your number is 30.52M");
                    break;

                default:
                    Console.WriteLine("Your number is not in 10.52M,20.52M and 30.52M");
                    break;
            }

        }

        static void SwitchStatementWithNoCode()
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", number);
                    break;

                default:
                    Console.WriteLine("Your number is not in 10,20 and 30");
                    break;
            }

            Console.WriteLine("------------------------------------------------------");

            long numberL = 10;

            switch (numberL)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", numberL);
                    break;

                default:
                    Console.WriteLine("Your number is not in 10,20 and 30");
                    break;
            }

            Console.WriteLine("------------------------------------------------------");

            double numberD = 10;

            switch (numberD)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", numberL);
                    break;

                default:
                    Console.WriteLine("Your number is not in 10,20 and 30");
                    break;
            }

            Console.WriteLine("------------------------------------------------------");

            float numberF = 10;

            switch (numberF)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", numberF);
                    break;

                default:
                    Console.WriteLine("Your number is not in 10,20 and 30");
                    break;
            }

            Console.WriteLine("------------------------------------------------------");

            decimal numberM = 10;

            switch (numberL)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", numberM);
                    break;

                default:
                    Console.WriteLine("Your number is not in 10,20 and 30");
                    break;
            }
        }
        public void CoffeeShop()
        {
            long totalBill = 0;
        Start:
            Console.WriteLine("Select 1-Small, 2-Medium 3-Large");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    totalBill += 1;
                    break;
                case 2:
                    totalBill += 2;
                    break;
                case 3:
                    totalBill += 2;
                    break;
                default:
                    Console.WriteLine("Entered choice {0} is Invalid ! ", choice);
                    break;
            }

            Console.WriteLine("Do you want to buy another Coffee - Yes or No");
            string userDecision = Console.ReadLine();

        Decide:
            switch (userDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your Choice {0} is invalid. Please try again ... ", userDecision);
                    goto Decide;
            }

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = {0}", totalBill);
        }        
    }
}
