]using System;

public class Organization
{
    public string Name { get; set; }
    public string Role { get; set; }

    public Organization(string name, string role)
    {
        Name = name;
        Role = role;
    }

    public void Display()
    {
        Console.WriteLine($"Organization: {Name}, Role: {Role}");
    }
}
