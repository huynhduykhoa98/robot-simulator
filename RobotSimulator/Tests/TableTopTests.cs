using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotSimulator.Models;
using Xunit;

namespace RobotSimulator.Tests
{
    public class TableTopTests
    {
        private readonly TableTop tableTop;

        public TableTopTests()
        {
            tableTop = new TableTop();
        }

        [Theory]
        [InlineData(0, 0, true)]
        [InlineData(4, 4, true)]
        [InlineData(5, 5, false)]
        [InlineData(-1, 0, false)]
        [InlineData(0, -1, false)]
        public void IsValidPosition_ShouldReturnExpectedResult(int x, int y, bool expected)
        {
            // Act
            bool result = tableTop.IsValidPosition(x, y);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
