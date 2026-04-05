using System;
using System.Collections.Generic;
using System.Linq;
using RoboticsChallenge.Exceptions;
/// <summary>
/// created the level 2 allocator class which implements the IRobotAllocator interface and allocates robots based on the cost per day and hours per day ratio, prioritizing robots with a lower cost per hour ratio first.
/// </summary>
public class Level2Allocator : IRobotAllocator
{
    public AllocationResult Allocate(int requestedHours, IEnumerable<Robot> availableRobots)
    {
        if (requestedHours <= 0)
            throw new InvalidInputException();

        var result = new AllocationResult();
        var sorted = availableRobots.OrderBy(r => (double)r.CostPerDay / r.HoursPerDay);

        int accumulated = 0;
        foreach (var robot in sorted)
        {
            while (accumulated < requestedHours)
            {
                result.AssignedRobots.Add(robot);
                accumulated += robot.HoursPerDay;
            }
        }

        if (accumulated < requestedHours)
            throw new ImpossibleAllocationException();

        return result;
    }
}