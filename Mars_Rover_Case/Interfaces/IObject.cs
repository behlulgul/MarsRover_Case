using Mars_Rover_Case.Enums;
using Mars_Rover_Case.İnterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover_Case.Interfaces
{
    public interface IObject
    {
        IPlateau PlateauOfObject { get; set; }
        IPosition PositionOfObject { get; set; }
        Directions DirectionOfObject { get; set; }
        void GoTo(string commands);
    }
}
