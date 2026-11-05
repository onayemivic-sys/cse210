using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startyear = 2018;
        job1._endyear = 2022;

        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startyear = 2022;
        job2._endyear =2023;

       

        //Resume
        Resume myResume = new Resume();

        //owner
        myResume._name ="Victor Onayemi";

        //adds job to resume

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //complete resume display
        myResume.Display();
    }
}