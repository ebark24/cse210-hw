public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points){}

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {GetName()} ({GetDescription()})");
    }

}