﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4_Solid_Ocp.Services
{
    public interface IFileHandler
    {
        List<Character> ReadCharacters(string filepath);
        void WriteCharacters(string filePath, List<Character> characters);
    }
}
