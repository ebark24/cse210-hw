using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._jobTitle = "Auditor";
        job._company = "PwC";
        job._startYear = 2021;
        job._endYear = 2025; 

        Job job2 = new Job();
        job2._jobTitle = "Tax";
        job2._company = "EY";
        job2._startYear = 2018;
        job2._endYear = 2010;

        Resume myResume = new Resume();
        myResume._name = "Eli Barker";
        myResume._jobs.Add(job);
        myResume._jobs.Add(job2);
        myResume.displayJobs();

    }
}