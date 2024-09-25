using System;
using System.Collections.Generic;

class Program
{
    //Job Class
    public class Job
    {
       //Member Variables for Job
       public string _jobTitle;
       public string _company;
       public string _startYear;
       public string _endYear;

       //Methods, display job details
       public void Display()
       {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
       }

    }

    //Resume Class
    public class Resume
    {
        //member variables for resume
        public string _name;
        public List<Job> _jobs = new List<Job>();

        //method, display resume details
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Jobs:");
            foreach(Job job in _jobs)
            {
                job.Display();
            }
        }
    }
    static void Main(string[] args)
    {
       //create my current job:
       Job job1 = new Job();
       job1._jobTitle = "Operations Secretary";
       job1._company = "Oriental Group";
       job1._startYear = "2015";
       job1._endYear = "2016";

       //create other job
       Job job2 = new Job();
       job2._jobTitle = "Marketing Assistant";
       job2._company = "La Vogue Group";
       job2._startYear = "2017";
       job2._endYear = "2024";

       //create resume
       Resume myResume = new Resume();
       myResume._name = "Rhea June Reyes";

       //add jobs to my resume
       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);

       //display
       myResume.Display();
    }
}