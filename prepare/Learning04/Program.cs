using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment Assigment1 = new Assignment("Jeffry", "Fractions");
        Console.WriteLine(Assigment1.GetSummary());
        MathAssignment MathAssignment1 = new MathAssignment("Eli","Barker","8.3","12-18");
        Console.WriteLine(MathAssignment1.GetSummary());
        Console.WriteLine(MathAssignment1.GetHomeworkList());
        WritingAssignment WritingAssignment1 = new WritingAssignment("Jimmy", "WW2", "How WW2 Ended");
        Console.WriteLine(WritingAssignment1.GetSummary());
        Console.WriteLine(WritingAssignment1.GetWritingInformation());
    }
}