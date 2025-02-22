using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w4_Solid_Ocp.Services;
using w3_Solid_Srp.Services;
using w3_Solid_Srp.Models;


namespace w4_Solid_Ocp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IFileHandler csvFileHandler = new CsvFileHandler();
            var characterWriter = new CharacterWriter(csvFileHandler);

            List<Character> characters = new List<Character>
                {
                    new Character {Name = "John", Profession = "Warrior", Level = 1, HitPoints = 100, Equipment = "Sword"},
                    new Character {Name = "Jane", Profession = "Mage", Level = 2, HitPoints = 80, Equipment = "Staff"},
                    new Character {Name = "Joe", Profession = "Rogue", Level = 3, HitPoints = 90, Equipment = "Dagger"}
                };

            characterWriter.WriteCharacters(characters, "characters.csv");
            IFileHandler jsonFileHandler = new JsonFileHandler();
            var characterWriter2 = new CharacterWriter(jsonFileHandler);

            characterWriter2.WriteCharacters(characters, "characters.json");
            // var context = new DataContext();
            // var character = context.Characters;
            //
            // foreach (var c in character)
            // {
            //     Console.WriteLine(c.Name);
            // }
        }
    }
}
