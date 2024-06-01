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
        foreach (string i in verse) // all the text has been split before the numbers
        {
            Verse stuff = new Verse(i); //make a new verse instance
            allVerses.Add(stuff); //add that verse to the list of verse
            
            
        }
    }
    private void MakeTotalList() //this is making that big list of words to hide
    {
        
        foreach (Verse verse in allVerses) //from all the verses
        {
            foreach (Word word in verse.GetAllWords())//get all the words
            {
                
                if (word.GetWordValue() == true)//if that word tells us it's not a space or a punctiaon mark
                {
                    allShown.Add(word);//add it to the list of availble words that can be hidden
                }
            }
        }
    }
    public void RunScripture()//this prints all the scriptures and then turns the next few words to hidden
    {
        do
        {
            Console.Clear(); //clears the console
            Console.WriteLine(refferance); //prints the refferance first and formost
            foreach (Verse verse in allVerses) //for each verse run it's print function
            {
                verse.PrintVerse();
            }
            action = Console.ReadLine().ToLower(); //stop and wait for the quit or really anything so you can see stuff
            HideNextBatch();//run the hide function to hide the next few words
            loopAmount++; //add to the loop amount
            
            
        } while(loopAmount < totalIterations && action != "quit"); // if the acumulated amount of loops is less than the amount I said it should loop and nobody typed quit keep going. If either become false the loop ends
    }
      private void HideNextBatch()//heres how we decide what to hide
    {
        Random random = new Random();
        for (int i = 0; i < difficulty; i++)// this will hide one word for the amount the difficulty sets
        {
            if (allShown.Count() != 0) //make sure there is still stuff to hide
            {
                int toHide = random.Next(0,allShown.Count); // get a random integer between 0 and how ever long the avilble words list is.
                allShown[toHide].SetHidden();// set that word to hidden
                allShown.RemoveAt(toHide); // and remove that word from the list so it will give a true reading next time
            }
            else
            {
                break; //if the available list is 0 don't run this function anymore
            }

        }
    }
}