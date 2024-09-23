using System;

namespace PakistanCitiesPopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining the city names and their populations
            string[] cityNames = { "Islamabad", "Karachi", "Lahore", "Wah Cantt", "Attock" };
            int[] populations = { 1014825, 14910352, 12188000, 500000, 188000 };

            // Displaying the header
            Console.WriteLine("Population of Cities in Pakistan");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"{"City",-12} {"Population",-10}");
            Console.WriteLine("--------------------------------");

            // Displaying the population for each city
            for (int i = 0; i < cityNames.Length; i++)
            {
                Console.WriteLine($"{cityNames[i],-12} {populations[i],-10}");
            }

            // Finding the city with the highest population
            int highestPopulation = populations[0];
            string highestCity = cityNames[0];

            for (int i = 1; i < cityNames.Length; i++)
            {
                if (populations[i] > highestPopulation)
                {
                    highestPopulation = populations[i];
                    highestCity = cityNames[i];
                }
            }

            // Displaying the city with the highest population
            Console.WriteLine("\nCity with the Highest Population:");
            Console.WriteLine($"{highestCity} with a population of {highestPopulation}");
        }
    }
}
