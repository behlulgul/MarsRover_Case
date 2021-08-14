using Mars_Rover_Case.Actions;
using Mars_Rover_Case.Constant;
using Mars_Rover_Case.Enums;
using Mars_Rover_Case.İnterfaces;
using Mars_Rover_Case.Interfaces;
using System;
using System.Collections.Generic;

namespace Mars_Rover_Case
{
    public class Rover : IObject
    {
        public IPlateau PlateauOfObject { get; set; }
        public IPosition PositionOfObject { get; set; }
        public Directions DirectionOfObject { get; set; }
        public Movement _movement { get; set; }


        public Rover(IPlateau plateauOfRover, IPosition positionOfRover, Directions directionOfRover)
        {
            PlateauOfObject = plateauOfRover;
            PositionOfObject = positionOfRover;
            DirectionOfObject = directionOfRover;

            _movement = new Movement(this);
        }

        public void GoTo(string commands)
        {
            _movement.Move(commands);

            if (PositionOfObject.positionX > PositionMinMax.MaxPositionX || PositionOfObject.positionY > PositionMinMax.MaxPositionY ||
                PositionOfObject.positionX < PositionMinMax.MinPositionX || PositionOfObject.positionY < PositionMinMax.MinPositionY)
            {
                Console.WriteLine("You are out of plateau !!");
            }
        }
       
        public string CurrentPosition()
        {
            return PositionOfObject.positionX + " " + PositionOfObject.positionY + " " + DirectionOfObject;
        }

    }
}
