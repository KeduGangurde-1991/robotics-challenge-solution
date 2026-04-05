//create interface for the robot factory
public interface IRobotAllocator
{
    AllocationResult Allocate(int requestedHours, IEnumerable<Robot> availableRobots);
}