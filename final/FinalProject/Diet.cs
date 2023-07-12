public class Diet:Task
{
    private string _breakfast = "none";
    private string _lunch = "none";
    private string _dinner = "none";
    private int _gramsOfProtienEaten = 0;
    private int _gramsOfProtienRequired = 120;

    public Diet(){}

    public Diet(string Completion, string Breakfast, string Lunch, string dinner, int GramsOfProtienEaten)
    {
        _completion = Completion;
        _breakfast = Breakfast;
        _lunch = Lunch;
        _dinner = dinner;
        _gramsOfProtienEaten = GramsOfProtienEaten;
    }

    public void SetMeal(string MealType, string Meal, int GramsOfPRotien)
    {
        if (MealType == "1")
        {
            _breakfast = Meal;
        }

        if (MealType == "2")
        {
            _lunch = Meal;
        }

        if (MealType == "3")
        {
            _dinner = Meal;
        }
        _gramsOfProtienEaten += GramsOfPRotien;
        if (_gramsOfProtienEaten >= _gramsOfProtienRequired)
        {
            CompleteTask();
            Console.WriteLine("");
            Console.WriteLine("Congratulations you have completed this task!");
            Console.WriteLine("");
        }
    }

    public override void DisplayTask()
    {
        Console.WriteLine($"{_gramsOfProtienEaten}/{_gramsOfProtienRequired} grams of protien required. Your diet for the day consisted of the following: Breakfast - {_breakfast}, Lunch - {_lunch}, Dinner - {_dinner}");
    }

    public override void SetStringRepreseenation()
    {
        _stringRepresentation = $"Diet|{GetCompletion()}|{_breakfast}|{_lunch}|{_dinner}|{_gramsOfProtienEaten}";
    }
}