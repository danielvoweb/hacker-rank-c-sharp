using System.Collections.Generic;
using NUnit.Framework;

namespace HackerRank.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var input = new List<int> {
                73,
                67,
                38,
                33,
            };

            // Act
            var actual = GradingStudents.gradingStudents(input);

            // Assert
            Assert.That(actual, Is.EquivalentTo(new List<int> {
                75,
                67,
                40,
                33,
            }));
        }
    }
}