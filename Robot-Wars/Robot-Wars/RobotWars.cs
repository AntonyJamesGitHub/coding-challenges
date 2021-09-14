using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    //ASSUMPTIONS
    //Only 2 robots can enter an arena at the same time
    //The first robot to hit the other robot is the winner
    //If a robot attempts to move outside of the arena the move is ignored
    //There is a current limitation of two robots per game
    //Any number of instructions can be provided for each robot, and the number of instructions for each robot can be different

    //ADDITIONAL NOTES
    //If I were to spend more time on this challenge I'd look at validating input, handling exceptions and including some logging.

    public class RobotWars
    {   
        static void Main(string[] args)
        {
            string arenaInput = Console.ReadLine();
            string robotAPosition = Console.ReadLine();
            string robotAInstructions = Console.ReadLine();
            string robotBPosition = Console.ReadLine();
            string robotBInstructions = Console.ReadLine();
            
            //I'm aware that newing up objects in this way may not be the ideal solution in terms of maintainability, however I've only just started reading a book on design patterns so I'll be looking to change this once I've gained more knowledge
            Arena arena = new Arena(arenaInput);
            Robot robotA = new Robot(robotAPosition, robotAInstructions, arena.X, arena.Y);
            Robot robotB = new Robot(robotBPosition, robotBInstructions, arena.X, arena.Y);

            int i = 0;
            while ((i < robotA.InstructionsLength || i < robotB.InstructionsLength))
            {
                if (i < robotA.InstructionsLength) robotA.Move();
                if (robotA.XPosition == robotB.XPosition && robotA.YPosition == robotB.YPosition)
                {
                    arena.Winner = "A";
                    break;
                }
                if (i < robotB.InstructionsLength) robotB.Move();
                if (robotA.XPosition == robotB.XPosition && robotA.YPosition == robotB.YPosition)
                {
                    arena.Winner = "B";
                    break;
                }
                i++;
            }

            Console.WriteLine(robotA.Message);
            Console.WriteLine(robotB.Message);
            if (arena.Winner != "") Console.WriteLine("Robot " + arena.Winner + " is the winner!");
            Console.ReadLine();
        }
    }
}
