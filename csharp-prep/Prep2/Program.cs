using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage:");
        string grade = Console.ReadLine();
        int grade_percentage = int.Parse(grade);
        string letter = "no grade";
        if (grade_percentage >= 90)
        {
            letter = "A";
        }
        else if (grade_percentage >= 80)
        {
            letter = "B";
        }
        else if (grade_percentage >= 70)
        {
            letter = "C";
        }
        else if (grade_percentage >= 60)
        {
            letter = "D";
        }
        else if (grade_percentage < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade: {letter}");
        if (grade_percentage >= 70)
        {
            Console.WriteLine("Congrats! You have passed the class!");
        }
        else 
        {
            Console.WriteLine("You have not passed the class, I'm sure you will do better next time!");
        }

    }
}