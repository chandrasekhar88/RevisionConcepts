using System;
using System.Collections.Generic;

namespace Day35Concepts
{
    public class CustomTypeAsDictionaryExample
    {
        public void PrintCountryCodeWithAmbassadors()
        {
            var ambassadors = new Dictionary<CountryCode, Ambassador>();

            Ambassador england = new Ambassador
            {
                countryCode = new CountryCode("eng"),
                name = "John",
                age = 25
            };

            Ambassador austraila = new Ambassador
            {
                countryCode = new CountryCode("aus"),
                name = "Martin",
                age = 49
            };

            ambassadors.Add(england.countryCode, england);
            ambassadors.Add(austraila.countryCode, austraila);

            Console.WriteLine("Enter Country Code");
            var code = Console.ReadLine();

            if (ambassadors.TryGetValue(new CountryCode(code), out Ambassador ambassador))
            {
                Console.WriteLine($"The Ambassador is {ambassador.name}");
            }
            else
            {
                Console.WriteLine("The given ambassador with the given code does not exist ");
            }
        }

        public void SortedDictionaryExample()
        {
            //Sorted Dictionary Class sort the collection of objects based on key only
            var fileInfo = new SortedDictionary<string, string>();
            fileInfo.Add("txt", "notepad.exe");
            fileInfo.Add("doc", "wordpad.exe");

            foreach (var file in fileInfo)
            {
                Console.WriteLine($"Key: {file.Key}, Value: {file.Value} ");
            }

            Console.WriteLine("Press any key to add another file extension");
            Console.ReadLine();

            fileInfo.Add("bmp", "paint.exe");

            Console.WriteLine("Upload file info list:");

            foreach (var file in fileInfo)
            {
                Console.WriteLine($"Key: {file.Key}, Value: {file.Value} ");
            }
        }
    }
}
