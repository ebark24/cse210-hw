
public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }
    public List<Entry> GetAllEntries()
    {
        return this._entries;
    }

    public void DisplayJournal()
    {
        foreach (Entry e in _entries)
        {
            string entry = e.convert_to_string();
            Console.WriteLine(entry);
            Console.WriteLine("");
        }
    }
}