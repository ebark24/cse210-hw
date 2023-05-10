using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>() {"What is the Best thing you did today?", "What is one thing you wish you could change about today?", "How did you see God's gand in your life today?", "What act of kindness did you preform today?", "What was the best conversation that you had today?", "Who was the person that had the most influence on you today?"};
        ///Entry entry = new Entry();
        ///Prompt prompt = new Prompt();
        ///prompt._promptList = prompts;
        var random = new Random();

        
        ///entry.hold("What is your name", "Eli Barker", "May 8th 2023");

        Journal journal = new Journal();
        ///journal.AddEntry(entry);

        List<Entry> entries = journal.GetAllEntries();
        foreach (Entry e in entries)
        {
            string message = e.convert_to_string();
            Console.WriteLine(message);
        }



        int UserNumber = 12;

        while (UserNumber != 5)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            UserNumber = int.Parse(Console.ReadLine());

            if (UserNumber == 1)
            {
                Entry entry = new Entry();
                int index = random.Next(prompts.Count);
                entry._prompt = prompts[index];
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                entry._date = dateText;
                Console.WriteLine(entry._prompt);
                entry._response = Console.ReadLine();
                journal._entries.Add(entry);
            }

            else if (UserNumber == 2)
            {
                journal.DisplayJournal();
            }

            else if (UserNumber == 3)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {   
                    Entry entry = new Entry();
                    string[] parts = line.Split("-");
                    entry._date = parts [0];
                    entry._prompt = parts [1];
                    entry._response = parts [2];
                    journal._entries.Add(entry);

                }
                
            }

            else if (UserNumber == 4)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry e in entries)
                    {
                        
                        outputFile.WriteLine($"{e._date}-{e._prompt}-{e._response}");
                    }

                }
                
            }
        }
                    
    }
}