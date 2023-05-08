
public class Journal
{
    public List<Entry> _entries;
    public List<Entry> GetAllEntries()
    {
        return this._entries;
    }
    public void AddEntry(Entry entry)
    {
        if (!_entries.Contains(entry))
        {
            _entries.Add(entry);
        }
    }
}