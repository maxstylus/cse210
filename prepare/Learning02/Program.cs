using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Amazon";
        job1._jobTitle = "QA Engineer";
        job1._startYear = 2006;
        job1._endYear = 2008;

        Job job2 = new Job();
        job2._company = "GoDaddy";
        job2._jobTitle = "QA Engineer";
        job2._startYear = 2008;
        job2._endYear = 2009;

        Resume myResume = new Resume();
        myResume._name = "Lauren Snyder";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}