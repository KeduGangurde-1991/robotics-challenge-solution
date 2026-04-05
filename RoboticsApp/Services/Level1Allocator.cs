using System;
using System.Collections.Generic;
using System.Linq;
using RoboticsChallenge.Exceptions;

//created the level 1 allocator class which implements the IRobotAllocator interface and allocates robots based on the requested hours and available robots
public class Level1Allocator : IRobotAllocator
{
    public AllocationResult Allocate(int requestedHours, IEnumerable<Robot> availableRobots)
    {
        if (requestedHours <= 0)
            throw new InvalidInputException();

        var result = new AllocationResult();
        int accumulated = 0;

        foreach (var robot in availableRobots)
        {
            if (accumulated < requestedHours)
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