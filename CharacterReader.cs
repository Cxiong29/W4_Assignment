using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w3_Solid_Srp.Models;
using w4_Solid_Ocp.Services;
//class responsible for reading character data from a CSV file.
//This class should include a method to find a specific character by name using LINQ.
namespace w3_Solid_Srp.Services
{
    public class CharacterReader
    {
        public List<Character> Characters { get; set; }
        private readonly IFileHandler fileHandler;

        public CharacterReader(IFileHandler fileHandler, string filePath)
        {
            Characters = new List<Character>();

            if (File.Exists(filePath))
            {
                using var reader = new StreamReader(filePath);
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line != null)
                    {
                        var values = line.Split(',');
                        if (values.Length >= 5)
                        {
                            var character = new Character(
                                values[0], // Name
                                values[1], // Profession
                                int.Parse(values[2]), // Level
                                int.Parse(values[3]), // HitPoints
                                values[4] // Equipment
                            );
                            Characters.Add(character);
                        }
                    }
                }
            }
        }

        public Character? FindCharacterLINQ(string name)
        {
            var character = Characters.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (character != null)
            {
                return character;
            }
            else
            {
                Console.WriteLine($"Character with name '{name}' not found.");
                return null;
            }
        }
    }
}

   


       