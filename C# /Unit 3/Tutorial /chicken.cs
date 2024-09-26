using System;

// Abstract Class and Interface
public abstract class Bird
{
    public abstract void MakeSound(); // Abstract method
}

public interface IProducing
{
    string GetProduct(); // Interface method
}

// Class and Object
public class Chicken : Bird, IProducing
{
    private string _name; // Private field
    private int _age;     // Private field

    // Constructor
    public Chicken(string name, int age)
    {
        _name = name;
        _age = age;
    }

    // Destructor
    ~Chicken()
    {
        Console.WriteLine($"{_name} the Chicken is being destroyed.");
    }

    // Properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    // Static Property
    public static string Species => "Gallus gallus domesticus";

    // Method Overloading
    public void MakeSound() => Console.WriteLine($"{_name} says: Cluck!");

    public string GetProduct()
    {
        return "Egg"; // Chickens produce eggs
    }

    // Additional overloaded method
    public string GetProduct(int quantity)
    {
        return $"{quantity} Eggs"; // Method overloading
    }
}

// Inheritance and Polymorphism
public class Rooster : Chicken
{
    public Rooster(string name, int age) : base(name, age) {}

    // Override MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Cock-a-doodle-doo!");
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Create objects
        Chicken hen = new Chicken("Henrietta", 2);
        Rooster rooster = new Rooster("Rooster Roo", 3);

        // Accessing properties
        Console.WriteLine($"Chicken: {hen.Name}, Age: {hen.Age}, Species: {Chicken.Species}");
        hen.MakeSound();
        Console.WriteLine($"Product: {hen.GetProduct()}");
        Console.WriteLine($"Product: {hen.GetProduct(12)}"); // Using overloaded method

        // Using polymorphism
        Bird myBird = rooster; // Upcasting
        myBird.MakeSound(); // Calls Rooster's MakeSound method

        // Changing properties
        hen.Age = 3;
        hen.MakeSound();
    }
}
