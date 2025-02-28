using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotSimulator.Enums;
using RobotSimulator.Interfaces;

namespace RobotSimulator.Services
{
    public class CommandProcessor
    {
        private readonly IRobot robot;

        public CommandProcessor(IRobot robot)
        {
            this.robot = robot;
        }

        public void ProcessCommand(string command)
        {
            var parts = command.Split(' ');
            if (parts.Length == 0) return;

            switch (parts[0])
            {
                case "PLACE":
                    if (parts.Length == 2)
                    {
                        var args = parts[1].Split(',');
                        if (args.Length == 3 && int.TryParse(args[0], out int x) && int.TryParse(args[1], out int y) && Enum.TryParse(args[2], out Direction direction))
                        {
                            robot.Place(x, y, direction);
                        }
                    }
                    break;
                case "MOVE":
                    robot.Move();
                    break;
                case "LEFT":
                    robot.Left();
                    break;
                case "RIGHT":
                    robot.Right();
                    break;
                case "REPORT":
                    robot.Report();
                    break;
            }
        }
    }
}
