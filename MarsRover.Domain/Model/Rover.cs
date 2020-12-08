using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Domain.Model
{
    public class Rover
    {
        public Direction Orientation { get; set; }
        public Coordinate Location { get; set; }
       
        public Rover()
        {
            Orientation = Direction.North;
            Location = new Coordinate() { X = 0, Y = 0 };
        }

        public void MoveForward()
        {
            if (Orientation == Direction.North)
                Location = Location.AdjustYBy(1);
            if (Orientation == Direction.South)
                Location = Location.AdjustYBy(-1);
            if (Orientation == Direction.East)
                Location = Location.AdjustXBy(1);
            if (Orientation == Direction.West)
                Location = Location.AdjustXBy(-1);
        }

        public void MoveBackward()
        {
            if (Orientation == Direction.North)
                Location = Location.AdjustYBy(-1);
            if (Orientation == Direction.South)
                Location = Location.AdjustYBy(1);
            if (Orientation == Direction.East)
                Location = Location.AdjustXBy(-1);
            if (Orientation == Direction.West)
                Location = Location.AdjustXBy(1);
        }

        public void MoveLeft()
        {
            if (Orientation == Direction.North)
            {
                Orientation = Direction.West;
            }
            else if (Orientation == Direction.West)
            {
                Orientation = Direction.South;
            }
            else if (Orientation == Direction.South)
            {
                Orientation = Direction.East;
            }
            else if (Orientation == Direction.East)
            {
                Orientation = Direction.North;
            }
        }
        public void MoveRight()
        {
            if (Orientation == Direction.North)
            {
                Orientation = Direction.East;
            }
            else if (Orientation == Direction.West)
            {
                Orientation = Direction.North;
            }
            else if (Orientation == Direction.South)
            {
                Orientation = Direction.West;
            }
            else if (Orientation == Direction.East)
            {
                Orientation = Direction.South;
            }
        }
    }
}