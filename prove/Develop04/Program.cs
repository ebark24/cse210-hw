using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.SetNameAndDescription();
        breathingActivity.DisplayOpeningMessage();
        breathingActivity.SetUserDuration();
        breathingActivity.DisplayWaitingAnimation();
        breathingActivity.DisplayActivity();
    }
}