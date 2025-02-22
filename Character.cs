using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w3_Solid_Srp.Services;
using w3_Solid_Srp.Models;



namespace w3_Solid_Srp.Models
{
    public class Character
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public string HP { get; set; }
        public string Equipment { get; set; }

        public Character()
        {
            Console.WriteLine("Executing default constructor");
            Name = "Default";
        }

        public Character(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} {Class} {Level} {HP} {Equipment}";
        }

        public void AddEquipment(string equipment)
        {
            Equipment = equipment;
        }

        public void LevelUPCharacter(string name)
        {
            CharacterManager characterManager = new CharacterManager();
            Character character = characterManager.FindCharacter(name);
            if (character != null)
            {
                character.Level++;
            }
        }

        public void DisplayCharacter()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"Equipment: {Equipment}");
            Console.WriteLine("-----------------------");
        }
    }

}
