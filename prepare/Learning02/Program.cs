using System;

class Program
{
    static void Main(string[] args)
    {
        Job test1 = new Job
        {
            _jobTitle = "Pooper scooper",
            _company = "Carrin inc",
            _startYear = 1977,
            _endYear = 2021
        };

        Job test2 = new Job
        {
            _jobTitle = "Crime fighter",
            _company = "Michelangelo Mojo Dojo Casa House Studios ",
            _startYear = 2023,
            _endYear = 0,  
        };
       

        Resume bestResumeEver = new Resume();
        bestResumeEver._jobs.Add(test2);
        bestResumeEver._jobs.Add(test1);
        bestResumeEver._name = "Isaiah Carrin";

        bestResumeEver.DisplayResume();

    }
}