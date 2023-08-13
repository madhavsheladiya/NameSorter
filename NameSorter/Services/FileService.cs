using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NameSorter
{
    public class FileService : IFileService
    {
        public List<string> ReadFile(string filePath)
        {
            return new List<string>(File.ReadAllLines(filePath));
        }

        public void WriteFile(string filePath, List<string> content)
        {
            File.WriteAllLines(filePath, content);
        }
    }

}