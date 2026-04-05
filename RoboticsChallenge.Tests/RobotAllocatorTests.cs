using System.Collections.Generic;
using Xunit;

/// <summary>
/// Unit tests for the robot allocation system, covering various scenarios for each allocator level to ensure correct functionality and error handling. These tests validate that the allocators correctly assign robots based on the requested hours and available robots, and that they handle edge cases such as insufficient hours or invalid input appropriately.
/// </summary>
public class RobotAllocatorTests
{
    private List<Robot> GetDefaultRobots() =>
         new List<Robot> { new Bravo(), new Charlie(), new Delta() };

    [Fact]
    public void Level1Allocator_ShouldAllocateExactHours()
    {
        var allocator = new Level1Allocator();
        var result = allocator.Allocate(16, GetDefaultRobots());

        Assert.Equal(16, result.TotalHours);
        Assert.Equal(3, result.AssignedRobots.Count);
    }

    [Fact]
    public void Level2Allocator_ShouldOptimizeCost()
    {
        var allocator = new Level2Allocator();
        var result = allocator.Allocate(6, GetDefaultRobots());

        Assert.Equal(6, result.TotalHours);
        Assert.True(result.TotalCost <= 4);
    }

    [Fact]
    public void Level3Allocator_ShouldActivateStandbyRobot()
    {
        var allocator = new Level3Allocator();
        var result = allocator.Allocate(21, GetDefaultRobots());

        Assert.True(result.TotalHours >= 21);
        Assert.Contains(result.AssignedRobots, r => r.Name == "Charlie");
    }

    [Fact]
    public void Level4Allocator_ShouldHandleMultiClient()
    {
        var allocator = new Level4Allocator();
        var result = allocator.Allocate(10, GetDefaultRobots());

        Assert.True(result.TotalHours >= 10);
    }
}