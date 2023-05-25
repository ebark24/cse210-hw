public class Scriputre
{
    private Verse _verse = new Verse();
    private Reference _refrence = new Reference();

    public void SetScripture(string book, string chapternumber, string versenumber, string verse)
    {
            _refrence.SetBook(book);
            _refrence.SetChapterNumber(chapternumber);
            _refrence.SetVerseNumber(versenumber);

            _verse.SetVerse(verse);
            _verse.ConvertToWords();
    }

    public int GetWordsToBeChangedCount()
    {
        int WordsCount = _verse.GetWordsToBeChangedCount();
        return WordsCount;
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"{_refrence.GetRefrence()} {_verse.GetVerse()}");
    }
    public void MakeMultipleBlanks()
    {
        _verse.RandomBlanks();
        _verse.ConvertToVerse();
    }

}