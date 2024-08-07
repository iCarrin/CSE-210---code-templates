public class Picker<T>
{
    public T GetUserChoice(IEnumerable<T> items)
    {

        while (true)
        {
            Console.WriteLine("Choose an option:");
            var itemList = items.ToList();
            for (int i = 0; i < itemList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {itemList[i]}");//write out the list is a human way (1-n list)
            }
            // if it's an int that the use put in (if yes pass that to the choice variable) and its greater than 1, and smaller or equal to the length of the list
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= itemList.Count)
            {
                return itemList[choice - 1];//return that choice to the computer with 1 subtracted so the computer can use it (0-n lists)
            }
            
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    public string GetUserWordChoice(IEnumerable<string> items)
    {
        // IEnumerable<T> items = listToPickFrom;

        while (true)
        {
            Console.WriteLine("Choose an option:");
            // get and capitalize the answer
            string choice = Console.ReadLine().ToLower();
            //if that word is in the list return that word
            if (items.Contains(choice))
            {
                return choice;//return that choice to the computer 
            }
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
    public int GetUserNumberChoice(int first, int count)
    {

        while (true)
        {
            Console.WriteLine($"Between {first} and {first + count}:");
            IEnumerable<int> range = Enumerable.Range(first, count);
            
            string choice = Console.ReadLine();
            //if that word is in the list return that word
            if(int.TryParse(choice, out int result) && range.Contains(result))
            {
                return result;
            }
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
    public bool GetUserBoolChoice(string Y, string N)
    {
        Console.WriteLine($"{Y}/{N}");

        while (true)
        {
            var choice = Console.ReadLine().ToUpper();
            if (choice == Y.ToUpper())
            {
                return true;//return true if it's a Yes and false if it's a No 
            }
            else if (choice == N.ToUpper())
            {
                return false;//return true if it's a Yes and false if it's a No 
            }
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
    internal Plant GetUserPlantChoice(Dictionary<string, Plant> items)
    {

        while (true)
        {
            Console.WriteLine("Choose an option:");
            var itemList = items.Keys.ToList();
            int column = 0;
            for (int i = 0; i < itemList.Count;i++)
            {
                
                Console.Write($"{i+1}. {itemList[i]} ");
                column++;
                if (column > 5)
                {
                    column = 0;
                    Console.WriteLine();
                } 
            }
            // if it's an int that the use put in (if yes pass that to the choice variable) and its greater than 1, and smaller or equal to the length of the list
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= itemList.Count)
            {
                return items[itemList[choice - 1]];//return that choice to the computer with 1 subtracted so the computer can use it (0-n lists)
            }
            
            
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
     
}