///created the RobotService class which uses the IRobotAllocator to assign robots based on the requested hours and available robots. This class serves as a service layer that can be used by other parts of the application to request robot allocations without needing to know the details of the allocation strategy being used.
public class RobotService
{
    private readonly IRobotAllocator _allocator;

    public RobotService(IRobotAllocator allocator)
    {
        _allocator = allocator;
    }

    public AllocationResult AssignRobots(int requestedHours, IEnumerable<Robot> robots)
    {
        return _allocator.Allocate(requestedHours, robots);
    }
}