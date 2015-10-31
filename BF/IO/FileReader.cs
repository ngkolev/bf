using System;
using System.IO;

namespace BF.IO
{
    class FileReader
    {
        public FileReader(string filePath)
        {
            FilePath = filePath;
        }

        private string FilePath { get; set; }

        public string Read()
        {
            return File.ReadAllText(FilePath);
        }
    }
}