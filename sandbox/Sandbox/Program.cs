using System;

class Program
{
    static void Main(string[] args)
    {
        string verse = "I like to read the scriptures";
        List<string> word = new List<string>(verse.Split(" "));
        foreach (string w in word)
        {
            Console.WriteLine(w);
        }
    }
}