
class Program
{
    static void Main(string[] args)
    {
        LoadSave lS = new();
        Garden plot;
        Dictionary<string, Plant> allPlantsEver = lS.LoadCatalog();

        PlantBuilder test = new PlantBuilder();
        Picker<string> what = new Picker<string>();
        Picker<Plant> plantPicker = new Picker<Plant>();
        GardenBuilder newGar = new(allPlantsEver);
        string[] menuList =
        {
            "Add a plant from the catalog to the garden",
            "Remove a plant from the garden",
            "Find a companion plant",
            "Show all the plants in the garden",
            "Create a new plant from scratch",
            "Save garden",
            "Quit"
        };
        string choice = "";
        List<string[]> savedFiles = lS.GetSavedFiles();
        
        int possibleGardens = StartMenu(savedFiles);
        
        
        // return choice;
        
        while (choice != "Quit" )
        {
            
            if (possibleGardens == 1)
            {
                plot = newGar.Create();
                plot.PopCatalog(allPlantsEver);
            }
            else
            {
                
                
                plot = lS.LoadFile(savedFiles[possibleGardens-2][1]);
                plot.PopCatalog(allPlantsEver);

            }

            
            while(choice != "Quit")
            {
                Console.Clear();
                choice = what.GetUserChoice(menuList);

                switch (choice)
                {
                    case "Add a plant from the catalog to the garden":
                        Console.WriteLine(allPlantsEver.Count);
                        plot.AddPlant();
                        break;
                    case "Find a companion plant":
                        plot.FindMatch();
                        break;
                    case "Remove a plant from the garden":
                        plot.RemovePlant();
                        break;
                    case "Create a new plant from scratch":
                        Plant plant = new PlantBuilder().BuildPlant();
                        
                        allPlantsEver.Add(plant.GetName(), plant);
                        lS.SaveCatalog(allPlantsEver);
                        //lS.SavePlantList(allPlantsEver);
                        break;
                    case "Save garden":
                        lS.SaveFile(plot);
                        break;
                    case "Show all the plants in the garden":
                        plot.DisplayPlantsInGarden();
                        break;
                    case "Quit":
                        lS.SaveFile(plot);
                        
                        break;
                    default:
                        Console.WriteLine("Invalid choice!\n");
                        break;


                    // watering needs
                    //fix the .ToUpper problem espessially when it's typing out the benifical lists
                    //the add plant to garden method dosn't show this list of plants perhaps the catalog isn't grabing the json file

                }
            }
        }
    
        int StartMenu(List<string[]> savedFiles)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create new garden");
            
            for (int i = 0; i < savedFiles.Count; i++) 
            {
                string[] fileInfo = savedFiles[i];
                Console.WriteLine($"{i + 2}. Open {Path.GetFileNameWithoutExtension(fileInfo[0])}");
            }        
            int choice = 0;
            // Loop until the user enters a valid choice
            while(choice < 1 || choice > savedFiles.Count + 1) {
                try {
                    // Convert the user's input to an integer
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 1 || choice > savedFiles.Count + 1) {
                        Console.WriteLine("Invalid choice!");
                    }
                } catch (FormatException) {
                    Console.WriteLine("You must enter a number!");
                }
            }
            return choice;
        }

    

    }
}