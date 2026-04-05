// Base class for all robots

public abstract class Robot
{
    public string Name { get; }
    public int HoursPerDay { get; }
    public int CostPerDay { get; }

    protected Robot(string name, int hours, int cost)
    {
        Name = name;
        HoursPerDay = hours;
        CostPerDay = cost;
    }
}