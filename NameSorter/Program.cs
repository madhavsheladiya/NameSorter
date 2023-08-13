using System;
using System.Linq;

namespace NameSorter
{
    public class Program
    {
        private static readonly IFileService _fileService = new FileService();
        private static readonly INameSorterService _nameSorter = new NameSorterService();

        public static void Main(string[] args)
        {
            var filePath = args[0];
            var names = _fileService.ReadFile(filePath).Select(name => new Person(name)).ToList();

            var sortedNames = _nameSorter.SortNames(names).Select(person => person.FullName).ToList();

            sortedNames.ForEach(Console.WriteLine);

            _fileService.WriteFile("sorted-names-list.txt", sortedNames);
        }
    }
}