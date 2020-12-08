using MarsRover.Domain.Model;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MovingLeftTests
    {
        [Test]
        public void WhenMovingLeftAndFacingNorthThenDirectionChangesToWest()
        {
            // Arrange 
            var rover = new Rover();
            rover.Orientation = Direction.North;

            // Act
            rover.MoveLeft();

            // Assert
            var expectedDirection = Direction.West;
            Assert.AreEqual(expectedDirection, rover.Orientation);
        }

        [Test]
        public void WhenMovingLeftAndFacingEastThenDirectionChangesToNorth()
        {
            // Arrange 
            var rover = new Rover();
            rover.Orientation = Direction.South;

            // Act
            rover.MoveLeft();

            // Assert
            var expectedDirection = Direction.East;
            Assert.AreEqual(expectedDirection, rover.Orientation);
        }

        [Test]
        public void WhenMovingLeftAndFacingSouthThenDirectionChangesToEast()
        {
            // Arrange 
            var rover = new Rover();
            rover.Orientation = Direction.South;

            // Act
            rover.MoveLeft();

            // Assert
            var expectedDirection = Direction.East;
            Assert.AreEqual(expectedDirection, rover.Orientation);
        }

        [Test]
        public void WhenMovingLeftAndFacingWestThenDirectionChangesToSouth()
        {
            // Arrange 
            var rover = new Rover();
            rover.Orientation = Direction.West;

            // Act
            rover.MoveLeft();

            // Assert
            var expectedDirection = Direction.South;
            Assert.AreEqual(expectedDirection, rover.Orientation);
        }
    }
}