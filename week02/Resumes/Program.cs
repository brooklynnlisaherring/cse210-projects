using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Jobs job1 = new Jobs();
        job1._company = "Apple";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2009;
        job1._endYear = 2012;
        //Console.WriteLine(job1._company);
        //job1.Display();

        Jobs job2 = new Jobs();
        job2._company = "Microsoft";
        job2._jobTitle = "Sofware Engineer";
        job2._startYear = 2012;
        job2._endYear = 2015;
        //Console.WriteLine(job2._company);
        //job2.Display();

        Resumes resume = new Resumes();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        //Console.WriteLine(resume._job[0]._jobTitle);
        //Console.WriteLine(resume._job[1]._jobTitle);
        resume._name = "Jack Anderson";
        resume.Display();

    }
}