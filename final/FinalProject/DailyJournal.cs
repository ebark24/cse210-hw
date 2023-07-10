public class DailyJournal
{
    private Workout _workout1 = new Workout();
    private Workout _workout2 = new Workout();
    private Diet _diet = new Diet();
    private Reading _reading = new Reading();
    private WaterLog _waterLog = new WaterLog();
    private DateTime _date = DateTime.Now;
    private bool _overallCompletion = false;

    public void SetWorkout1(Workout Workout1)
    {
        _workout1 = Workout1;
    }

    public void SetWorkout2(Workout Workout2)
    {
        _workout2 = Workout2;
    }

    public void SetDiet(Diet diet)
    {
        _diet = diet;
    }

    public void SetWaterLog(WaterLog waterLog)
    {
        _waterLog = waterLog;
    }

    public void SetReading(Reading reading)
    {
        _reading = reading;
    }

    public void DispalyDailyJournal()
    {
        Console.WriteLine(_date);
        Console.WriteLine("");
        Console.Write($"Workout 1 - {_workout1.GetCompletion()} - ");
        _workout1.DisplayTask();
        Console.Write($"Workout 2 - {_workout2.GetCompletion()} - ");
        _workout2.DisplayTask();
        Console.WriteLine("");
        Console.Write($"Diet - {_diet.GetCompletion()} - ");
        _diet.DisplayTask();
        Console.WriteLine("");
        Console.Write($"Reading - {_reading.GetCompletion()} - ");
        _reading.DisplayTask();
        Console.WriteLine("");
        Console.Write($"WaterLog - {_waterLog.GetCompletion()} - ");
        _waterLog.DisplayTask();

    }
 
}