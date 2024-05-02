using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotConsole.Model
{
    public class clsToyPosition
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public string Facing { get; private set; }

        public clsToyPosition()
        {
            X = 0; // Initialize robot outside the table
            Y = 0; // Initialize robot outside the table
        }

        public bool Place(int x, int y, string facing)
        {
            if (IsValidPosition(x, y) && IsValidFacing(facing))
            {
                X = x;
                Y = y;
                Facing = facing;
                return true;
            }
            return false;
        }

        public bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x <= 5 && y >= 0 && y <= 5;
        }

        public bool IsValidFacing(string facing)
        {
            return facing == "NORTH" || facing == "SOUTH" || facing == "EAST" || facing == "WEST";
        }
    }
}
