using Mars_Rover_Case.Constant;
using Mars_Rover_Case.Enums;
using System;

namespace Mars_Rover_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Plateau plateau = new Plateau(new Position(PositionMinMax.MaxPositionX, PositionMinMax.MaxPositionY));
            //Rover 1
            Rover roverOne = new Rover(plateau, new Position(1, 2), Directions.N);
            roverOne.GoTo("LMLMLMLMM");//LMLMLMLMM

            //Rover 2
            Rover roverTwo = new Rover(plateau, new Position(3, 3), Directions.E);
            roverTwo.GoTo("MMRMMRMRRM");

            Console.WriteLine(roverOne.CurrentPosition());  
            Console.WriteLine(roverTwo.CurrentPosition());  

        }
    }
}
