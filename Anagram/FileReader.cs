using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class FileReader
    {
        public async static Task<string[]> ReadFile() => await File.ReadAllLinesAsync(@"C:\Users\Josue Pujols\OneDrive\Escritorio\Practica SCRUM\Practica 2\words.txt");
    }
}
