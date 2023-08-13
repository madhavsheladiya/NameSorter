using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter;
using System.Collections.Generic;
using System.IO;

namespace NameSorterTests
{
    [TestClass]
    public class FileServiceTests
    {
        private IFileService _fileService;

        [TestInitialize]
        public void Setup()
        {
            _fileService = new FileService();
        }

        [TestMethod]
        public void TestReadFile_ValidFilePath_ReturnsListOfNames()
        {
            // Setup
            var filePath = "testNames.txt";
            File.WriteAllLines(filePath, new List<string> { "John Doe" });

            // Act
            var result = _fileService.ReadFile(filePath);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("John Doe", result[0]);

            // Cleanup
            File.Delete(filePath);
        }
    }
}
