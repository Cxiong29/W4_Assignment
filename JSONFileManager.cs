using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;

namespace w4_Solid_Ocp.Services
{
    internal class JSONFileManager : IFileManager
    {
        private string _json;
        public JSONFileManager(string fileName)
        {
            _json = File.ReadAllText(fileName);
        }

        public string[] ReadFile()
        {
            var characters = JsonSerializer.Deserialize<List<Character>>(_json);
            return characters.Select(c => c.Name).ToArray();
        }

        public void WriteFile()
        {
            Console.WriteLine("Writing");
        }
    }

    public interface IFileManager
    {
        string[] ReadFile();
        void WriteFile();
    }

    public class Character
    {
        public string Name { get; set; }
    }
}
