using System;

class Program
{
    static void Main(string[] args)
    {
        Activity Activity1 = new Activity("Breathing Activity", "You must breath");
        Activity1.DisplayOpeningMessage();
        Activity1.SetUserDuration();
    }
}