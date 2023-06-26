using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string UserInput = "0";
        int TotalPoints = 0;
        List<Goal> Goals = new List<Goal>();
        while(UserInput != "6")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select an option from the menu: ");
            UserInput = Console.ReadLine();

            if (UserInput == "1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("Whcih type of goal would you like to create?");
                string GoalType = Console.ReadLine();
                Console.WriteLine("What is the name of your goal?");
                string name = Console.ReadLine();
                Console.WriteLine("Write a breif description of your goal:");
                string description = Console.ReadLine();
                Console.WriteLine("How many points should be assosiated with this goal?");
                int points = int.Parse(Console.ReadLine());

                if (GoalType == "1")
                    {
                        SimpleGoal SimpleGoal = new SimpleGoal(name, description, points);
                        Goals.Add(SimpleGoal);
                    }

                else if (GoalType == "2")
                    {
                        EternalGoal EternalGoal = new EternalGoal(name, description, points);
                        Goals.Add(EternalGoal);
                    }
                
                else if (GoalType == "3")
                    {
                        Console.WriteLine("How many times does this task need to be completed?");
                        int TimesToBeCompleted = int.Parse(Console.ReadLine());
                        Console.WriteLine("How many bonus points should be assosiated with this goal?");
                        int BonusPoints = int.Parse(Console.ReadLine());
                        ChecklistGoal ChecklistGoal = new ChecklistGoal(name, description, points, BonusPoints, TimesToBeCompleted);
                        Goals.Add(ChecklistGoal);
                    }
            }
            
            else if (UserInput == "2")
            {
                Console.WriteLine("Here are your goals:");
                foreach (Goal goal in Goals)
                {
                    goal.DisplayGoal();
                }
            }

            else if (UserInput == "3")
            {
                Console.WriteLine("What is the name for the goal file?");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(TotalPoints);
                    foreach (Goal goal in Goals)
                    {
                        outputFile.WriteLine(goal.GetStringRepresentation());
                    }
                }


            }

            else if (UserInput == "4")
            {

            }

            else if (UserInput == "5")
            {
                foreach(Goal goal in Goals)
                {
                    goal.AccomplishTask();
                    goal.DisplayGoal();
                }
            }
        }

    }
}