using System;

class Program
{
    static void Main(string[] args)
    {
        Soldier solidSnake = new Soldier("Solid Snake", 42, "Legendary Soldier", "FOXHOUND", "Special Forces Unit");
        solidSnake.Display();
        solidSnake.DisplaySoldierInfo();

        Weapon tranquilizerGun = new Weapon("Tranquilizer Gun", "Non-lethal");
        tranquilizerGun.Display();
    }
}
