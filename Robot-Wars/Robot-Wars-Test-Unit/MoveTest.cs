using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars;

namespace RobotWars.TestUnit
{
    [TestClass]
    public class MoveForward
    {
        public Arena Arena = new Arena("5 5");
        public Robot Robot;

        [TestMethod]
        public void MoveForwardFromZeroZeroNorth()
        {
            Robot = new Robot("0 0 N", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "0 1 N");
        }

        [TestMethod]
        public void MoveForwardFromZeroZeroEast()
        {
            Robot = new Robot("0 0 E", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "1 0 E");
        }

        [TestMethod]
        public void DoNotMoveForwardFromZeroZeroSouth()
        {
            Robot = new Robot("0 0 S", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "0 0 S");
        }

        [TestMethod]
        public void DoNotMoveForwardFromZeroZeroWest()
        {
            Robot = new Robot("0 0 W", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "0 0 W");
        }

        [TestMethod]
        public void DoNotMoveForwardFromZeroFiveNorth()
        {
            Robot = new Robot("0 5 N", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "0 5 N");
        }

        [TestMethod]
        public void MoveForwardFromZeroFiveEast()
        {
            Robot = new Robot("0 5 E", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "1 5 E");
        }

        [TestMethod]
        public void MoveForwardFromZeroFiveSouth()
        {
            Robot = new Robot("0 5 S", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "0 4 S");
        }

        [TestMethod]
        public void DoNotMoveForwardFromZeroFiveWest()
        {
            Robot = new Robot("0 5 W", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "0 5 W");
        }

        [TestMethod]
        public void DoNotMoveForwardFromFiveFiveNorth()
        {
            Robot = new Robot("5 5 N", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "5 5 N");
        }

        [TestMethod]
        public void DoNotMoveForwardFromFiveFiveEast()
        {
            Robot = new Robot("5 5 E", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "5 5 E");
        }

        [TestMethod]
        public void MoveForwardFromFiveFiveSouth()
        {
            Robot = new Robot("5 5 S", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "5 4 S");
        }

        [TestMethod]
        public void MoveForwardFromFiveFiveWest()
        {
            Robot = new Robot("5 5 W", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "4 5 W");
        }

        [TestMethod]
        public void MoveForwardFromFiveZeroNorth()
        {
            Robot = new Robot("5 0 N", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "5 1 N");
        }

        [TestMethod]
        public void DoNotMoveForwardFromFiveZeroEast()
        {
            Robot = new Robot("5 0 E", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "5 0 E");
        }

        [TestMethod]
        public void DoNotMoveForwardFromFiveZeroSouth()
        {
            Robot = new Robot("5 0 S", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "5 0 S");
        }

        [TestMethod]
        public void MoveForwardFromFiveZeroWest()
        {
            Robot = new Robot("5 0 W", "M", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "4 0 W");
        }
    }

    [TestClass]
    public class MoveLeft
    {
        public Arena Arena = new Arena("5 5");
        public Robot Robot;

        [TestMethod]
        public void MoveLeftFromNorth()
        {
            Robot = new Robot("0 0 N", "L", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "0 0 W");
        }

        [TestMethod]
        public void MoveLeftFromEast()
        {
            Robot = new Robot("0 0 E", "L", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "0 0 N");
        }

        [TestMethod]
        public void MoveLeftFromSouth()
        {
            Robot = new Robot("0 0 S", "L", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "0 0 E");
        }

        [TestMethod]
        public void MoveLeftFromWest()
        {
            Robot = new Robot("0 0 W", "L", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "0 0 S");
        }
    }

    [TestClass]
    public class MoveRight
    {
        public Arena Arena = new Arena("5 5");
        public Robot Robot;

        [TestMethod]
        public void MoveRightFromNorth()
        {
            Robot = new Robot("0 0 N", "R", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "0 0 E");
        }

        [TestMethod]
        public void MoveRightFromEast()
        {
            Robot = new Robot("0 0 E", "R", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "0 0 S");
        }

        [TestMethod]
        public void MoveRightFromSouth()
        {
            Robot = new Robot("0 0 S", "R", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "0 0 W");
        }

        [TestMethod]
        public void MoveRightFromWest()
        {
            Robot = new Robot("0 0 W", "R", Arena.X, Arena.Y);
            Robot.Move();
            Assert.AreEqual(Robot.Message, "0 0 N");
        }
    }
}
