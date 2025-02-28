using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotSimulator.Enums;
using RobotSimulator.Interfaces;

namespace RobotSimulator.Models
{
    public class Robot : IRobot
    {
        private int x, y;
        private Direction direction;
        private bool isPlaced = false;
        private readonly TableTop tableTop;

        public Robot(TableTop tableTop)
        {
            this.tableTop = tableTop;
        }

        public void Place(int x, int y, Direction direction)
        {
            if (tableTop.IsValidPosition(x, y))
            {
                this.x = x;
                this.y = y;
                this.direction = direction;
                isPlaced = true;
            }
        }

        public void Move()
        {
            if (!isPlaced) return;

            int newX = x, newY = y;
            switch (direction)
            {
                case Direction.NORTH:
                    newY++;
                    break;
                case Direction.SOUTH:
                    newY--;
                    break;
                case Direction.EAST:
                    newX++;
                    break;
                case Direction.WEST:
                    newX--;
                    break;
            }

            if (tableTop.IsValidPosition(newX, newY))
            {
                x = newX;
                y = newY;
            }
        }

        public void Left()
        {
            if (!isPlaced)
                return;
            direction = (Direction)(((int)direction + 3) % 4);
        }

        public void Right()
        {
            if (!isPlaced)
                return;
            direction = (Direction)(((int)direction + 1) % 4);
        }

        public void Report()
        {
            if (!isPlaced)
                return;
            Console.WriteLine($"{x},{y},{direction}");
        }
    }
}
