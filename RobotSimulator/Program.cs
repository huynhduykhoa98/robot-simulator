using Microsoft.Extensions.DependencyInjection;
using RobotSimulator.Interfaces;
using RobotSimulator.Models;
using RobotSimulator.Services;

var serviceProvider = new ServiceCollection()
                .AddSingleton<TableTop>()
                .AddSingleton<IRobot, Robot>()
                .AddSingleton<CommandProcessor>()
                .BuildServiceProvider();

var processor = serviceProvider.GetService<CommandProcessor>();
if (processor != null)
{
    string basePath = AppDomain.CurrentDomain.BaseDirectory;
    string inputFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "commands.txt");
    if (File.Exists(inputFile))
    {
        foreach (var line in File.ReadLines(inputFile))
        {
            processor.ProcessCommand(line.Trim());
        }
    }
    else
    {
        Console.WriteLine("commands.txt is not found");       
    }
}
Console.ReadKey();