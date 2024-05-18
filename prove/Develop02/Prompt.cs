class Prompt
{
    public Prompt()
    {
        
    }
    static Random randoNumbo = new Random();
    static List<string> prompts = new List<string>(["Write about a meaningful conversation you had recently", "Describe a place you feel at peace", "What are you most grateful for today?", "Write about a regret you have and what you learned from it", "Describe your favorite childhood memory", "What is one thing you want to accomplish this week?", "Write a letter to your future self", "What is something you want to learn more about?", "Describe a random act of kindness you witnessed or experienced", "What is a personal strength of yours? How can you utilize it more?", "Write about a person who has influenced you greatly", "What is a challenge you are currently facing? How can you work through it?", "Make a list of things that brought you joy this month", "Reflect on a life lesson you have learned", "Write about a childhood dream or aspiration you had", "What is one thing you could do to practice more self-care?", "Write a letter expressing gratitude to someone meaningful", "Describe a place you'd like to travel to and why", "What is a personal goal you are working towards?", "Reflect on a recent failure or setback and how you overcame it."]);
    
    static public string GetPrompt()
    {
        int rPrompt = randoNumbo.Next(1, prompts.Count() + 1);
        return prompts[rPrompt];
    }
}