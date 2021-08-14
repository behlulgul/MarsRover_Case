using Mars_Rover_Case.İnterfaces;
using System;

namespace Mars_Rover_Case
{
    public class Position : IPosition
    {
        public int positionX { get; set; }
        public int positionY { get; set; }

        public Position(int x, int y)
        {
            positionX = x;
            positionY = y;
        }
    }
}
