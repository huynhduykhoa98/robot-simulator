using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator.Models
{
    public class TableTop
    {
        public int Width { get; } = 5;
        public int Height { get; } = 5;

        public bool IsValidPosition(int x, int y) => x >= 0 && x < Width && y >= 0 && y < Height;
    }
}
