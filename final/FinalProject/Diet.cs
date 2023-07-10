public class Diet:Task
{
    private string _breakfast = "none";
    private string _lunch = "none";
    private string _dinner = "none";
    private int _gramsOfProtienEaten = 0;
    private int _gramsOfProtienRequired = 120;

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
        Console.WriteLine("Your diet for the day consisted of the following:");
        Console.WriteLine($"Breakfast - {_breakfast}, Lunch - {_lunch}, Dinner - {_dinner}");
        Console.WriteLine($"You had {_gramsOfProtienEaten} grams of protien out of {_gramsOfProtienRequired} required");
    }

    public override void SetStringRepreseenation()
    {
        _stringRepresentation = $"Diet|{GetCompletion()}|{_breakfast}|{_lunch}|{_dinner}|{_gramsOfProtienEaten}";
    }
}