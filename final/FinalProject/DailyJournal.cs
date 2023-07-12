public class DailyJournal
{
    private List<Task> _allTasks = new List<Task>();
    private List<Task> _tasksComplete = new List<Task>();
    private Workout _workout1 = new Workout();
    private Workout _workout2 = new Workout();
    private Diet _diet = new Diet();
    private Reading _reading = new Reading();
    private WaterLog _waterLog = new WaterLog();
    private int _numberOfTasksComplete = 0;
    private DateTime _date = DateTime.Today;
    private string _overallCompletion = "Incomplete [ ]";

    public DailyJournal()
    {}
    public DailyJournal(DateTime date, string overallcompetion, Workout workout1, Workout workout2, Diet diet, Reading reading, WaterLog waterLog, int numberOfTasksComplete)
    {
        _date = date;
        _overallCompletion = overallcompetion;
        _workout1 = workout1;
        _workout2 = workout2;
        _diet = diet;
        _reading = reading;
        _waterLog = waterLog;
        _numberOfTasksComplete = numberOfTasksComplete;
        UpdateTasksComplete();
    }

    public string GetOverallCompletion()
    {
        return _overallCompletion;
    }

    public void SetWorkout1(Workout Workout1)
    {
        _workout1 = Workout1;
        _allTasks.Add(Workout1);
    }

    public void SetWorkout2(Workout Workout2)
    {
        _workout2 = Workout2;
        _allTasks.Add(Workout2);
    }

    public void SetDiet(Diet diet)
    {
        _diet = diet;
        _allTasks.Add(diet);
    }

    public void SetWaterLog(WaterLog waterLog)
    {
        _waterLog = waterLog;
        _allTasks.Add(waterLog);
    }

    public void DisplayDateAndCompletion()
    {
        UpdateTasksComplete();
        Console.WriteLine($"{_date.ToLongDateString()} - {_overallCompletion}");
    }

    public void SetReading(Reading reading)
    {
        _reading = reading;
        _allTasks.Add(reading);
    }

    public void UpdateTasksComplete()
    {
        foreach (Task task in _allTasks)
        {
            if (_tasksComplete.Contains(task))
            {}
            else
            {
                if (task.GetCompletion() == "Complete [x]")
                {
                    _tasksComplete.Add(task);
                }

            }
        }
        _numberOfTasksComplete = _tasksComplete.Count();
        
        if (_numberOfTasksComplete >= 5)
        {
            _overallCompletion = "Complete [x]";
        }
    }

    public void DispalyDailyJournal()
    {
        Console.Clear();
        UpdateTasksComplete();
        Console.WriteLine(_date.ToLongDateString());
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
        Console.WriteLine("");
        Console.WriteLine($"Overall Completion - {_overallCompletion} - {_numberOfTasksComplete}/5 Tasks Complete");
    }

    public string GetDailyStringRepresentation()
    {
        string DailyStringRepresentation = $"{_date.ToLongDateString()}|{_overallCompletion}|{_numberOfTasksComplete}:";
        foreach (Task task in _allTasks)
        {
            task.SetStringRepreseenation();
            DailyStringRepresentation += $"{task.GetStringRepresentation()}:";
        }
        return DailyStringRepresentation;
    }
}