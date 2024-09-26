```Population Data Display Project
Overview
This project is a C# console application designed to 
display the population of 200 countries from 1900 to 
2000. It utilizes a predefined dataset that contains 
population statistics for each country over the specified 
years. The application allows users to view the population 
data in a tabular format, facilitating an understanding 
of demographic trends over the century.```

using System;
using System.Collections.Generic;

namespace PopulationDataDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample population data for 200 countries from 1900 to 2000
            var populationData = new Dictionary<string, Dictionary<int, long>>
            {
                {"China", new Dictionary<int, long>
                    {
                        {1900, 400000000},
                        {1950, 554000000},
                        {2000, 1260000000}
                    }
                },
                {"India", new Dictionary<int, long>
                    {
                        {1900, 238000000},
                        {1950, 361000000},
                        {2000, 1050000000}
                    }
                },
                {"United States", new Dictionary<int, long>
                    {
                        {1900, 76000000},
                        {1950, 151000000},
                        {2000, 282000000}
                    }
                },
                // Add more countries and their population data here
            };

            // Display the population data
            Console.WriteLine("Population Data (1900 - 2000)\n");
            Console.WriteLine("{0,-25} {1,10} {2,10} {3,10}", "Country", "1900", "1950", "2000");
            Console.WriteLine(new string('-', 60));

            foreach (var country in populationData)
            {
                Console.WriteLine("{0,-25} {1,10} {2,10} {3,10}", country.Key,
                    country.Value.ContainsKey(1900) ? country.Value[1900].ToString("N0") : "N/A",
                    country.Value.ContainsKey(1950) ? country.Value[1950].ToString("N0") : "N/A",
                    country.Value.ContainsKey(2000) ? country.Value[2000].ToString("N0") : "N/A");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
