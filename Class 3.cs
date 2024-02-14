﻿using System;

public class Character
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Character(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
