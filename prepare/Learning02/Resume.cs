public class Resume
{
    // Member variables for the person's name
    public string _name;
    // Member variable for the list of jobs
    public List<Job> _jobs;

    public Resume()
    {
        _jobs = new List<Job>();
    }
    public void Display()
    {
        Console.WriteLine($"Name: {_name} \nJobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }

    }
}
