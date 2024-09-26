using System;

// Abstract Class and Interface
public abstract class Animal
{
    public abstract void Speak(); // Abstract method
}

public interface IIdentifiable
{
    string GetID(); // Interface method
}

// Class and Object
public class Dog : Animal, IIdentifiable
{
    private string _name; // Private field
    private int _age;     // Private field

    // Constructor
    public Dog(string name, int age)
    {
        _name = name;
        _age = age;
    }

    // Destructor
    ~Dog()
    {
        Console.WriteLine($"{_name} the Dog is being destroyed.");
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
    public static string Species => "Canine";

    // Method Overloading
    public void Speak() => Console.WriteLine($"{_name} says: Woof!");

    public string GetID()
    {
        return $"{_name}-{_age}";
    }
}

// Inheritance and Polymorphism
public class Cat : Animal
{
    private string _name; // Private field
    private int _age;     // Private field

    // Constructor
    public Cat(string name, int age)
    {
        _name = name;
        _age = age;
    }

    // Override Speak method
    public override void Speak()
    {
        Console.WriteLine($"{_name} says: Meow!");
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Create objects
        Dog dog = new Dog("Buddy", 3);
        Cat cat = new Cat("Whiskers", 2);

        // Accessing properties
        Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Species: {Dog.Species}");
        dog.Speak();
        Console.WriteLine($"Dog ID: {dog.GetID()}");

        // Using polymorphism
        Animal myAnimal = cat; // Upcasting
        myAnimal.Speak(); // Calls Cat's Speak method

        // Changing properties
        dog.Age = 4;
        dog.Speak();
        Console.WriteLine($"Updated Dog ID: {dog.GetID()}");

        // Destructor will be called automatically when objects go out of scope
    }
}
