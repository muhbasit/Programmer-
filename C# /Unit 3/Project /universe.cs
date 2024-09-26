using System;
using System.Collections.Generic;

// Class: Universe
public class Universe
{
    public string Name { get; set; }
    private List<Galaxy> galaxies;        // List to hold galaxies
    private List<StarCluster> starClusters; // List to hold star clusters
    private List<SuperCluster> superClusters; // List to hold superclusters
    private List<Nebula> nebulas;         // List to hold nebulae

    // Constructor
    public Universe(string name)
    {
        Name = name;
        galaxies = new List<Galaxy>();
        starClusters = new List<StarCluster>();
        superClusters = new List<SuperCluster>();
        nebulas = new List<Nebula>();
    }

    // Methods to add celestial structures to the universe
    public void AddGalaxy(Galaxy galaxy) => galaxies.Add(galaxy);
    public void AddStarCluster(StarCluster cluster) => starClusters.Add(cluster);
    public void AddSuperCluster(SuperCluster superCluster) => superClusters.Add(superCluster);
    public void AddNebula(Nebula nebula) => nebulas.Add(nebula);

    // Method to display information about the universe
    public void DisplayUniverseInfo()
    {
        Console.WriteLine($"Universe: {Name}");
        Console.WriteLine($"Galaxies Count: {galaxies.Count}");
        foreach (var galaxy in galaxies)
        {
            galaxy.DisplayInfo();
        }
        Console.WriteLine($"Star Clusters Count: {starClusters.Count}");
        foreach (var cluster in starClusters)
        {
            cluster.DisplayInfo();
        }
        Console.WriteLine($"Super Clusters Count: {superClusters.Count}");
        foreach (var superCluster in superClusters)
        {
            superCluster.DisplayInfo();
        }
        Console.WriteLine($"Nebulas Count: {nebulas.Count}");
        foreach (var nebula in nebulas)
        {
            nebula.DisplayInfo();
        }
    }
}

// Class: Galaxy
public class Galaxy
{
    public string Name { get; set; }
    public string Type { get; set; }
    private List<Star> stars; // List to hold stars

    // Constructor
    public Galaxy(string name, string type)
    {
        Name = name;
        Type = type;
        stars = new List<Star>();
    }

    // Method to add stars to the galaxy
    public void AddStar(Star star) => stars.Add(star);

    // Method to display information about the galaxy
    public void DisplayInfo()
    {
        Console.WriteLine($"Galaxy: {Name}, Type: {Type}, Stars Count: {stars.Count}");
    }
}

// Class: StarCluster
public class StarCluster
{
    public string Name { get; set; }
    public int NumberOfStars { get; set; }

    // Constructor
    public StarCluster(string name, int numberOfStars)
    {
        Name = name;
        NumberOfStars = numberOfStars;
    }

    // Method to display information about the star cluster
    public void DisplayInfo()
    {
        Console.WriteLine($"Star Cluster: {Name}, Number of Stars: {NumberOfStars}");
    }
}

// Class: SuperCluster
public class SuperCluster
{
    public string Name { get; set; }
    public int NumberOfGalaxies { get; set; }

    // Constructor
    public SuperCluster(string name, int numberOfGalaxies)
    {
        Name = name;
        NumberOfGalaxies = numberOfGalaxies;
    }

    // Method to display information about the supercluster
    public void DisplayInfo()
    {
        Console.WriteLine($"Super Cluster: {Name}, Number of Galaxies: {NumberOfGalaxies}");
    }
}

// Class: Nebula
public class Nebula
{
    public string Name { get; set; }
    public string Type { get; set; }

    // Constructor
    public Nebula(string name, string type)
    {
        Name = name;
        Type = type;
    }

    // Method to display information about the nebula
    public void DisplayInfo()
    {
        Console.WriteLine($"Nebula: {Name}, Type: {Type}");
    }
}

// Class: Star
public class Star
{
    public string Name { get; set; }
    public string Type { get; set; }
    public double Brightness { get; set; } // Measured in Lumens

    // Constructor
    public Star(string name, string type, double brightness)
    {
        Name = name;
        Type = type;
        Brightness = brightness;
    }

    // Method to display information about the star
    public void DisplayInfo()
    {
        Console.WriteLine($"Star: {Name}, Type: {Type}, Brightness: {Brightness} Lumens");
    }
}

// Class: Planet
public class Planet
{
    public string Name { get; set; }
    public string Type { get; set; }
    public double Mass { get; set; } // Measured in Earth Mass

    // Constructor
    public Planet(string name, string type, double mass)
    {
        Name = name;
        Type = type;
        Mass = mass;
    }

    // Method to display information about the planet
    public void DisplayInfo()
    {
        Console.WriteLine($"Planet: {Name}, Type: {Type}, Mass: {Mass} Earth Mass");
    }
}

// Class: BlackHole
public class BlackHole
{
    public string Name { get; set; }
    public double Mass { get; set; } // Measured in Solar Mass

    // Constructor
    public BlackHole(string name, double mass)
    {
        Name = name;
        Mass = mass;
    }

    // Method to display information about the black hole
    public void DisplayInfo()
    {
        Console.WriteLine($"Black Hole: {Name}, Mass: {Mass} Solar Mass");
    }
}

// Class: SpaceProbe
public class SpaceProbe
{
    public string Name { get; set; }
    public string Mission { get; set; }

    // Constructor
    public SpaceProbe(string name, string mission)
    {
        Name = name;
        Mission = mission;
    }

    // Method to display information about the space probe
    public void DisplayInfo()
    {
        Console.WriteLine($"Space Probe: {Name}, Mission: {Mission}");
    }
}

// Class: Astronomer
public class Astronomer
{
    public string Name { get; set; }
    public string Specialization { get; set; }
    private List<string> discoveries; // List to hold discoveries

    // Constructor
    public Astronomer(string name, string specialization)
    {
        Name = name;
        Specialization = specialization;
        discoveries = new List<string>();
    }

    // Method to add discoveries
    public void AddDiscovery(string discovery) => discoveries.Add(discovery);

    // Method to display information about the astronomer
    public void DisplayInfo()
    {
        Console.WriteLine($"Astronomer: {Name}, Specialization: {Specialization}, Discoveries: {string.Join(", ", discoveries)}");
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Create a new universe
        Universe universe = new Universe("Milky Way");

        // Create galaxies
        Galaxy milkyWay = new Galaxy("Milky Way", "Spiral");
        milkyWay.AddStar(new Star("Sun", "G-Type", 1.0));
        milkyWay.AddStar(new Star("Sirius", "A-Type", 25.4));

        Galaxy andromeda = new Galaxy("Andromeda", "Spiral");

        // Create star clusters
        StarCluster pleiades = new StarCluster("Pleiades", 1000);

        // Create superclusters
        SuperCluster virgoSupercluster = new SuperCluster("Virgo Supercluster", 100);

        // Create nebulas
        Nebula orionNebula = new Nebula("Orion Nebula", "Emission");

        // Add objects to universe
        universe.AddGalaxy(milkyWay);
        universe.AddGalaxy(andromeda);
        universe.AddStarCluster(pleiades);
        universe.AddSuperCluster(virgoSupercluster);
        universe.AddNebula(orionNebula);

        // Create and display astronomers
        Astronomer astronomer1 = new Astronomer("Dr. Bilal", "Galactic Astronomy");
        astronomer1.AddDiscovery("Discovery of New Galaxy");

        Astronomer astronomer2 = new Astronomer("Dr. Basit", "Astrophysics");
        astronomer2.AddDiscovery("Black Hole Observation");

        // Display universe and astronomer information
        universe.DisplayUniverseInfo();
        astronomer1.DisplayInfo();
        astronomer2.DisplayInfo();
    }
}
 
