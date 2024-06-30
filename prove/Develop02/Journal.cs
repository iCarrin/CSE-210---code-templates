using System.IO;

class Journal

{

    
    public Journal()
    {

    }
    List<string> journal = new List<string>();
    
    
    public void AddEntry()
    {
        Entry current = new Entry();
        current.GetTime();
        current.StartEntry();
        journal.Add(current.Write());
        //I don't think this will work. How can the "Write" function write out the journal if I didn't save the results of the "startEntry" command?
    }

    public void DisplayAll()
    {
        foreach (string j in journal)
        {
            Console.WriteLine(j);
        }
    }

    public void SaveJournal()
    {
        Console.WriteLine("Where whould you like to save your journal?");
        string location = Console.ReadLine();
        using (StreamWriter saveLocation = /*Claude helped me with this code*/ File.Exists(location) ? File.AppendText(location) : new StreamWriter(location))
        {
            foreach (string j in journal)
            {
                saveLocation.WriteLine(j);
            }
        }
    }
   //Console.WriteLine(Write())
    public List<string> LoadJournal()
    {
        Console.WriteLine("What file would you like ot load from?");
        string location = Console.ReadLine();
        string[] oldJournal = System.IO.File.ReadAllLines(location);
        List<string> overwrite = new List<string>();
        foreach (string j in oldJournal)
            {
                overwrite.Add(j);
                
                //string[] eachEntry = j.Split("\", \"");
            }
            journal = overwrite;
       return journal;
    }

    public int Menu()
    {
        Console.WriteLine("Write new entry : 1");
        Console.WriteLine("Display current journal : 2");
        Console.WriteLine("Save current jornal : 3");
        Console.WriteLine("Load current jornal : 4");
        Console.WriteLine("Quit : 0");
        int state = int.Parse(Console.ReadLine() );
        return state;
    }
}