using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w2_EnhanncedFileIO.Services;

namespace w2_EnhanncedFileIO
{
    public class Menu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1. Display Characters");
            Console.WriteLine("2. Find Character");
            Console.WriteLine("3. Add Character");
            Console.WriteLine("4. Level Up Character");
            Console.WriteLine("-----------------------");
        }
        public static void DisplayCharacters(string name, string profession, string level, string hitPoints, string equipment)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Job: {profession}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Hit Points: {hitPoints}");
            Console.WriteLine($"Equipment: {equipment}");
            Console.WriteLine("-----------------------");
        }

        public static void FindCharacter(CharacterManager manager)
        {
            Console.WriteLine("Enter Name Of Character: ");
            string? characterName = Console.ReadLine();
            if (!string.IsNullOrEmpty(characterName))
            {
                var character = manager.FindCharacter(characterName);
                if (character != null)
                {
                    DisplayCharacters(character.Name, character.Profession, character.Level.ToString(), character.HitPoints.ToString(), character.Equipment);
                }
                else
                {
                    Console.WriteLine("Character Not Found");
                }
            }
           
        }
        public static void AddCharacter(string name)
        {
            using (StreamWriter writer = new StreamWriter("input.csv", true))
            {
                writer.WriteLine(name);
            }
        }
    }
}

public class CharacterManager
{
    public Character FindCharacter(string name)
    {
        return new Character(name, profession, level, hipPoint, equipment);
    }

    public static void DisplayCharacters() { }
    public static void FindCharacter() { }
    public static void AddCharacter() { }
    public static void LevelUpCharacter() { }
}

public class Character
{
    public Character(string name, string profession, int level, int hitPoints, string equipment)
    {
        Name = name;
        Profession = profession;
        Level = level;
        HitPoints = hitPoints;
        Equipment = equipment;
    }

    public string Name { get; set; }
    public string Profession { get; set; }
    public int Level { get; set; }
    public int HitPoints { get; set; }
    public string Equipment { get; set; }
}
