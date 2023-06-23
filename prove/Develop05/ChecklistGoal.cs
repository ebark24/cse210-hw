public class ChecklistGoal : Goal
{
    private int _bonusPoints;

    private int _timesToBeCompleted;

    private int _timesAccomplished = 0;

    public ChecklistGoal(string name, string description, int points, int BonusPoints, int TimesToBeCompleted) : base(name, description, points)
    {
        SetBonusPoints(BonusPoints);
        SetTimesToBeCompleted(TimesToBeCompleted);
    }

    public void SetBonusPoints(int BonusPoints)
    {
        _bonusPoints = BonusPoints;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public void SetTimesToBeCompleted(int TimesToBeCompleted)
    {
        _timesToBeCompleted = TimesToBeCompleted;
    }

    public int GetTimesToBeCompleted()
    {
        return _timesToBeCompleted;
    }

    public int GetTimesAccomplished()
    {
        return _timesAccomplished;
    }

    public override void AccomplishTask()
    {
        _timesAccomplished += 1;
    }

    public override void DisplayGoal()
    {
        if (_timesAccomplished >= _timesToBeCompleted)
        {
            Checkbox();
        }
        Console.WriteLine($"{GetCheckBox()} {GetName()} ({GetDescription()}) - Currently completed - {_timesAccomplished}/{_timesToBeCompleted}");
    }

}