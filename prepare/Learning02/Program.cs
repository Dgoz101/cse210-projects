using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._position = "Engineer";
        job1._company = "Company";
        job1._startYr = 2019;
        job1._endYr = 2020;

        

        Job job2 = new Job();
        job2._position = "student";
        job2._company = "BYUI";
        job2._endYr = 2025;
        job2._startYr = 2021;

        
        Resume myResume = new Resume();
        myResume._name = "David Gosney";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}