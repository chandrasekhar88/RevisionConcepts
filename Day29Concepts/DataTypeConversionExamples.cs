using System;

namespace Day29Concepts
{
    public class DataTypeConversionExamples
    {
        public void ImplicitConversion()
        {
            int number = 20230512;
            long longNumber = number;
            float floatNumber = number;
            double doubleNumber = number;
            
            Console.WriteLine($"{number} \n");
            Console.WriteLine("After Conversion \n");
            Console.WriteLine(longNumber);
            Console.WriteLine(floatNumber);
            Console.WriteLine(doubleNumber);

        }

        public void ImplicitConversion2()
        {
            float floatNumber = 23.45F;
            double doubleNumber = floatNumber;

            Console.WriteLine($"{floatNumber} \n");
            Console.WriteLine("After Conversion \n");
            Console.WriteLine(doubleNumber);

            string name = "DotNet";
            object obj = name;
            Console.WriteLine(obj);

            int[] numbers = { 1, 2, 3 };
            object number1 = numbers[0];
            object number2 = numbers[1];
            object number3 = numbers[2];
            Console.WriteLine("Number List {0}, {1}, {2}",number1,number2,number3);
        }

        public void ExplicitConversion()
        {
            float floatNumber = 123.45F;
            Console.WriteLine($"{floatNumber} \n");

            int number = (int)floatNumber; 
            long longNumber = (long)floatNumber;
            double doubleNumber = (double)floatNumber;
            decimal decimalNumber = (decimal)floatNumber;
            object objectNumber = (object)floatNumber;

            Console.WriteLine("After Conversion \n");
            Console.WriteLine(number);
            Console.WriteLine(longNumber);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(decimalNumber);
            Console.WriteLine(objectNumber);            
        }

        public void ConvertClassExample()
        {
            float floatNumber = 123.45F;
            Console.WriteLine($"{floatNumber} \n");

            Console.WriteLine("Conversion using Convert Class");
            int number1 = Convert.ToInt32(floatNumber);
            Console.WriteLine(number1);

            long number2 = Convert.ToInt64(floatNumber);
            Console.WriteLine(number2);

            double number3 = Convert.ToDouble(floatNumber);
            Console.WriteLine(number3);

            decimal number4 = Convert.ToDecimal(floatNumber);
            Console.WriteLine(number4);

            string number5 = Convert.ToString(floatNumber);
            Console.WriteLine(number5);

            Console.WriteLine("-------------------");

            double doubleNumber = 24.35D;

            int number6 = Convert.ToInt32(doubleNumber);
            Console.WriteLine(number6);

            long number7 = Convert.ToInt64(doubleNumber);
            Console.WriteLine(number7);

            decimal number8 = Convert.ToDecimal(doubleNumber);
            Console.WriteLine(number8);

            string number9 = Convert.ToString(doubleNumber);
            Console.WriteLine(number9);            
        }

        public void BoxingExample()
        {
            int number = 15;
            Console.WriteLine(number);
            string number2 = number.ToString();
            Console.WriteLine(number);
            object number3 = number;
            Console.WriteLine(number3);

            long longNumber = 88L;
            Console.WriteLine(longNumber);
            string longNumber1 = longNumber.ToString();
            Console.WriteLine(longNumber1);
            object longNumber2 = longNumber;
            Console.WriteLine(longNumber2);

            float floatNumber = 23.36F;
            Console.WriteLine(floatNumber);
            string floatNumber1 = floatNumber.ToString();
            Console.WriteLine(floatNumber1);
            object floatNumber2 = floatNumber;
            Console.WriteLine(floatNumber2);

            double doubleNumber = 23.36D;
            Console.WriteLine(doubleNumber);
            string doubleNumber2 = number2.ToString();
            Console.WriteLine(doubleNumber2);
            object doubleNumber3 = doubleNumber;
            Console.WriteLine(doubleNumber3);

            decimal decimalNumber = 36.58M;
            Console.WriteLine(decimalNumber);
            string decimalNumber2 = number2.ToString();
            Console.WriteLine(decimalNumber2);
            object decimalNumber3 = doubleNumber;
            Console.WriteLine(decimalNumber3);
        }

        public void UnBoxingExample()
        {
            object reference = 123;
            Console.WriteLine(reference);

            int number1 = (int)reference;
            Console.WriteLine(number1);

            long number2 = (long)reference;
            Console.WriteLine(number2);

            double number3 = (double) reference;
            Console.WriteLine(number3);

            float number4 = (float) reference;
            Console.WriteLine(number4);

            decimal number5 = (decimal) reference;
            Console.WriteLine(number5);

            bool isTrue = (bool) reference;
            Console.WriteLine(isTrue);

            DateTime dateTime6 = (DateTime) reference;
            Console.WriteLine(dateTime6);
        }

        public void ParseExample()
        {
            string stringOfNumber = "123";
            Console.WriteLine(stringOfNumber);

            int number1 = int.Parse(stringOfNumber);
            long number2 = long.Parse(stringOfNumber);
            float number3 = float.Parse(stringOfNumber);
            double number4 = double.Parse(stringOfNumber);
            decimal number5 = decimal.Parse(stringOfNumber);

            int dateInt = 20230511;
            DateTime date = DateTime.Parse(dateInt.ToString());
            string time = "10/22/2023 12:10:15 PM";
            DateTime dateTime = DateTime.Parse(time);

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(number5);
            Console.WriteLine(date);
            Console.WriteLine(dateTime);
        }

        public void TryParseExample()
        {
            Console.WriteLine("Please enter First Number");
            int.TryParse(Console.ReadLine(), out int number1);
            Console.WriteLine("Please enter Second Number");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"First Number {number1} and Second Number {number2} \n" +
                $" Sum of both the numbers is {number1 + number2} ");

            Console.WriteLine("Please enter Double Number");
            double.TryParse(Console.ReadLine(), out double number3);
            Console.WriteLine("Please enter Second Number");
            int number4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"First Number {number3} and Second Number {number4} \n" +
                $" Sum of both the numbers is {number3 + number4} ");

            Console.WriteLine("Please enter Decimal Number");
            decimal.TryParse(Console.ReadLine(), out decimal number5);
            Console.WriteLine("Please enter Second Number");
            int number6 = int.Parse(Console.ReadLine());

            Console.WriteLine($"First Number {number5} and Second Number {number6} \n" +
                $" Sum of both the numbers is {number5 + number6} ");

            DateTime dateTimeObj;
            bool isSuccess = DateTime.TryParse("10-22-2015", out dateTimeObj);
            Console.WriteLine(isSuccess);
        }

        
        static void NullableTypeExample()
        {
            string stringOfNumber = null;

            Nullable<int> number1 = null; // Using Nullable Class

            int? number2 = null; // '?' is Null-Coalescing Operator
            long? longNumber = null;
            double? doubleNumber = null;
            bool? isBool = null;
            isBool = false;
            isBool = true;
            DateTime? nullDateTime = null;
        }
        #region Advanced Topics

        /*
        public void ByteToInt()
        {
            byte[] bytes = { 0, 0, 0, 4};

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            
            int i = BitConverter.ToInt32(bytes,0);
            Console.WriteLine(i);
        }

        public void ByteToString()
        {
            byte[] bytes = BitConverter.GetBytes(201805978);
            Console.WriteLine("byte array: " + BitConverter.ToString(bytes));            
        }

        public void DateTimeToString()
        {
            DateTime dateTime = DateTime.Now;
            string dateTimeString = dateTime.ToString();
            Console.WriteLine(dateTimeString);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string dateFormatUS = dateTime.ToString(); // US date MM/DD/YYYY format
            Console.WriteLine(dateFormatUS);
        }

        //Converting int to Enum
        public enum Week{
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public void IntToEnum()
        {
            int number1 = 2, number2 = 4, number3 = 7;

            Week day1, day2, day3;

            day1 = (Week)number1;
            day2 = (Week)number2;
            day3 = (Week)number3;

            Console.WriteLine(day1);
            Console.WriteLine(day2);
            Console.WriteLine(day3);
        }

        public void IntToEnumUsingEnumToObject()
        {
            int number1 = 2, number2 = 4, number3 = 7;

            Week day1, day2, day3;

            day1 = (Week)Enum.ToObject(typeof(Week), number1);
            day2 = (Week)Enum.ToObject(typeof(Week), number2);
            day3 = (Week)Enum.ToObject(typeof(Week), number3);

        }

        public void StringToEnumUsingParse()
        {
            string day1 = "Monday", day2 = "TUESDAY", day3 = "OTHER DAY";

            Week weekDay1 = Enum.Parse<Week>(day1);
            Week weekDay2 = Enum.Parse<Week>(day2, true);
            Console.WriteLine(weekDay1);
            Console.WriteLine(weekDay2);

            //Week weekDay3 = Enum.Parse<Week>(day3, true); throwing exception
            if (Enum.IsDefined(typeof(Week), day3))
            {
                Week weekDay3 = Enum.Parse<Week>(day3);
            }
            else
            {
                Console.WriteLine("Given day is not available");
            }
        }

        public void StringToEnumUsingTryParse()
        {
            string day1 = "Monday", day2 = "TUESDAY", day3 = "OTHER DAY";

            Week weekDay1, weekDay2, weekDay3;

            if(Enum.TryParse<Week>(day1, out weekDay1))
                Console.WriteLine("{0} converted to {1}", day1, weekDay1);

            if(Enum.TryParse<Week>(day2,true, out weekDay2))
                Console.WriteLine("{0} converted to {1}", day2, weekDay2);

            if (Enum.TryParse<Week>(day3,true, out weekDay3))
                Console.WriteLine("{0} converted to {1}", day3, weekDay3);
            else
                Console.WriteLine("Conversion Failed for {0}", day3);
        }

        public void BinaryStringToByte()
        {
            var binaryString = "01110100011001010111001101110100";

            var byteArray = Enumerable.Range(0, int.MaxValue / 8)
                                      .Select(i => i * 8)    // get the starting index of which char segment
                                      .TakeWhile(i => i < binaryString.Length)
                                      .Select(i => binaryString.Substring(i, 8)) // get the binary string segments
                                      .Select(s => Convert.ToByte(s, 2)) // convert to byte
                                      .ToArray();

            foreach (var item in byteArray)
            {
                Console.WriteLine(item);
            }
        }

        public void StringToEquivalentByte()
        {
            string word = "GeekForGeeks";

            byte[] bytes = Encoding.ASCII.GetBytes(word);

            for (int i = 0; i < bytes.Length; i++)
            {
                Console.WriteLine("Bytes of Character - \'" + word[i] + "\'  : " + bytes[i]);
            }
        }*/

        #endregion
    }
}
