using System;

namespace StudentGradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define student names and subject count
            string[] studentNames = { "Bilal", "Basit", "Baber", "Khalid", "Saad" };
            int subjectCount = 5;
            int[,] marks = new int[studentNames.Length, subjectCount];

            // Input student scores
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"Enter scores for {studentNames[i]}:");

                for (int j = 0; j < subjectCount; j++)
                {
                    while (true)
                    {
                        Console.Write($"Subject {j + 1}: ");
                        string input = Console.ReadLine();

                        // Validate input
                        if (int.TryParse(input, out int score) && score >= 0 && score <= 100)
                        {
                            marks[i, j] = score;
                            break; // Exit while loop on valid input
                        }
                        else
                        {
                            Console.WriteLine("Invalid score. Please enter a score between 0 and 100.");
                        }
                    }
                }
            }

            // Displaying results
            Console.WriteLine("\nStudent Grades:");
            Console.WriteLine($"{"Name",-10} {"Average",-8} {"Grade"}");
            Console.WriteLine("------------------------------");

            for (int i = 0; i < studentNames.Length; i++)
            {
                int total = 0; // Initialize total for each student

                // Calculate total marks
                for (int j = 0; j < subjectCount; j++)
                {
                    total += marks[i, j];
                }

                double average = (double)total / subjectCount; // Calculate average
                string grade; // Variable to hold the grade

                // Determine the grade based on average
                if (average >= 90)
                {
                    grade = "A";
                }
                else if (average >= 80)
                {
                    grade = "B";
                }
                else if (average >= 70)
                {
                    grade = "C";
                }
                else if (average >= 60)
                {
                    grade = "D";
                }
                else
                {
                    grade = "F"; // Grade for averages below 60
                }

                // Display results
                Console.WriteLine($"{studentNames[i],-10} {average:F2,-8} {grade}");
            }
        }
    }
}
 
