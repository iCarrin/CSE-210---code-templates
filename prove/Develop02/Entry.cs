using System;
class Entry 
{
    public Entry()
    {
        
    }
    string _journal;
    string _time;
    string _prompt = Prompt.GetPrompt();  
   

    public string GetTime()
    {
        DateTime T = DateTime.Now;
        _time = ($"{T.Day}-{T.Month}-{T.Year} {T.Hour}:{T.Minute}");
        return _time;

        // DateTime date1 = new DateTime(2008, 4, 1, 18, 53, 0);
        // Console.WriteLine(date1.ToString("%h"));              // Displays 6
        // Console.WriteLine(date1.ToString("h tt"));            // Displays 6 PM

    }
    public string StartEntry()
    {
        Console.WriteLine(_prompt);
        _journal = Console.ReadLine();
        return _journal;

    }
    public string Write()
    {     
        return ($"{_time}\n{_prompt}\n{_journal}");
    }
};