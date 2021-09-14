using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RobotWars.Enums;

namespace RobotWars
{
    public class Robot
    {
        private int _xPosition;
        private int _yPosition;
        private Heading _heading;
        private string _instructions;
        private int _instructionPointer = 0;
        private string _message;
        private int _arenaX;
        private int _arenaY;

        public Robot(string position, string instructions, int arenaX, int arenaY)
        {
            _xPosition = Int32.Parse(position.Substring(0, 1));
            _yPosition = Int32.Parse(position.Substring(2, 1));
            _heading = (Heading)Enum.Parse(typeof(Heading), position.Substring(4, 1));
            _instructions = instructions;
            _arenaX = arenaX;
            _arenaY = arenaY;
        }

        public int InstructionsLength
        {
            get => _instructions.Length;
        }

        public string Message
        {
            get => _message;
        }

        public int XPosition
        {
            get => _xPosition;
        }

        public int YPosition
        {
            get => _yPosition;
        }

        public void Move()
        {
            string instruction = _instructions.Substring(_instructionPointer, 1);
            
            if (instruction == "L")
            {
               switch (_heading)
                {
                    case Heading.N:
                        _heading = Heading.W;
                        break;
                    case Heading.E:
                        _heading = Heading.N;
                        break;
                    case Heading.S:
                        _heading = Heading.E;
                        break;
                    case Heading.W:
                        _heading = Heading.S;
                        break;
                }
            }

            else if (instruction == "R")
            {
                switch (_heading)
                {
                    case Heading.N:
                        _heading = Heading.E;
                        break;
                    case Heading.E:
                        _heading = Heading.S;
                        break;
                    case Heading.S:
                        _heading = Heading.W;
                        break;
                    case Heading.W:
                        _heading = Heading.N;
                        break;
                }
            }

            else if (instruction == "M")
            {
                switch (_heading)
                {
                    case Heading.N:
                        if (_yPosition < _arenaY) _yPosition++;
                        break;
                    case Heading.E:
                        if (_xPosition < _arenaX) _xPosition++;
                        break;
                    case Heading.S:
                        if (_yPosition > 0) _yPosition--;
                        break;
                    case Heading.W:
                        if (_xPosition > 0) _xPosition--;
                        break;
                }
            }

            _message = _xPosition + " " + _yPosition + " " + _heading;

            _instructionPointer++;
        }
    }
}
