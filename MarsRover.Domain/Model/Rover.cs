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
    }
}