public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points){}

    public override void DisplayGoal()
    {
        Console.WriteLine($"{GetCheckBox()} {GetName()} ({GetDescription()})");
    }

    public override void AccomplishTask()
    {
        Checkbox();
    }
}