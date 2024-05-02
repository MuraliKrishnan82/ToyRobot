using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotConsole.Model
{
    public class clsTurnRight
    {
        public string TurnRight(string Facing)
        {
            string ModifiedFacing = "";
            // Implement logic to turn right
            if (Facing == "NORTH")
                ModifiedFacing = "EAST";
            else if (Facing == "EAST")
                ModifiedFacing = "SOUTH";
            else if (Facing == "SOUTH")
                ModifiedFacing = "WEST";
            else if (Facing == "WEST")
                ModifiedFacing = "NORTH";

            return ModifiedFacing;
        }
    }
}
