using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Laba.Tests
{
    [TestFixture]
    public class SortingAlgorithmTests
    {
        [Test]
        public void SortNumbers_ReturnsSortedNumbers()
        {
            // Arrange
            var algorithm = new SortingAlgorithm();
            int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };

            // Act
            var result = algorithm.SortNumbers(numbers);

            // Assert
            ClassicAssert.AreEqual(new List<int> { 9, 6, 5, 5, 5, 4, 3, 3, 2, 1, 1 }, result);
        }

        [Test]
        public void SortNumbers_AllSameNumbers_ReturnsSameList()
        {
            // Arrange
            var algorithm = new SortingAlgorithm();
            int[] numbers = { 2, 2, 2, 2, 2 };

            // Act
            var result = algorithm.SortNumbers(numbers);

            // Assert
            ClassicAssert.AreEqual(new List<int> { 2, 2, 2, 2, 2 }, result);
        }

        [Test]
        public void SortNumbers_EmptyArray_ReturnsEmptyList()
        {
            // Arrange
            var algorithm = new SortingAlgorithm();
            int[] numbers = new int[0];

            // Act
            var result = algorithm.SortNumbers(numbers);

            // Assert
            ClassicAssert.IsEmpty(result);
        }
        

        [Test]
        public void SortNumbers_SingleElementArray_ReturnsSameList()
        {
            // Arrange
            var algorithm = new SortingAlgorithm();
            int[] numbers = { 1 };

            // Act
            var result = algorithm.SortNumbers(numbers);

            // Assert
            ClassicAssert.AreEqual(new List<int> { 1 }, result);
        }
    }
}
