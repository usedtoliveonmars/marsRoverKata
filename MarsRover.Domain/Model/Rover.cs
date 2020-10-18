using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Domain.Model
{
    public class Rover
    {
        public Direction Orientation { get; set; }
        public Coordinate Location { get; set; }
    }
}
