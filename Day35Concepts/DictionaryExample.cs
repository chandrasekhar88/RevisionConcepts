using System;
using System.Collections.Generic;

namespace Day35Concepts
{
    public class DictionaryExample
    {
        public void PrintMonthsUsingList()
        {
            List<string> months = new List<string>();
            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");
            months.Add("May");
            months.Add("June");
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");

            var march = months[2];
            var april = months[3];

            foreach (var month in months)
            {
                Console.WriteLine($"{month}");
            }

            Console.ReadKey();
        }

        public void PrintDays()
        {
            var months = new Dictionary<int, string>
            {
                { 1, "January" },
                { 2, "February" },
                { 3, "March" },
                { 4, "April" },
                { 5, "May" },
                { 6, "June" }
            };

            months[7] = "July";
            months[8] = "August";

            months.Add(10, "October");
            months.Add(11, "November");
            months.Add(12, "December");

            var days = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            days["sun"] = "Sunday";
            days["mon"] = "Monday";

            var sunDay = days["sun"];

            //var wednesDay = days.TryGetValue("wed", out string wed); if the key not avail then returns false

            foreach (var day in days)
            {
                Console.WriteLine($"Key: {day.Key}, Value: {day.Value}");
            }
        }
    }
}
