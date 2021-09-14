using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    public class Arena
    {
        private int _x;
        private int _y;

        public int X
        {
            get => _x;
        }

        public int Y
        {
            get => _y;
        }

        public string Winner = "";

        public Arena(string input)
        {
            _x = Int32.Parse(input.Substring(0, 1));
            _y = Int32.Parse(input.Substring(2, 1));
        }
    }
}
