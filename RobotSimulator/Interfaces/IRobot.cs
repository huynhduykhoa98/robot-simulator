using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotSimulator.Enums;

namespace RobotSimulator.Interfaces
{
    public interface IRobot
    {
        void Place(int x, int y, Direction direction);
        void Move();
        void Left();
        void Right();
        void Report();
    }

}
