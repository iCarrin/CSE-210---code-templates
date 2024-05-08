using System;

class Job {
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;
    
    public Job(){

    }
    private string ParseEndYear ()
    {
        string endYearString;
        if (_endYear == 0)
        {
            endYearString = "Present";
        }
        else 
        {
             endYearString = _endYear.ToString();
        }
        return endYearString;
    }
    public void DisplayJob (){
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{ParseEndYear()}.");
    }
}
