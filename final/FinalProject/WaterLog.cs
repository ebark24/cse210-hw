public class WaterLog:Task
{
    private int _ozOfWaterDrank = 0;
    private int _ozOfWaterRequired = 128;

    public void RecordDrinking(int OzOfWaterDrank)
    {
        _ozOfWaterDrank += OzOfWaterDrank;
        if (_ozOfWaterDrank >= _ozOfWaterRequired)
        {
            CompleteTask();
            Console.WriteLine("Congratulations you have completed this task!");
        }
    }

    public override void DisplayTask()
    {
        Console.WriteLine($"You have drank {_ozOfWaterDrank}oz of the {_ozOfWaterRequired}oz of water required");
    }

    public override void SetStringRepreseenation()
    {
        _stringRepresentation = $"WaterLog|{GetCompletion()}|{_ozOfWaterDrank}";
    }
}