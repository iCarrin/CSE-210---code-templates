using system;

class Job {
    string jobTitle;
    string company;
    int startYear;
    int endYear;
    private string endYearVerified;
    public Job(){

    }
    private string ParseEndYear ()
    {
        if (endYear == 0)
        {
            endYearVerified = "Present"
        }
        else 
        {
             endYearVerified = endYear.ToString();
        }
        return endYearVerified;
    }
    public void DisplayJob (){
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYearVerified}.")
    }
}
