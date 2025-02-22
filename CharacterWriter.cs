using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using w3_Solid_Srp.Models;
using w4_Solid_Ocp.Services;
//class responsible for writing character data to a CSV file.
namespace w3_Solid_Srp.Services
{
    public class CharacterWriter
    {
        private readonly IFileHandler _fileHandler;

        public CharacterWriter(IFileHandler fileHandler)
        {
            _fileHandler = fileHandler;
        }

        public void WriteCharacters(List<Character> characters, string filePath)
        {
            _fileHandler.WriteCharacters(filePath, characters);
            Console.WriteLine("Characters written to file.");
        }
    }
}
