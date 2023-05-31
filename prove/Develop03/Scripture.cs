public class Scriputre
{
    private Verse _verse = new Verse();
    private Reference _refrence;

    public Scriputre(string book, string chapternumber, string verseNumber, string verse)
    {
            _refrence = new Reference(book, chapternumber,verseNumber);
            _verse.SetVerse(verse);
            _verse.ConvertToWords(); 
    }

    public Scriputre(string book, string chapternumber, string startVerseNumber, string endVerseNumber, string verse)
    {
            _refrence = new Reference(book, chapternumber,startVerseNumber,endVerseNumber);
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