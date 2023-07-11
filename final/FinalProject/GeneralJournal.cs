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

    public void LoadJournal()
    {
        string[] lines = System.IO.File.ReadAllLines("GeneralJounral.txt");
        foreach(string line in lines)
        {
            string[] Sections = line.Split(":");
            string[] DailyinfoP = Sections[0].Split("|");
            string[] DietP = Sections[1].Split("|");
            string[] WaterLogP = Sections[2].Split("|");
            string[] ReadingP = Sections[3].Split("|");
            string[] Workout1P = Sections[4].Split("|");
            string[] workout2P = Sections[5].Split("|");
            Workout workout1 = new Workout(Workout1P[0], Workout1P[1], int.Parse(Workout1P[2]));
            Workout workout2 = new Workout(workout2P[0], workout2P[1], int.Parse(workout2P[2]));
            Diet diet = new Diet(DietP[0], DietP[1], DietP[2], DietP[3], int.Parse(DietP[4]));
            Reading reading = new Reading(ReadingP[0], ReadingP[1], int.Parse(ReadingP[2]));
            WaterLog waterLog = new WaterLog(WaterLogP[0], int.Parse(WaterLogP[1]));
            DailyJournal dailyJournal = new DailyJournal(DateTime.Parse(DailyinfoP[0]),DailyinfoP[1],workout1,workout2,diet,reading,waterLog, int.Parse(DailyinfoP[2]));
            AddDailyJournal(dailyJournal);
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