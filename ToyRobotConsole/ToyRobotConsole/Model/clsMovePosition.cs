using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace ToyRobotConsole.Model
{
    public class clsMovePosition
    {
        clsToyPosition robot = new clsToyPosition();
        public int[] Move(string Facing, int X, int Y)
        {
            int[] CursorPosition = new int[3];
            CursorPosition[2] = 0;

            if (Facing == "NORTH" && robot.IsValidPosition(X, Y + 1))
            {
                Y++;
            }
            else if (Facing == "SOUTH" && robot.IsValidPosition(X, Y - 1))
            {
                Y--;
            }
            else if (Facing == "EAST" && robot.IsValidPosition(X + 1, Y))
            {
                X++;
            }
            else if (Facing == "WEST" && robot.IsValidPosition(X - 1, Y))
            {
                X--;
            }
            else {
                CursorPosition[2] = -1;
            }
            Console.SetCursorPosition(X, Y);
            CursorPosition[0] = X;
            CursorPosition[1] = Y;            
            return CursorPosition;
            
        }
    }
}
