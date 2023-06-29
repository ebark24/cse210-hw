public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points){}

    public NegativeGoal(string name, string description, int points, string checkbox) : base(name, description, points, checkbox){}

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {GetName()} ({GetDescription()})");
    }

    public override string GetStringRepresentation()
    {
        string representation = $"NegativeGoal|{GetCheckBox()}|{GetName()}|{GetDescription()}|{GetPoints()}";
        return representation;
    }

    public override int AccomplishTask()
    {
        return GetPoints();
    }
}