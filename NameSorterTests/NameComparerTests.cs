using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter;

namespace NameSorterTests
{
    [TestClass]
    public class NameComparerTests
    {
        private NameComparer _comparer;

        [TestInitialize]
        public void Setup()
        {
            _comparer = new NameComparer();
        }

        [TestMethod]
        public void TestCompare_DifferentLastNames_ReturnsNonZero()
        {
            var person1 = new Person("John Doe");
            var person2 = new Person("Jane Smith");
            var result = _comparer.Compare(person1, person2);

            Assert.IsTrue(result < 0); // Since "Doe" comes before "Smith"
        }

        [TestMethod]
        public void TestCompare_SameLastNamesDifferentGivenNames_ReturnsNonZero()
        {
            var person1 = new Person("John Smith");
            var person2 = new Person("Jane Smith");
            var result = _comparer.Compare(person1, person2);

            Assert.IsTrue(result > 0); // Since "John" comes after "Jane"
        }

        [TestMethod]
        public void TestCompare_SameLastAndFirstNamesDifferentMiddleNames_ReturnsNonZero()
        {
            var person1 = new Person("John A Smith");
            var person2 = new Person("John B Smith");
            var result = _comparer.Compare(person1, person2);

            Assert.IsTrue(result < 0); // Since "A" comes before "B"
        }

        [TestMethod]
        public void TestCompare_IdenticalNames_ReturnsZero()
        {
            var person1 = new Person("John Smith");
            var person2 = new Person("John Smith");
            var result = _comparer.Compare(person1, person2);

            Assert.AreEqual(0, result);
        }
    }
}
