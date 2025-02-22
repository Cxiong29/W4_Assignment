using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4_Solid_Ocp.Services
{
    public class CsvFileHandler : IFileHandler
    {
        public List<Character> ReadCharacters(string filePath)
        {
            return new List<Character>();
        }

        public void WriteCharacters(string filePath, List<Character> characters)
        {
            using var writer = new StreamWriter(filePath);
            foreach (var character in characters)
            {
                writer.WriteLine($"{character.Name},{character.Class},{character.Level},{character.HP},{character.Equipment}");
            }
        }
    }

}
