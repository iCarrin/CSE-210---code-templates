class Menu
{
    public void CallMenu()
    {
     int state = 20;
        do 
        {
            state = current.Menu();
            switch (state)
            {
                case 1:
                    current.AddEntry();
                    break;
                case 2:
                    current.DisplayAll();
                    break;
                case 3:
                    current.SaveJournal();
                    break;
                case 4:
                    current.LoadJournal();
                    break;
                default:
                    break;
            }
        } while (state != 0);
    }
}