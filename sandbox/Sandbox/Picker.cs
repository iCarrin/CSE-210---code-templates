public class Picker<T>
{
    public T GetUserChoice(IEnumerable<T> items)
    {
        // IEnumerable<T> items = listToPickFrom;

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
}