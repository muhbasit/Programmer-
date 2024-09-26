using System;
using System.Collections.Generic;

// Class: Citizen
// Represents an individual living in Wah Cantt with personal details.
public class Citizen
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public Citizen(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Citizen: {Name}, Age: {Age}, Address: {Address}");
    }
}

// Class: Service
// Represents various public services available in Wah Cantt.
public class Service
{
    public string ServiceName { get; set; }
    public string Description { get; set; }
    public bool IsAvailable { get; set; }

    public Service(string serviceName, string description, bool isAvailable)
    {
        ServiceName = serviceName;
        Description = description;
        IsAvailable = isAvailable;
    }

    public void DisplayServiceInfo()
    {
        Console.WriteLine($"Service: {ServiceName}, Description: {Description}, Available: {IsAvailable}");
    }
}

// Class: Vehicle
// Holds information about various modes of transportation available in Wah Cantt.
public class Vehicle
{
    public string OwnerName { get; set; }
    public string VehicleType { get; set; }
    public string RegistrationNumber { get; set; }

    public Vehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        OwnerName = ownerName;
        VehicleType = vehicleType;
        RegistrationNumber = registrationNumber;
    }

    public void DisplayVehicleInfo()
    {
        Console.WriteLine($"Owner: {OwnerName}, Vehicle Type: {VehicleType}, Registration: {RegistrationNumber}");
    }
}

// Class: City
// Acts as a central hub, containing lists of citizens, services, and vehicles.
public class City
{
    public string Name { get; set; }
    private List<Citizen> citizens;
    private List<Service> services;
    private List<Vehicle> vehicles;

    public City(string name)
    {
        Name = name;
        citizens = new List<Citizen>();
        services = new List<Service>();
        vehicles = new List<Vehicle>();
    }

    public void AddCitizen(Citizen citizen)
    {
        citizens.Add(citizen);
    }

    public void AddService(Service service)
    {
        services.Add(service);
    }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void DisplayCityInfo()
    {
        Console.WriteLine($"City: {Name}");
        Console.WriteLine("Citizens:");
        foreach (var citizen in citizens)
        {
            citizen.DisplayInfo();
        }
        Console.WriteLine("Services:");
        foreach (var service in services)
        {
            service.DisplayServiceInfo();
        }
        Console.WriteLine("Vehicles:");
        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayVehicleInfo();
        }
    }
}

// Class: CityManager
// Manages the overall operations of the city, allowing user interaction with citizens, services, and vehicles.
public class CityManager
{
    public City City { get; set; }

    public CityManager(City city)
    {
        City = city;
    }

    public void AddCitizen(string name, int age, string address)
    {
        Citizen citizen = new Citizen(name, age, address);
        City.AddCitizen(citizen);
    }

    public void AddService(string serviceName, string description, bool isAvailable)
    {
        Service service = new Service(serviceName, description, isAvailable);
        City.AddService(service);
    }

    public void AddVehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        Vehicle vehicle = new Vehicle(ownerName, vehicleType, registrationNumber);
        City.AddVehicle(vehicle);
    }

    public void DisplayAllInfo()
    {
        City.DisplayCityInfo();
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Create a new city
        City wahCantt = new City("Wah Cantt");
        CityManager cityManager = new CityManager(wahCantt);

        // Add citizens
        cityManager.AddCitizen("Bilal Khan", 28, "Street 1, Wah Cantt");
        cityManager.AddCitizen("Basit", 25, "Street 2, Wah Cantt");
        cityManager.AddCitizen("Sadia", 27, "Street 3, Wah Cantt");

        // Add services
        cityManager.AddService("Waste Management", "Collection of waste from residential areas", true);
        cityManager.AddService("Water Supply", "Providing water to all households", true);
        cityManager.AddService("Health Services", "Basic health care services", false);

        // Add vehicles
        cityManager.AddVehicle("Bilal Khan", "Car", "ABC-123");
        cityManager.AddVehicle("Basit", "Motorbike", "XYZ-456");

        // Display all information
        cityManager.DisplayAllInfo();
    }
}
