using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ToyRobotConsole.Model;

namespace ToyRobotConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsMovePosition moverobot = new clsMovePosition();
            clsToyPosition robot = new clsToyPosition();
            clsTurnLeft MoveLeftRobot = new clsTurnLeft();
            clsTurnRight MoveRightRobot = new clsTurnRight();
            string CurrentFacing = "NORTH";
            int x = 0, y = 0;

            //DrawBox(x, y, CurrentFacing);

            while (true)
            {
                string command = Console.ReadLine();
                String pattern = "^[A-Z0-9 ]+$";
                bool isValid = Regex.Match(command, pattern).Success;

                if (!isValid)
                    Console.WriteLine("Please verify your command. The command will only accept capital letters.");

                else if (command.Contains("PLACE"))
                {
                    string[] myval = command.Split(' ');
                    bool isValidPositon = robot.Place(Convert.ToInt32(myval[1]), Convert.ToInt32(myval[2]), Convert.ToString(myval[3]));
                    if (isValidPositon)
                    {
                        x = Convert.ToInt32(myval[1]);
                        y = Convert.ToInt32(myval[2]);
                        CurrentFacing = myval[3]; // Assign the recent facing to a variable
                        DrawBox(x, y, CurrentFacing);
                        Console.WriteLine("Current position:( " + x + " , " + y + ", " + CurrentFacing + ")");
                    }
                    else
                        Console.WriteLine("Please provide a valid command.");
                }
                else if (command == "MOVE")
                {
                    Console.Clear();
                    int[] Cursorposition = moverobot.Move(CurrentFacing, x, y);
                    x = Cursorposition[0]; y = Cursorposition[1];
                    DrawBox(x, y, CurrentFacing);
                    if (Cursorposition[2] >= 0)
                        Console.WriteLine("Current position:( " + x + " , " + y + ", " + CurrentFacing + ")");
                    else
                        Console.WriteLine("\r\nPlease verify your command. The toy robot will not move afterward.");
                }
                else if (command == "REPORT")
                {
                    DrawBox(x, y, CurrentFacing);
                    Console.WriteLine("Current position:( " + x + " , " + y + ",  " + CurrentFacing + ")");
                }
                else if (command == "LEFT")
                {
                    Console.Clear();
                    CurrentFacing = MoveLeftRobot.TurnLeft(CurrentFacing);
                    DrawBox(x, y, CurrentFacing);
                    Console.WriteLine("Current position:( " + x + " , " + y + ", " + CurrentFacing + ")");
                }
                else if (command == "RIGHT")
                {
                    Console.Clear();
                    CurrentFacing = MoveRightRobot.TurnRight(CurrentFacing);
                    DrawBox(x, y, CurrentFacing);
                    Console.WriteLine("Current position:( " + x + " , " + y + ", " + CurrentFacing + ")");
                }

                else
                {
                    if (robot.IsValidFacing(CurrentFacing))
                        Console.WriteLine("Please provide a valid command.");
                }
            }
        }

        static void DrawBox(int x, int y, string currentFacing)
        {
            Console.Clear();
            for (int j = 0; j <= 5; j++)
            {
                for (int i = 0; i <= 5; i++)
                {
                    if (j == 0 || j == 6 - 1 || i == 0 || i == 6 - 1)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write("-");
                    }
                }
            }
            Console.SetCursorPosition(x, y);
            Console.Write(CurrentFacing(currentFacing));
            Console.SetCursorPosition(0, 6);

        }

        static string CurrentFacing(string positionIcon)
        {
            string displayIcon = positionIcon;

            switch (displayIcon)
            {
                case "North":
                    return displayIcon = "^";

                case "EAST":
                    return displayIcon = "<";

                case "WEST":
                    return displayIcon = ">";
                    ;
                case "SOUTH":
                    return displayIcon = "V";
                    ;
                default:
                    return displayIcon = "^";

            }

        }
    }
}
