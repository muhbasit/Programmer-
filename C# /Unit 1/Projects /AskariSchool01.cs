using System;

namespace AskariSchool
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
            Console.WriteLine("Marks of Students from Askari School Wah Cantt, Pakistan");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"{"Name",-10} {"Mathematics",-12} {"Physics",-8} {"Biology",-8} {"Computer",-9} {"Chemistry",-9}");
            Console.WriteLine("--------------------------------------------------------");

            // Displaying the marks for each student
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.Write($"{studentNames[i],-10}");
                for (int j = 0; j < subjects.Length; j++)
                {
                    Console.Write($"{marks[i, j],-12}");
                }
                Console.WriteLine();
            }

            // Finding and displaying top scorer for each subject
            Console.WriteLine("\nTop Scorer in Each Subject:");
            for (int subjectIndex = 0; subjectIndex < subjects.Length; subjectIndex++)
            {
                int topScore = 0;
                string topStudent = "";

                for (int studentIndex = 0; studentIndex < studentNames.Length; studentIndex++)
                {
                    if (marks[studentIndex, subjectIndex] > topScore)
                    {
                        topScore = marks[studentIndex, subjectIndex];
                        topStudent = studentNames[studentIndex];
                    }
                }
                Console.WriteLine($"{subjects[subjectIndex]}: {topStudent} with {topScore} marks");
            }
        }
    }
}
