using MarsRover.Domain.Model;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MovingLeftTests
    {
        [TestCase(Direction.North, Direction.West, TestName = "WhenMovingLeftAndFacingNorthThenRoverFacesWest")]
        [TestCase(Direction.West, Direction.South, TestName = "WhenMovingLeftAndFacingWestThenRoverFacesSouth")]
        [TestCase(Direction.East, Direction.North, TestName = "WhenMovingLeftAndFacingEastThenRoverFacesNorth")]
        [TestCase(Direction.South, Direction.East, TestName = "WhenMovingLeftAndFacingSouthThenRoverFacesEast")]

        public void WhenTurningLeftThenRoverFacesTheCorrectDirection(Direction startDirection, Direction expectedDirection)
        {
            // Arrange 
            var rover = new Rover();
            rover.Orientation = startDirection;

            // Act
            rover.MoveLeft();

            // Assert
            Assert.AreEqual(expectedDirection, rover.Orientation);
        }
    }
}