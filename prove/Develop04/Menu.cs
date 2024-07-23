class Menu
{
    int state = 2000;
    public Menu ()
    {

    }
    private int AskMenu()
    {
        Console.WriteLine("Breathing : 1");
        Console.WriteLine("Reflect : 2");
        Console.WriteLine("Enumerate : 3");
        Console.WriteLine("Quit : 0");
        int state = int.Parse(Console.ReadLine() );
        return state;
    }
    public void CallMenu()
    {

        do 
        {
            state = AskMenu();
            
            switch (state)
            {
                case 1:
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity();
                    Type type = breathingActivity.GetType();
                    Console.WriteLine(type);
                    breathingActivity.Run();
                    break;
                case 2:
                    Console.Clear();
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Run();
                    break;
                case 3:
                    Console.Clear();
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                default:
                    break;
            }
        } while (state != 0);
    }


}