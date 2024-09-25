using System;

namespace FGCollegeWahCantt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining the student names and their marks in science subjects
            string[] studentNames = { "Bilal", "Basit", "Baber", "Khalid", "Saad", "Amaar", "Zarar" };
            int[,] marks = {
                { 95, 90, 98, 97, 99 }, // Bilal
                { 78, 82, 85, 80, 84 }, // Basit
                { 70, 75, 72, 74, 71 }, // Baber
                { 60, 65, 68, 62, 67 }, // Khalid
                { 88, 85, 90, 87, 89 }, // Saad
                { 72, 78, 80, 75, 77 }, // Amaar
                { 85, 88, 82, 90, 87 }  // Zarar
            };

            string[] subjects = { "Mathematics", "Physics", "Biology", "Computer", "Chemistry" };

            // Displaying the header
            Console.WriteLine("Marks of Students from FG Degree College Wah Cantt");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"{"Name",-10} {"Mathematics",-12} {"Physics",-8} {"Biology",-8} {"Computer",-9} {"Chemistry",-9} {"Total",-6} {"Average",-6} {"Status"}");
            Console.WriteLine("--------------------------------------------------");

            int highestTotal = 0;
            string topScorer = "";

            // Displaying the marks for each student
            for (int i = 0; i < studentNames.Length; i++)
            {
                int total = 0; // Initialize total marks for the current student
                Console.Write($"{studentNames[i],-10}");

                // Loop through each subject to calculate total marks
                for (int j = 0; j < subjects.Length; j++)
                {
                    Console.Write($"{marks[i, j],-12}");
                    total += marks[i, j]; // Accumulate marks
                }

                double average = total / (double)subjects.Length; // Calculate average
                string status;

                // Check if the student has passed or failed
                if (average >= 70)
                {
                    status = "Passed";
                }
                else
                {
                    status = "Failed";
                }

                // Display total, average, and status
                Console.WriteLine($"{total,-6} {average:F2,-6} {status}");

                // Check for the top scorer
                if (total > highestTotal)
                {
                    highestTotal = total;
                    topScorer = studentNames[i];
                }
            }

            // Highlighting the top scorer
            Console.WriteLine($"\nNote: {topScorer} is the TOP scorer in Science subjects with a total of {highestTotal} marks.");
        }
    }
}
