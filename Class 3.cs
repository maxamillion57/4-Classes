]using System;

public class Character : Organization
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Character(string name, int age, string orgName, string role) : base(orgName, role)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
        base.Display();
    }
}
