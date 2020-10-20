using MarsRover.Domain.Model;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class RoverTests
    {
        [Test]
        public void TheRoverIsFacingNorth()
        {
            // Arrange and Act
            var rover = new Rover();

            // Assert
            Assert.AreEqual(Direction.North, rover.Orientation);
        }

        [Test]
        public void TheRoverIsAt00()
        {
            // Arrange and Act
            var rover = new Rover();

            var expectedLocation = new Coordinate { X = 0, Y = 0 };
            Assert.AreEqual(expectedLocation, rover.Location);
        }
    }
}