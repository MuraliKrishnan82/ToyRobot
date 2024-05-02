using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotConsole.Model
{
    public class clsReport
    {
        public string Report(string Facing, int X, int Y)
        {
            return $"{X},{Y},{Facing}";
        }
    }
}
