using System;

class Program
{
    static void Main(string[] args)
    {
        Scriputre scriputre1 = new Scriputre();

        scriputre1.SetScripture("Alma","2","2-5","I like it when I can make pancakes in the morning");
        scriputre1.DisplayScripture();
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue or type 'Quit' to finish");

        string UserInput = "";

        while (UserInput != "Quit")
        {
            UserInput = Console.ReadLine();
            Console.Clear();
            scriputre1.MakeMultipleBlanks();
            scriputre1.DisplayScripture();
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue or type 'Quit' to finish");

        }
    }
}