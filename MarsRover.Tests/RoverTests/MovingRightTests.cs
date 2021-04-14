using MarsRover.Domain.Model;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MovingRightTests
    {
        [TestCase(Direction.North, Direction.East, TestName = "WhenMovingRightAndFacingNorthThenRoverFacesEast")]
        [TestCase(Direction.West, Direction.North, TestName = "WhenMovingRightAndFacingWestThenRoverFacesNorth")]
        [TestCase(Direction.East, Direction.South, TestName = "WhenMovingRightAndFacingEastThenRoverFacesSouth")]
        [TestCase(Direction.South, Direction.West, TestName = "WhenMovingRightAndFacingSouthThenRoverFacesWest")]

        public void WhenTurningRightThenRoverFacesTheCorrectDirection(Direction startDirection, Direction expectedDirection)
        {
            // Arrange 
            var rover = new Rover();
            rover.Orientation = startDirection;

            // Act
            rover.MoveRight();

            // Assert
            Assert.AreEqual(expectedDirection, rover.Orientation);
        }
    }
}