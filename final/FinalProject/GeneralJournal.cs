public class GeneralJournal
{
    List<DailyJournal> _generalJournal = new List<DailyJournal>();
    int _daysComplete = 0;

    public void AddDailyJournal(DailyJournal dailyJournal)
    {
        _generalJournal.Add(dailyJournal);
    }

    public void SaveJournal()
    {
        string filename = "GeneralJounral.txt";
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (DailyJournal dailyJournal in _generalJournal)
                {
                    outputFile.WriteLine(dailyJournal.GetDailyStringRepresentation());
                }
            }
    }
    public void UpdateDaysComplete()
    {
        _daysComplete = 0; 
        foreach(DailyJournal dailyJournal in _generalJournal)
        {
            if (dailyJournal.GetOverallCompletion() == "Complete [x]")
            {
                _daysComplete += 1;
            }
        }
    }
}