using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4_Solid_Ocp.Services
{
    public class JsonFileHandler : IFileHandler
    {
        public List<Character> ReadCharacters(string filePath) { /* JSON logic */ }
        public void WriteCharacters(string filePath, List<Character> characters) { /* JSON logic */ }
    }
    public class CSVFileManager : IFileManager
    {
        private string FileName { get; set; }
        public string[] ReadFile() { /* CSV read logic */ }
        public void WriteFile() { /* CSV write logic */ }
    }
}
