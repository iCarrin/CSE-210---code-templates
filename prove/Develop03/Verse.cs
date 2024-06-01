using System.Text.RegularExpressions;
public class Verse
{
    private List<Word> allVerseWords = new List<Word>(); //holds the verse turned into Word classes
    private string delimiterChars = @"(?<=\s)|(?=[\s;,!?.])"; //these are all the ways to split the word. It's complicated. see split verse method in scripture class. basically keep what we split on, look back to see if there's a white space AND look forward to see if there are any punctuation marks.
    public Verse(string wholeVerse)
    {
        PopWordList(wholeVerse); //this takes the whole text and makes the list of word classes
    }    
    private void PopWordList(string wholeVerse) //this makes the list of word classes for all the words in the verse
    {
        string[] splitVerse = Regex.Split(wholeVerse, delimiterChars); //this takes the verse and splits it acording to the delimiterChars' it splits all words, punctuation, and spaces and turns it into a word class
        for (int i = 0; i < splitVerse.Length; i++) //iterate through thate word list
        {
            Word nextWord = new Word(splitVerse[i], false); // make a word class poulated with the current word
            allVerseWords.Add(nextWord);// put that word into the list of all words
        } 
    }
    public void PrintVerse()
    {
        for (int i = 0;i < allVerseWords.Count(); i++)
        {
            allVerseWords[i].DisplayWord();
        } 
        Console.WriteLine();
    }
    public List<Word> GetAllWords()
    {
        return allVerseWords;
    }
}