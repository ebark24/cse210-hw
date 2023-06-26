public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private string _checkbox = "[ ]";

    public Goal(string name, string description, int points)
    {
        SetName(name);
        SetDescription(description);
        SetPoints(points);
    }

    public Goal(string name, string description, int points, string checkbox)
    {
        SetName(name);
        SetDescription(description);
        SetPoints(points);
        _checkbox = checkbox;
    }


    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void Checkbox()
    {
        _checkbox = "[x]";
    }

    public string GetCheckBox()
    {
        return _checkbox;
    }

    public virtual string GetStringRepresentation()
    {
        string representation = "";
        return representation;
    }

    public virtual void DisplayGoal()
    {}

    public virtual int AccomplishTask()
    {
        return 0;
    }



} 