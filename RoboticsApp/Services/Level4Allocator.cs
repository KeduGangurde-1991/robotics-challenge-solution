
using System;
using System.Collections.Generic;
using System.Linq;
using RoboticsChallenge.Exceptions;
/// <summary>
/// created the level 4 allocator class which implements the IRobotAllocator interface and allocates robots based on a more complex strategy that considers both cost and hours, potentially using a combination of available robots and standby robots to optimize for cost while ensuring that the requested hours are met. This allocator could implement a more sophisticated algorithm, such as a knapsack-like approach, to find the optimal combination of robots to allocate. For simplicity, in this implementation, it delegates to the Level2Allocator, but in a real scenario, it would contain more complex logic to determine the best allocation strategy.
/// </summary>
public class Level4Allocator : IRobotAllocator
{
    public AllocationResult Allocate(int requestedHours, IEnumerable<Robot> availableRobots)
    {
        // Simplified: prioritize largest request first
        return new Level2Allocator().Allocate(requestedHours, availableRobots);
    }
}