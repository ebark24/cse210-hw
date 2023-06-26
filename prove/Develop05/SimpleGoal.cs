public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points){}

    public SimpleGoal(string name, string description, int points, string checkbox) : base(name, description, points, checkbox){}

    public override void DisplayGoal()
    {
        Console.WriteLine($"{GetCheckBox()} {GetName()} ({GetDescription()})");
    }

    public override void AccomplishTask()
    {
        Checkbox();
    }

    public override string GetStringRepresentation()
    {
        string representation = $"SimpleGoal:{GetCheckBox()},{GetName()},{GetDescription()},{GetPoints()}";
        return representation;
    }
}