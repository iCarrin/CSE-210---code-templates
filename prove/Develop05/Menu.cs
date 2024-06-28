class Menu
{
    int state = 2000;
    string menuList = "Load Goals : 1\nSave Goals : 2\nCheck Off Goals : 3\nCreate Goal : 4\nQuit Program : 0";
    public Menu ()
    {

    }
    private int AskMenu()
    {
        Console.WriteLine(menuList);
        int state = int.Parse(Console.ReadLine() );
        return state;
    }
    public void CallMenu()
    {

        do 
        {
            state = AskMenu();
            // ListOutGoals();

            switch (state)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(menuList);
                    //load all the goals and list them
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