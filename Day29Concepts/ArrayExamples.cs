using System;
using System.Linq;

namespace Day29Concepts
{
    public class ArrayExamples
    {
        public void IntArrayExample()
        {
            // Initialization of Integer Array
            int[] employeeIds = new int[5]; 
            employeeIds[0] = 25;
            employeeIds[1] = 46;
            employeeIds[2] = 50;
            employeeIds[3] = 76;
            employeeIds[4] = 83;

            #region  Ways of Declaration and Initialization
            int[] employeeId1 = new int[5] { 25, 46, 50, 76, 83 };
            int[] employeeId2 = new int[] { 25, 46, 50, 76, 83 };
            int[] employeeId3 = { 25, 46, 50, 76, 83 };
            #endregion 

            Console.WriteLine(employeeIds[0]);
            Console.WriteLine(employeeIds[1]);
            Console.WriteLine(employeeIds[2]);
            Console.WriteLine(employeeIds[3]);
            Console.WriteLine(employeeIds[4]);
        }

        public void StringArrayExample()
        {
            // Initialization of String Array
            string[] employeeNames = new string[4];
            employeeNames[0] = "Rohit";
            employeeNames[1] = "Teja";
            employeeNames[2] = "Manohar";
            employeeNames[3] = "Kiran";

            #region Ways of Declaration and Initialization
            string[] employeeName1 = new string[4] { "Rohit", "Teja", "Manohar", "Kiran" };
            string[] employeeName2 = new string[] { "Rohit", "Teja", "Manohar", "Kiran" };
            string[] employeeName3 = { "Rohit", "Teja", "Manohar", "Kiran" };
            #endregion

            Console.WriteLine(employeeName1[0]);
            Console.WriteLine(employeeName1[1]);
            Console.WriteLine(employeeName1[2]);
            Console.WriteLine(employeeName1[3]);
        }

        public void LongArrayExample()
        {
            long[] employeeIds = new long[5];
            employeeIds[0] = 25L;
            employeeIds[1] = 46L;
            employeeIds[2] = 50L;
            employeeIds[3] = 76L;
            employeeIds[4] = 83L;

            Console.WriteLine(employeeIds[0]);
            Console.WriteLine(employeeIds[1]);
            Console.WriteLine(employeeIds[2]);
            Console.WriteLine(employeeIds[3]);
            Console.WriteLine(employeeIds[4]);
        }

        public void FloatArrayExample()
        {
            float[] employeeSalaries = new float[5];
            employeeSalaries[0] = 25520.56F;
            employeeSalaries[1] = 46525.69F;
            employeeSalaries[2] = 50551.21F;
            employeeSalaries[3] = 76564.36F;
            employeeSalaries[4] = 83553.90F;

            Console.WriteLine(employeeSalaries[0]);
            Console.WriteLine(employeeSalaries[1]);
            Console.WriteLine(employeeSalaries[2]);
            Console.WriteLine(employeeSalaries[3]);
            Console.WriteLine(employeeSalaries[4]);
        }

        public void DoubleArrayExample()
        {
            double[] employeeSalaries = new double[5];
            employeeSalaries[0] = 25020.56D;
            employeeSalaries[1] = 46125.69D;
            employeeSalaries[2] = 50751.21D;
            employeeSalaries[3] = 76964.36D;
            employeeSalaries[4] = 83153.90D;

            Console.WriteLine(employeeSalaries[0]);
            Console.WriteLine(employeeSalaries[1]);
            Console.WriteLine(employeeSalaries[2]);
            Console.WriteLine(employeeSalaries[3]);
            Console.WriteLine(employeeSalaries[4]);
        }

        public void DecimalArrayExample()
        {
            decimal[] employeeSalaries = new decimal[5];
            employeeSalaries[0] = 25020.23M;
            employeeSalaries[1] = 46125.69M;
            employeeSalaries[2] = 50751.21M;
            employeeSalaries[3] = 76964.36M;
            employeeSalaries[4] = 83153.90M;

            Console.WriteLine(employeeSalaries[0]);
            Console.WriteLine(employeeSalaries[1]);
            Console.WriteLine(employeeSalaries[2]);
            Console.WriteLine(employeeSalaries[3]);
            Console.WriteLine(employeeSalaries[4]);
        }

        public void CharacterArrayExample()
        {
            char[] characters = new char[4];
            characters[0] = 'A' ;
            characters[1] = 'B' ;
            characters[2] = 'C' ;
            characters[3] = 'S' ;

            Console.WriteLine(characters[0]);
            Console.WriteLine(characters[1]);
            Console.WriteLine(characters[2]);
            Console.WriteLine(characters[3]);
        }

        public void BoolArrayExample()
        {
            bool[] isTrue = new bool[4];
            isTrue[0] = true;
            isTrue[1] = false;
            isTrue[2] = true;
            isTrue[3] = true;

            Console.WriteLine(isTrue[0]);
            Console.WriteLine(isTrue[1]);
            Console.WriteLine(isTrue[2]);
            Console.WriteLine(isTrue[3]);
        }

        public void DateTimeArray()
        {
            DateTime[] startDate = new DateTime[5];
            startDate[0] = new DateTime(2023, 01, 10);
            startDate[1] = new DateTime(2023, 02, 11);
            startDate[2] = new DateTime(2023, 03, 12);
            startDate[3] = new DateTime(2023, 04, 13);
            startDate[4] = new DateTime(2023, 05, 14);

            Console.WriteLine(startDate[0]);
            Console.WriteLine(startDate[1]);
            Console.WriteLine(startDate[2]);
            Console.WriteLine(startDate[3]);
            Console.WriteLine(startDate[4]);
        }

        #region Advanced Topics

        /*

        public void MultiDimensionalArrayExample()
        {
            int[,] numbers = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        public void JaggedArrayExample()
        {
            int[][] jaggedArray = new int[3][]
            {
                new int[]{ 1, 2, 3 },
                new int[]{ 4, 5 },
                new int[]{ 6, 7, 8, 9 },
            };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }

                Console.WriteLine(" ");
            }
        }

        public void ObjectArray()
        {
            object[] employee = new object[7];
            employee[0] = 1;
            employee[1] = "Dell";
            employee[2] = 25365.36;
            employee[3] = null;
            employee[4] = 'M';
            employee[5] = new object();
            employee[6] = DateTime.Now;

            foreach (var detail in employee)
            {
                Console.WriteLine(detail);
            }            
        }

        public void SortInArray()
        {
            string[] animals = { "Cat", "Fox", "Donkey", "Bear", "Elephant", "Goat" };

            Array.Sort(animals);
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine("-------------");
            Array.Sort(animals,0,3); // Sorting 1st 3 elements
            Array.ForEach<string>(animals, animal => Console.WriteLine(animal));
            
        }

        public void EmployeeExample()
        {
            Product[] productList = new Product[5];
            productList[0] = new Product() { id = 1, name = "TV"  , price = 50003.06 };
            productList[1] = new Product() { id = 2, name = "Fridge"  , price = 25000.36 };
            productList[2] = new Product() { id = 3, name = "Laptop"  , price = 36000.25 };
            productList[3] = new Product() { id = 4, name = "Fan"  , price = 5600.99 };
            productList[4] = new Product() { id = 5, name = "Bag"  , price = 6499.99 };

            var priceSort = productList.OrderBy(product => product.price);
            var totalAmount = productList.Sum(product => product.price);
            
            foreach (var product in priceSort)
            {                
                Console.WriteLine(product.price + "\n");
            }
            
            Console.WriteLine("Total = " + totalAmount);
        }

        public void AddElementToArray()
        {
            //int[] numbers = { 15, 35, 61, 24, 9, 17 };
            int[] numbers = new int[6];
            numbers[0] = 15;
            numbers[1] = 35;
            numbers[2] = 61;
            numbers[3] = 24;
            numbers[4] = 9;
            numbers[5] = 17;

            Console.WriteLine("Array Length {0}", numbers.Length);

            Array.Resize(ref numbers, numbers.Length + 1);
            numbers[numbers.Length - 1] = 10;
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void InsertElementIntoArray(int[] numbers, int position, int value)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == position)
                {
                    numbers[position] = value;
                }
            }           
        }

        static void InsertElementIntoArray1()
        {
            ArrayExamples array = new ArrayExamples();

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            array.InsertElementIntoArray(numbers, 2, 60);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + " ");
            }
        }*/

        #endregion
    }
}
