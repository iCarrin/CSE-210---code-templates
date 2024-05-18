class journal
{
    public void Menu()
    {
    List<string> journal = new List<string>();
    Entry current = new Entry();
    
    public void AddEntry()
    {
        current.StartEntry();
        journal.add(current.Write())
        //I don't think this will work. How can the "Write" function write out the journal if I didn't save the results of the "startEntry" command?
    }

    public void DisplayAll()
    {
        foreach (j in journal)
        {
            Consol.WriteLine(j);
        }

    }









    }

    
}