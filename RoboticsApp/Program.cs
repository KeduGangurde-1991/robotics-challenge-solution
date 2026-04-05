// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using RoboticsChallenge.Exceptions;



// Main program to demonstrate robot allocation using different strategies and handling exceptions.

class Program
{
    static void Main(string[] args)
    {
        var robots = new List<Robot> { new Bravo(), new Charlie(), new Delta() };
        bool continueRunning = true;
        while (continueRunning)
        {
            Console.WriteLine("Select allocation level:");
            Console.WriteLine("1. Level 1 - Category Distribution");
            Console.WriteLine("2. Level 2 - Cost Optimized");
            Console.WriteLine("3. Level 3 - Standby Activation");
            Console.WriteLine("4. Level 4 - Multi-Client Allocation");
            Console.Write("Enter choice (1-4): ");

            string choice = Console.ReadLine();
            IRobotAllocator allocator = choice switch
            {
                "1" => new Level1Allocator(),
                "2" => new Level2Allocator(),
                "3" => new Level3Allocator(),
                "4" => new Level4Allocator(),
                _ => throw new InvalidInputException("Invalid choice. Please select 1-4.")
            };

            var service = new RobotService(allocator);

            Console.Write("Enter requested hours: ");
            if (!int.TryParse(Console.ReadLine(), out int requestedHours))
            {
                Console.WriteLine("Error: Requested hours must be a positive integer.");
                return;
            }

            try
            {
                var result = service.AssignRobots(requestedHours, robots);
                Console.WriteLine($"Total Hours: {result.TotalHours}, Total Cost: ${result.TotalCost}");
                foreach (var robot in result.AssignedRobots)
                    Console.WriteLine($"Assigned: {robot.Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Ask user if they want to continue or exit
            Console.WriteLine("\nDo you want to perform another allocation? (Y/N): ");
            string response = Console.ReadLine()?.Trim().ToUpper();

            if (response == "N")
            {
                Console.WriteLine("Closing application. Goodbye!");
                continueRunning = false;
            }
            else if (response != "Y")
            {
                Console.WriteLine("Invalid input. Exiting application.");
                continueRunning = false;
            }
        }

    }
}














