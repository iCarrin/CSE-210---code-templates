using System.Text.RegularExpressions;
public class Verse
{
    private List<Word> allVerseWords = new List<Word>();
    private string wholeVerse;
    private string[] splitVerse;
    // private int verseLocation;
   

    private string delimiterChars = @"(?<=\s)|(?=[\s;,!?.])";
    public Verse(string wholeVerse/*, int verseLocation*/)
    {
        this.wholeVerse = wholeVerse;
        // this.verseLocation = verseLocation;
        splitVerse = SplitVerse();
        allVerseWords = PopWordList();

    }
   
    private string[] SplitVerse()
    {
        string[] splitVerse = Regex.Split(wholeVerse, delimiterChars);
        return splitVerse;
    }
    
    private List<Word> PopWordList()
    {
        for (int i = 0;i < splitVerse.Length; i++)
        {
            Word nextWord = new Word(splitVerse[i], false);
            allVerseWords.Add(nextWord);
        } 
        return allVerseWords;
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
    // public int GetLocation()
    // {
    //     return verseLocation;
    // }
}