using System;

// Abstract Class and Interface
public abstract class Shape
{
    public abstract double Area(); // Abstract method
}

public interface IPrintable
{
    void PrintInfo(); // Interface method
}

// Class and Object
public class Rectangle : Shape, IPrintable
{
    private double _length; // Private field
    private double _width;  // Private field

    // Constructor
    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    // Destructor
    ~Rectangle()
    {
        Console.WriteLine("Rectangle object is being destroyed.");
    }

    // Properties
    public double Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public double Width
    {
        get { return _width; }
        set { _width = value; }
    }

    // Static Property
    public static string Type => "Rectangle";

    // Method Overloading
    public double Area() => _length * _width; // Calculate Area

    public void PrintInfo()
    {
        Console.WriteLine($"Rectangle: Length = {_length}, Width = {_width}, Area = {Area()}");
    }
}

// Inheritance and Polymorphism
public class Square : Rectangle
{
    public Square(double side) : base(side, side) { } // Constructor

    public override double Area() => Length * Length; // Override Area for Square

    public void PrintSquareInfo()
    {
        Console.WriteLine($"Square: Side = {Length}, Area = {Area()}");
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Create objects
        Rectangle rect = new Rectangle(5, 10);
        Square square = new Square(4);

        // Accessing properties
        Console.WriteLine($"Rectangle Type: {Rectangle.Type}");
        rect.PrintInfo();
        square.PrintInfo();

        // Show polymorphism
        Shape myShape = square; // Upcasting
        Console.WriteLine($"Polymorphic Area of Square: {myShape.Area()}");

        // Changing properties
        rect.Length = 7;
        rect.Width = 12;
        rect.PrintInfo();

        // Destructor will be called automatically when objects go out of scope
    }
}
