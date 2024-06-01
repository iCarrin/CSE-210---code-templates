//using System.Security.Cryptography;

public class Word
{
   
    private string word;
    // private int location;
    private bool isWord;
    private bool isHidden;
    private List<char> delimiterChars = ['(', ')', ' ', ';', ',', '!', '?', '.', ']', '[', ':'];
    
    
    public Word(string word, bool isHidden)
    {
        this.word = word;
        
        this.isHidden = isHidden;
        isWord = DedeicateIsWord();
    }
    public void DisplayWord()
    {
        
        if (isHidden == false)
            Console.Write(word);
        else
            foreach (char c in word)
            Console.Write("_");
        // PrintAll();
        
    }
    
    public bool GetWordValue()
    {
        return isWord;
    }
    public bool SetHidden()
    {   
        isHidden = true;
        return isHidden;
    }
   
    private bool DedeicateIsWord()
    {
       
            if (word.All(c => delimiterChars.Contains(c)) | int.TryParse(word, out int number))
            {
                isWord = false;
            }
            else
            {
                isWord = true;
            }
    
        return isWord;
    }
    public void PrintAll()
    {
        Console.Write($"the word is: \"{word}\" ");
        Console.Write($"is it a word?: {isWord} ");
        Console.Write($"is it a hidden?: {isHidden} ");
        
    }
}