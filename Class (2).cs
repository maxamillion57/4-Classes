using System;

public class Soldier : Character
{
    public string Rank { get; set; }

    public Soldier(string name, int age, string rank) : base(name, age)
    {
        Rank = rank;
    }

    public void DisplaySoldierInfo()
    {
        Console.WriteLine($"Rank: {Rank}");
    }
}
