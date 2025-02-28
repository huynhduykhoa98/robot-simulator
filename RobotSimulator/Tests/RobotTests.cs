using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotSimulator.Enums;
using RobotSimulator.Models;
using Xunit;

namespace RobotSimulator.Tests
{
    public class RobotTests
    {
        private readonly TableTop tableTop;
        private readonly Robot robot;

        public RobotTests()
        {
            tableTop = new TableTop();
            robot = new Robot(tableTop);
        }

        [Fact]
        public void Place_ShouldSetInitialPosition_WhenValid()
        {
            // Act
            robot.Place(2, 2, Direction.NORTH);

            // Assert
            Assert.Equal("2,2,NORTH", GetRobotReport());
        }

        [Fact]
        public void Place_ShouldIgnore_WhenInvalidPosition()
        {
            // Act
            robot.Place(6, 6, Direction.NORTH);

            // Assert
            Assert.Empty(GetRobotReport());
        }

        [Fact]
        public void Move_ShouldChangePosition_WhenValid()
        {
            // Arrange
            robot.Place(2, 2, Direction.NORTH);

            // Act
            robot.Move();

            // Assert
            Assert.Equal("2,3,NORTH", GetRobotReport());
        }

        [Fact]
        public void Move_ShouldIgnore_WhenAtEdge()
        {
            // Arrange
            robot.Place(0, 4, Direction.NORTH);

            // Act
            robot.Move();

            // Assert
            Assert.Equal("0,4,NORTH", GetRobotReport());
        }

        [Fact]
        public void Left_ShouldRotateLeft()
        {
            // Arrange
            robot.Place(2, 2, Direction.NORTH);

            // Act
            robot.Left();

            // Assert
            Assert.Equal("2,2,WEST", GetRobotReport());
        }

        [Fact]
        public void Right_ShouldRotateRight()
        {
            // Arrange
            robot.Place(2, 2, Direction.NORTH);

            // Act
            robot.Right();

            // Assert
            Assert.Equal("2,2,EAST", GetRobotReport());
        }

        private string GetRobotReport()
        {
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                robot.Report();
                return sw.ToString().Trim();
            }
        }
    }
}
