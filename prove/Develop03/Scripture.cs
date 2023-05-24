public class Scriputre
{
    private Verse _verse = new Verse();
    private Reference _refrence = new Reference();

    public void SetScripture(string book, string chapternumber, string versenumber, string verse)
    {
            _refrence.setBook(book);
            _refrence.setChapterNumber(chapternumber);
            _refrence.setVerseNumber(versenumber);

            _verse.SetVerse(verse);
            _verse.ConvertToWords();
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"{_refrence.getRefrence()} {_verse.GetVerse()}");
    }
    public void MakeMultipleBlanks()
    {
        _verse.RandomBlanks();
        _verse.ConvertToVerse();
    }

}