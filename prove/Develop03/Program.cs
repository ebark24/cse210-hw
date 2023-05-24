using System;

class Program
{
    static void Main(string[] args)
    {
        Reference Ref1 = new Reference();
        Ref1.setBook("Alma");
        Ref1.setVerseNumber("2-5");
        Ref1.setChapterNumber("5");
        string Final_ref = Ref1.getRefrence();
        Console.WriteLine(Final_ref);

        Scriputre scriputre1 = new Scriputre();

        scriputre1.SetScripture("Alma","2","2-5","I like it when I can make pancakes in the morning");
        scriputre1.DisplayScripture();
        scriputre1.MakeMultipleBlanks();
        scriputre1.DisplayScripture();
    }
}