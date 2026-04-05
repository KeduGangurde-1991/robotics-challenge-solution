using System;
using System.Collections.Generic;
using System.Linq;
using RoboticsChallenge.Exceptions;
/// <summary>
/// created the level 3 allocator class which implements the IRobotAllocator interface and allocates robots based on the total hours available from the available robots. If the total hours are sufficient to meet the requested hours, it delegates to the Level2Allocator. If not, it activates a standby robot (e.g., Charlie) to meet the remaining hours, ensuring that the allocation is still possible even if the initial robots are insufficient.
/// </summary>
public class Level3Allocator : IRobotAllocator
{
    public AllocationResult Allocate(int requestedHours, IEnumerable<Robot> availableRobots)
    {
        var result = new AllocationResult();
        int accumulated = availableRobots.Sum(r => r.HoursPerDay);

        if (accumulated >= requestedHours)
            return new Level2Allocator().Allocate(requestedHours, availableRobots);

        // Activate standby robot (cheapest option)
        var standby = new Charlie(); // Example: choose Charlie
        result.AssignedRobots.AddRange(availableRobots);
        result.AssignedRobots.Add(standby);

        return result;
    }
}