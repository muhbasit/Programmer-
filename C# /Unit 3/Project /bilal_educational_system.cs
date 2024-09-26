using System;
using System.Collections.Generic;
using System.Linq;

// Person class to represent family members
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// Family class to represent Bilal's family
public class Family
{
    public Person Father { get; set; }
    public Person Mother { get; set; }
    public Person Brother { get; set; }
    public List<Person> Sisters { get; set; }

    public Family(Person father, Person mother, Person brother, List<Person> sisters)
    {
        Father = father;
        Mother = mother;
        Brother = brother;
        Sisters = sisters;
    }
}

// School class to represent Bilal's school
public class School
{
    public string Name { get; set; }
    public string Teacher { get; set; }

    public School(string name, string teacher)
    {
        Name = name;
        Teacher = teacher;
    }
}

// Activity class to represent Bilal's daily activities
public class Activity
{
    public DateTime Date { get; set; }
    public bool Attendance { get; set; }
    public double PerformanceScore { get; set; }
    public List<string> SportsActivities { get; set; }
    public List<string> StudyNotes { get; set; }
    public List<double> ExamMarks { get; set; }
    public string FoodConsumed { get; set; }

    public Activity(DateTime date)
    {
        Date = date;
        SportsActivities = new List<string>();
        StudyNotes = new List<string>();
        ExamMarks = new List<double>();
    }

    public void AddActivity(string sport, string note, double marks, string food)
    {
        SportsActivities.Add(sport);
        StudyNotes.Add(note);
        ExamMarks.Add(marks);
        FoodConsumed = food;
    }
}

// Tracker class to manage activities and generate reports
public class Tracker
{
    public List<Activity> Activities { get; set; }

    public Tracker()
    {
        Activities = new List<Activity>();
    }

    public void AddActivity(Activity activity)
    {
        Activities.Add(activity);
    }

    public void DisplayReport(string period)
    {
        Console.WriteLine($"\n{period} Report:");
        Console.WriteLine("Date\t\tAttendance\tPerformance\tSports\t\tStudy Notes\tExam Marks\tFood");

        foreach (var activity in Activities)
        {
            Console.WriteLine($"{activity.Date.ToShortDateString()}\t{activity.Attendance}\t\t{activity.PerformanceScore}\t\t{string.Join(", ", activity.SportsActivities)}\t{string.Join(", ", activity.StudyNotes)}\t{string.Join(", ", activity.ExamMarks)}\t{activity.FoodConsumed}");
        }
    }
}

// Main program to run the educational tracking system
class Program
{
    static void Main(string[] args)
    {
        // Creating family members
        Person father = new Person("Ahmed Khan", 45);
        Person mother = new Person("Sara Khan", 43);
        Person brother = new Person("Ali Khan", 14);
        List<Person> sisters = new List<Person>
        {
            new Person("Fatima Khan", 10),
            new Person("Aisha Khan", 12),
            new Person("Zainab Khan", 8),
            new Person("Maryam Khan", 9),
            new Person("Hina Khan", 6),
            new Person("Sana Khan", 5)
        };
        Family family = new Family(father, mother, brother, sisters);

        // Creating school information
        School school = new School("Wah Cantt High School", "Mr. Ali");

        // Creating tracker for activities
        Tracker tracker = new Tracker();

        // Adding daily activities for a week (example)
        for (int i = 0; i < 7; i++)
        {
            var date = DateTime.Now.AddDays(-i);
            Activity activity = new Activity(date)
            {
                Attendance = true,
                PerformanceScore = 85 + i, // Sample performance scores
            };
            activity.AddActivity("Basketball", "Math notes", 90 + i, "Fruits");
            tracker.AddActivity(activity);
        }

        // Displaying reports
        tracker.DisplayReport("Daily");
        tracker.DisplayReport("Weekly");

        // Extend this for Monthly, Quarterly, and Yearly reports based on your requirements.
    }
}
