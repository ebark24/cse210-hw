using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the 75 Hard Tracker");
        Console.WriteLine("");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("");
        Console.WriteLine("1. Open General Journal");
        Console.WriteLine("2. Open Specific Daily Entry");
        Console.WriteLine("3. Create Daily Entry");
        string UserEntry = Console.ReadLine();
        GeneralJournal generalJournal = new GeneralJournal();
        DailyJournal dailyJournal = new DailyJournal();
        Diet diet = new Diet();
        WaterLog waterLog = new WaterLog();
        Reading reading = new Reading();
        Workout workout1 = new Workout();
        Workout workout2 = new Workout();
        dailyJournal.SetDiet(diet);
        dailyJournal.SetWaterLog(waterLog);
        dailyJournal.SetReading(reading);
        dailyJournal.SetWorkout1(workout1);
        dailyJournal.SetWorkout2(workout2);

        if (UserEntry == "1")
        {

        }

        while (UserEntry == "3")
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("");
            Console.WriteLine("1.Dispaly Daily journal");
            Console.WriteLine("2.Record Workout");
            Console.WriteLine("3.Record Meals");
            Console.WriteLine("4.Log Water");
            Console.WriteLine("5.Record Reading");
            Console.WriteLine("6.Add Daily Journal to General Journal and retun to main menu");
            string DJUserEntry = Console.ReadLine();

            while (DJUserEntry == "1")
            {
                Console.Clear();
                dailyJournal.DispalyDailyJournal();
                Console.WriteLine("");
                Console.WriteLine("Press enter to retun to the menu");
                Console.ReadLine();
                DJUserEntry = "";
            }

            while (DJUserEntry == "2")
            {
                Console.Clear();
                Console.WriteLine("1.Record Workout 1");
                Console.WriteLine("2.Record Workout 2");
                string workoutNumber = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("What type of workout did you do?");
                string workoutType = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("How long did you workout for in minutes?");
                int workoutDuration = int.Parse(Console.ReadLine());
                if (workoutNumber == "1")
                {
                    workout1.AddWorkout(workoutType, workoutDuration);
                    workout1.DisplayTask();
                }
                if (workoutNumber == "2")
                {
                    workout2.AddWorkout(workoutType, workoutDuration);
                    workout2.DisplayTask();
                }
                Console.WriteLine("");
                Console.WriteLine("1.Record another workout");
                Console.WriteLine("2.Go back to Daily Jounral");
                string repeat = Console.ReadLine();
                if (repeat == "2")
                {
                    DJUserEntry = "";
                }

            }

            while (DJUserEntry == "3")
            {
                Console.Clear();
                Console.WriteLine("What meal whould you like to record");
                Console.WriteLine("");
                Console.WriteLine("1.Breakfast");
                Console.WriteLine("2.Lunch");
                Console.WriteLine("3.Dinner");
                string MealType = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("What did you eat? ");
                string Meal = Console.ReadLine();
                Console.Write("How many grams of protien were in this meal? ");
                int GramsOfProtien = int.Parse(Console.ReadLine());
                diet.SetMeal(MealType, Meal, GramsOfProtien);
                Console.WriteLine("");
                diet.DisplayTask();
                Console.WriteLine("");
                Console.WriteLine("1.Record another meal");
                Console.WriteLine("2.Go back to Daily Jounral");
                string repeat = Console.ReadLine();
                if (repeat == "2")
                {
                    DJUserEntry = "";
                }
            }

            while (DJUserEntry == "4")
            {
                Console.Clear();
                Console.WriteLine("How many oz of water have you drunk");
                int WaterDrunk = int.Parse(Console.ReadLine());
                waterLog.RecordDrinking(WaterDrunk);
                waterLog.DisplayTask();
                Console.WriteLine("");
                Console.WriteLine("1.Log more water");
                Console.WriteLine("2.Go back to Daily Jounral");
                string repeat = Console.ReadLine();
                if (repeat == "2")
                {
                    DJUserEntry = "";
                }
            }

            while (DJUserEntry == "5")
            {
                Console.Clear();
                Console.WriteLine("What book did you read?");
                string book = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("How many pages did you read?");
                int NumberOfPagesRead = int.Parse(Console.ReadLine());
                reading.RecordReading(book, NumberOfPagesRead);
                Console.WriteLine("");
                reading.DisplayTask();
                Console.WriteLine("1.Record more reading");
                Console.WriteLine("2.Go back to Daily Jounral");
                string repeat = Console.ReadLine();
                if (repeat == "2")
                {
                    DJUserEntry = "";
                }
            }

            if (DJUserEntry == "6")
            {
                generalJournal.AddDailyJournal(dailyJournal);
                generalJournal.SaveJournal();
            }

        }
    }
}