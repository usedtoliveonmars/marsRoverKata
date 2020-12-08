using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Domain.Model
{
    public struct Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate AdjustXBy(int x)
        {
            return new Coordinate { X = this.X + x, Y = this.Y };
        }

        public Coordinate AdjustYBy(int y)
        {
            return new Coordinate { X = this.X, Y = this.Y + y };
        }
    }
}
