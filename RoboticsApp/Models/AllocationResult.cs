
using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Class to represent the result of a robot allocation, including the assigned robots, total hours allocated, and total cost.
/// </summary>
public class AllocationResult
{
    public List<Robot> AssignedRobots { get; set; } = new();
    public int TotalHours => AssignedRobots.Sum(r => r.HoursPerDay);
    public int TotalCost => AssignedRobots.Sum(r => r.CostPerDay);
}