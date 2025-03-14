using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2005;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Sales Manager";
        job2._company = "Apple";
        job2._startYear = 1990;
        job2._endYear = 2005;

        Resume resume = new Resume();
        resume._name = "John Travolta";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}