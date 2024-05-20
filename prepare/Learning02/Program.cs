using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the Job class
        Job job1 = new Job();
        Job job2 = new Job();

        // Set the member variables for job1
        job1._company = "Micron";
        job1._jobTitle = "Microchip Developer";
        job1._startYear = 2002;
        job1._endYear = 2013;

        // Set the member variables for job2
        job2._company = "HP";
        job2._jobTitle = "Sofware engineer";
        job2._startYear = 2013;
        job2._endYear = 2024;

        // // Call the display method for each job
        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        //Call my Resume and add a name
        Resume myResume = new Resume();
        myResume._name = "Dallin Thomas";

        //add jobs the the list(Resume)
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        //Display Information
        myResume.Display();
        
    }

}