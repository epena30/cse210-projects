using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._JobTitle = "Software Developer";
        job1._company = "Apple";
        job1._StartYear = 2019;
        job1._endYear = 2022;
    

        Job job2 = new Job();
        job2._JobTitle =  "Software Engineer";
        job2._company =  "Microsoft";
        job2._StartYear = 2012;
        job2._endYear = 2018;


        Resume myResume = new Resume();
        myResume._name = "Michael Johnson";
        

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        myResume.Display(); 

    }
}