using Mars_Rover_Case.İnterfaces;
using System;

namespace Mars_Rover_Case
{
    public class Plateau : IPlateau
    {
        public Position PlateauPosition { get; }

        public Plateau(Position position)
        {
            PlateauPosition = position;
        }
    }
}
