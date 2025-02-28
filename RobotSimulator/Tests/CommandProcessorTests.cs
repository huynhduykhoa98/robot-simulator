using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using RobotSimulator.Enums;
using RobotSimulator.Interfaces;
using RobotSimulator.Services;
using Xunit;

namespace RobotSimulator.Tests
{
    public class CommandProcessorTests
    {
        private readonly Mock<IRobot> robotMock;
        private readonly CommandProcessor processor;

        public CommandProcessorTests()
        {
            robotMock = new Mock<IRobot>();
            processor = new CommandProcessor(robotMock.Object);
        }

        [Fact]
        public void ProcessCommand_ShouldCallPlace_WhenValidCommand()
        {
            // Act
            processor.ProcessCommand("PLACE 1,2,NORTH");

            // Assert
            robotMock.Verify(r => r.Place(1, 2, Direction.NORTH), Times.Once);
        }

        [Fact]
        public void ProcessCommand_ShouldCallMove()
        {
            // Act
            processor.ProcessCommand("MOVE");

            // Assert
            robotMock.Verify(r => r.Move(), Times.Once);
        }

        [Fact]
        public void ProcessCommand_ShouldCallLeft()
        {
            // Act
            processor.ProcessCommand("LEFT");

            // Assert
            robotMock.Verify(r => r.Left(), Times.Once);
        }

        [Fact]
        public void ProcessCommand_ShouldCallRight()
        {
            // Act
            processor.ProcessCommand("RIGHT");

            // Assert
            robotMock.Verify(r => r.Right(), Times.Once);
        }

        [Fact]
        public void ProcessCommand_ShouldCallReport()
        {
            // Act
            processor.ProcessCommand("REPORT");

            // Assert
            robotMock.Verify(r => r.Report(), Times.Once);
        }
    }
}
