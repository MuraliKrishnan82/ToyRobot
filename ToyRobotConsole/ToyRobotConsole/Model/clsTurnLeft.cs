using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotConsole.Model
{
    public class clsTurnLeft
    {
        public string TurnLeft(string Facing)
        {
            string ModifiedFacing = "";
            // Implement logic to turn left
            if (Facing == "NORTH")
                ModifiedFacing = "WEST";
            else if (Facing == "WEST")
                ModifiedFacing = "SOUTH";
            else if (Facing == "SOUTH")
                ModifiedFacing = "EAST";
            else if (Facing == "EAST")
                ModifiedFacing = "NORTH";
            return ModifiedFacing;
        }
    }
}
