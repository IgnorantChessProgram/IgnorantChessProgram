using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICP
{
    public struct Move
    {
        public Coordinate StartCoordinate { get; }
        public Coordinate EndCoordinate { get; }

        public TimeSpan TimeLeft { get; }

        public Move(Coordinate startCoordinate, Coordinate endCoordinate, TimeSpan timeLeft)
        {
            StartCoordinate = startCoordinate;
            EndCoordinate = endCoordinate;
            TimeLeft = timeLeft;
        }
    }
}
