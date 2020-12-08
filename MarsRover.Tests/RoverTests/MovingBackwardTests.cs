using MarsRover.Domain.Model;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MovingBackwardTests
    {
        [Test]
        public void WhenMovingBackwardAndFacingNorthThenYDecreasesByOne()
        {
            // Arrange 
            var rover = new Rover();
            rover.Orientation = Direction.North;

            // Act
            rover.MoveBackward();

            // Assert
            var expectedLocation = new Coordinate { X = 0, Y = -1 };
            Assert.AreEqual(expectedLocation, rover.Location);
        }

        [Test]
        public void WhenMovingBackwardAndFacingSouthThenYIncreasesByOne()
        {
            // Arrange
            var rover = new Rover();
            rover.Orientation = Direction.South;

            // Act
            rover.MoveBackward();

            // Assert
            var expectedLocation = new Coordinate { X = 0, Y = 1 };
            Assert.AreEqual(expectedLocation, rover.Location);
        }

        [Test]
        public void WhenMovingBackwardAndFacingEastThenXDecreasesByOne()
        {
            // Arrange
            var rover = new Rover();
            rover.Orientation = Direction.East;

            // Act
            rover.MoveBackward();

            // Assert
            var expectedLocation = new Coordinate { X = -1, Y = 0 };
            Assert.AreEqual(expectedLocation, rover.Location);
        }

        [Test]
        public void WhenMovingBackwardAndFacingWestThenXIncreasesByOne()
        {
            // Arrange
            var rover = new Rover();
            rover.Orientation = Direction.West;

            // Act
            rover.MoveBackward();

            // Assert
            var expectedLocation = new Coordinate { X = 1, Y = 0 };
            Assert.AreEqual(expectedLocation, rover.Location);
        }
    }
}
