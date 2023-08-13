using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    public interface IFileService
    {
        List<string> ReadFile(string filePath);
        void WriteFile(string filePath, List<string> content);
    }
}

