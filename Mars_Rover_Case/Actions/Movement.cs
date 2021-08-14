using Mars_Rover_Case.Enums;
using Mars_Rover_Case.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover_Case.Actions
{
    public class Movement
    {
        Dictionary<char, Action> CommandList;
        private readonly IObject _object;
        public Movement(Rover rover)
        {
            CommandList = new Dictionary<char, Action>
            {
                { 'L', ToLeft },
                { 'R', ToRight },
                { 'M', MoveForward }
            };

            _object = rover;
        }
        private void ToRight()
        {
            _object.DirectionOfObject = (_object.DirectionOfObject + 1) > Directions.W ? Directions.N : _object.DirectionOfObject + 1;
        }
        private void ToLeft()
        {
            _object.DirectionOfObject = (_object.DirectionOfObject - 1) < Directions.N ? Directions.W : _object.DirectionOfObject - 1;
        }

        private void MoveForward()
        {
            if (_object.DirectionOfObject == Directions.N)
            {
                _object.PositionOfObject.positionY++;
            }
            else if (_object.DirectionOfObject == Directions.S)
            {
                _object.PositionOfObject.positionY--;
            }
            else if (_object.DirectionOfObject == Directions.W)
            {
                _object.PositionOfObject.positionX--;
            }
            else if (_object.DirectionOfObject == Directions.E)
            {
                _object.PositionOfObject.positionX++;
            }
        }

        public void Move(string commands)
        {
            foreach (var command in commands)
            {

                if (!CommandList.ContainsKey(command))
                {
                    throw new ArgumentException(string.Format("Invalid command: {0}", command));
                }

                CommandList[command]();

            }
        }
    }
}
