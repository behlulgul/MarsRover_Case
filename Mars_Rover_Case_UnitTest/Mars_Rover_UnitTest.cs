using Mars_Rover_Case;
using Mars_Rover_Case.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Mars_Rover_Case_UnitTest
{
    [TestClass]
    public class Mars_Rover_Case_UnitTest
    {

            [TestMethod]
            public void CheckRoverOne()
            {
                Plateau plateau = new Plateau(new Position(5, 5));
                Rover roverOne = new Rover(plateau, new Position(1, 2), Directions.N);
                roverOne.GoTo("LMLMLMLMM");
                Assert.AreEqual(roverOne.CurrentPosition(), "1 3 N");
            }

            [TestMethod]
            public void CheckRoverTwo()
            {
                Plateau plateau = new Plateau(new Position(5, 5));
                Rover roverTwo = new Rover(plateau, new Position(3, 3), Directions.E);
                roverTwo.GoTo("MMRMMRMRRM");
                Assert.AreEqual(roverTwo.CurrentPosition(), "5 1 E");
        }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void InvalidOutput()
            {
                Plateau plateau = new Plateau(new Position(5, 5));
                Rover firstRover = new Rover(plateau, new Position(1, 2), Directions.N);
                firstRover.GoTo("RRYTMLL");
            }
        }
}
