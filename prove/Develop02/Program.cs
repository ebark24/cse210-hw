using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        entry.hold("What is your name", "Eli Barker", "May 8th 2023");

        Journal journal = new Journal();
        journal.AddEntry(entry);

        List<Entry> entries = journal.GetAllEntries();
        foreach (Entry e in entries)
        {
            string message = e.convert_to_string();
            Console.WriteLine(message);
        }
    }
}