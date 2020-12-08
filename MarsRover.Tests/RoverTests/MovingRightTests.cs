using MarsRover.Domain.Model;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MovingRightTests
    {
        [Test]
        public void WhenMovingRightAndFacingNorthThenDirectionChangesToEast()
        {
            // Arrange 
            var rover = new Rover();
            rover.Orientation = Direction.North;

            // Act
            rover.MoveRight();

            // Assert
            var expectedDirection = Direction.East;
            Assert.AreEqual(expectedDirection, rover.Orientation);
        }

        [Test]
        public void WhenMovingRightAndFacingEastThenDirectionChangesToSouth()
        {
            // Arrange 
            var rover = new Rover();
            rover.Orientation = Direction.East;

            // Act
            rover.MoveRight();

            // Assert
            var expectedDirection = Direction.South;
            Assert.AreEqual(expectedDirection, rover.Orientation);
        }

        [Test]
        public void WhenMovingRightAndFacingSouthThenDirectionChangesToWest()
        {
            // Arrange 
            var rover = new Rover();
            rover.Orientation = Direction.South;

            // Act
            rover.MoveRight();

            // Assert
            var expectedDirection = Direction.West;
            Assert.AreEqual(expectedDirection, rover.Orientation);
        }

        [Test]
        public void WhenMovingRightAndFacingWestThenDirectionChangesToNorth()
        {
            // Arrange 
            var rover = new Rover();
            rover.Orientation = Direction.West;

            // Act
            rover.MoveRight();

            // Assert
            var expectedDirection = Direction.North;
            Assert.AreEqual(expectedDirection, rover.Orientation);
        }
    }
}