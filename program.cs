using System;

class Program
{
    static void Main(string[] args)
    {
        Character solidSnake = new Character("Solid Snake", 42);
        solidSnake.Display();

        Organization foxhound = new Organization("FOXHOUND", "Special Forces Unit");
        foxhound.Display();

        Soldier bigBoss = new Soldier("Big Boss", 79, "Legendary Soldier");
        bigBoss.Display();
        bigBoss.DisplaySoldierInfo();
       
        Weapon tranquilizerGun = new Weapon("Tranquilizer Gun", "Non-lethal");
        tranquilizerGun.Display();

        Weapon hfblade = new Weapon("High Frequency Blade", "Lethal");
        hfblade.Display();
    }
}
