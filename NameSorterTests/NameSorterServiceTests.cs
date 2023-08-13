using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter;
using System.Collections.Generic;

namespace NameSorterTests
{
    [TestClass]
    public class NameSorterServiceTests
    {
        private NameSorterService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new NameSorterService();
        }

        [TestMethod]
        public void TestSortNames_BasicScenario_ReturnsSortedNames()
        {
            var names = new List<Person>
            {
                new Person("John Smith"),
                new Person("Jane Doe")
            };

            var sortedNames = _service.SortNames(names);

            var expected = new List<Person>
            {
                new Person("Jane Doe"),
                new Person("John Smith")
            };

            CollectionAssert.AreEqual(expected, sortedNames);
        }

        [TestMethod]
        public void TestSortNames_SameLastName_ReturnsSortedNames()
        {
            var names = new List<Person>
            {
                new Person("John Smith"),
                new Person("Jane Smith")
            };

            var sortedNames = _service.SortNames(names);

            var expected = new List<Person>
            {
                new Person("Jane Smith"),
                new Person("John Smith")
            };

            CollectionAssert.AreEqual(expected, sortedNames);
        }

        [TestMethod]
        public void TestSortNames_MultipleGivenNames_ReturnsSortedNames()
        {
            var names = new List<Person>
            {
                new Person("John A Smith"),
                new Person("Jane Z Smith"),
                new Person("Jane A Smith")
            };

            var sortedNames = _service.SortNames(names);

            var expected = new List<Person>
            {
                new Person("Jane A Smith"),
                new Person("John A Smith"),
                new Person("Jane Z Smith")
            };

            CollectionAssert.AreEqual(expected, sortedNames);
        }

        [TestMethod]
        public void TestSortNames_ComplexOrdering_ReturnsSortedNames()
        {
            var names = new List<Person>
            {
                new Person("John Date"),
                new Person("Jane Cherry"),
                new Person("John Banana"),
                new Person("Jane Apple")
            };

            var sortedNames = _service.SortNames(names);

            var expected = new List<Person>
            {
                new Person("Jane Apple"),
                new Person("John Banana"),
                new Person("Jane Cherry"),
                new Person("John Date")
            };

            CollectionAssert.AreEqual(expected, sortedNames);
        }
    }
}
