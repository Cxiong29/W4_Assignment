using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4_Solid_Ocp.Services
{
    public class CSVFileManager : IFileManager
    {
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        public CSVFileManager(string fileName)
        {
            this._fileName = fileName;
        }
        public string[] Read()
        {
            return System.IO.File.ReadAllLines(_fileName);
        }
        public void WriteFile()
        {
            Console.WriteLine("Writing");
        }
    }
    
    
}
