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

        [Test]
        public void WhenMovingForwardAndFacingNorthThenYIncreasesByOne()
        {
            // Arrange 
            var rover = new Rover();
            rover.Orientation = Direction.North;

            // Act
            rover.MoveForward();

            // Assert
            var expectedLocation = new Coordinate { X = 0, Y = 1 };
            Assert.AreEqual(expectedLocation, rover.Location);
        }

        [Test]
        public void WhenMovingForwardAndFacingSouthThenYDecreasesByOne()
        {
            // Arrange
            var rover = new Rover();
            rover.Orientation = Direction.South;
            
            // Act
            rover.MoveForward();
            
            // Assert
            var expectedLocation = new Coordinate { X = 0, Y = -1 };
            Assert.AreEqual(expectedLocation, rover.Location);
        }

        [Test]
        public void WhenMovingForwardAndFacingEastThenXIncreasesByOne()
        {
            // Arrange
            var rover = new Rover();
            rover.Orientation = Direction.East;

            // Act
            rover.MoveForward();

            // Assert
            var expectedLocation = new Coordinate { X = 1, Y = 0 };
            Assert.AreEqual(expectedLocation, rover.Location);
        }

        [Test]
        public void WhenMovingForwardAndFacingWestThenXDecreasesByOne()
        {
            // Arrange
            var rover = new Rover();
            rover.Orientation = Direction.West;

            // Act
            rover.MoveForward();

            // Assert
            var expectedLocation = new Coordinate { X = -1, Y = 0 };
            Assert.AreEqual(expectedLocation, rover.Location);
        }
    }
}