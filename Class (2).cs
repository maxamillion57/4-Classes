using System;

public class Soldier : Character
{
    public string Rank { get; set; }

    public Soldier(string name, int age, string rank, string orgName, string role) : base(name, age, orgName, role)
    {
        Rank = rank;
    }

    public void DisplaySoldierInfo()
    {
        Console.WriteLine($"Rank: {Rank}");
    }
}
