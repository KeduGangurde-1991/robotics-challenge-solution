// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

// Main program to demonstrate robot allocation using different strategies and handling exceptions.

class Program
{
    static void Main(string[] args)
    {
        var robots = new List<Robot> { new Bravo(), new Charlie(), new Delta() };

        IRobotAllocator allocator = new Level1Allocator(); // Swap strategy here
        var service = new RobotService(allocator);



        try
        {
            var result = service.AssignRobots(16, robots);
            Console.WriteLine($"Total Hours: {result.TotalHours}, Total Cost: ${result.TotalCost}");
            foreach (var robot in result.AssignedRobots)
                Console.WriteLine($"Assigned: {robot.Name}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }


}














