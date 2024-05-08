using System;

class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public Resume()
    {

    }

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.Write("Jobs: "); 
        foreach (Job j in _jobs)
        {
            j.DisplayJob();
        }
    }
}