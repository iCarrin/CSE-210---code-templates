using System.Text.RegularExpressions;
public class Scripture 
{     
    private List<Verse> allVerses = new List<Verse>(); //this wholds the list of multiple verese
    private List<Word> allShown = new List<Word>(); //This holds the list of all Word classes that are true words and that haven't been hidden
    private string refferance; //This is just where the refferance is stored
    public int difficulty = 5; //This is where you can set how many words are hidden at once. I'ts public because I don't want to bother making getters and setters for something as simple as a dificulty setting
    private int totalIterations; //This keeps track of how many times you could flip through the list and hide things before you can't hide the total amount (which is determined by the difficulty setting)
    private int loopAmount = 0; //This keeps track of how many times you have looped
    private string action; //This is just here to see if the user typed "quit"

    public Scripture(string refferance,string text) //The constructor takes in the reffeance and the text
    {
        this.refferance = refferance;   //It puts the refferance in the referance variable 
        SplitVerse(text); //It runs the Split Verse method. Before I had the whole text stored as variable and then the method was run but I realized I don't need all that text. So I never store it. I split it into verse and drop it.
        MakeTotalList(); //This takes every word from every verse that is a word (not a punctiaon or space) and stores it in a list that will have the hidden variables hidden from it.
        totalIterations = (allShown.Count / difficulty)+2; //This just says how many times to itterate. It spits back the how many times the program can completely hide the difficulty's amount of text. I then add one exta time incase there was spll over and one more so you can see the empty spaces
    }
    private void SplitVerse(string wholeText) //splits all the text based on if it sees a number
    {
        string[] verse = Regex.Split(wholeText,@"(?<=\D)(?=\d+)"); //fancy code from claude.ai (?<=\D): () means keep what you find, ?<= means look behind to make sure you're in the righ place or somthing, \D means check that it wasn't an integer (the thing behind wasn't). (?=\d+) it means the same thing except ?= means look ehead and /d+ means check that the thing ahead is a number (then don't split here) the + means it can be any number from 1 to anything.
        foreach (string i in verse)
        {
            Verse stuff = new Verse(i);
            allVerses.Add(stuff);
            
            
        }
    }
    private void MakeTotalList() //this is making that big list of words to hide
    {
        
        foreach (Verse verse in allVerses)
        {
            foreach (Word word in verse.GetAllWords())
            {
                
                if (word.GetWordValue() == true)
                {
                    allShown.Add(word);
                }
            }
        }
    }
    public void RunScripture()//this calls all of the different 
    {
        Console.WriteLine(refferance);
        do
        {
            Console.Clear();
            foreach (Verse verse in allVerses)
            {
                verse.PrintVerse();
            }
            action = Console.ReadLine().ToLower();
            HideNextBatch();
            loopAmount++;
            
            
        } while(loopAmount < totalIterations && action != "quit");
    }
      private void HideNextBatch()
    {
        Random random = new Random();
        for (int i = 0; i < difficulty; i++)
        {
            if (allShown.Count() != 0)
            {
                int toHide = random.Next(0,allShown.Count);
                allShown[toHide].SetHidden();
                allShown.RemoveAt(toHide); 
            }
            else
            {
                break;
            }

        }
    }
}