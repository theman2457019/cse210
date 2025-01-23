using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2025;

        Job job2  = new Job();
         job2._company = "Mcdonald's";
        job2._jobTitle = "Burger Engineer";
        job2._startYear = 2000;
        job2._endYear = 2010;

        Resume myReusme = new Resume();
        myReusme._name = "Mason Perry";

       myReusme._jobs.Add(job1);
       myReusme._jobs.Add(job2);

       myReusme.Display();
    }
}