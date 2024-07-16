using System.Formats.Asn1;

class PlantBuilder
{
    private string[] rotationFamilies = 
    {
        "Apiaceae",
        "Asteraceae",
        "Brassicaceae",
        "Chenopodiaceae",
        "Cucurbitaceae",
        "Ericaceae",
        "Fabaceae",
        "Lamiaceae",
        "Liliaceae",
        "Poaceae",
        "Polygonaceae",
        "Rosaceae",
        "Solanaceae"
    };
    private string[] soilTypes = 
    {
        "Clay",
        "Sandy",
        "Silty",
        "Peaty",
        "Chalky", 
        "Loamy"
    };
    private string[] sunLevels = 
    {
        "FullSun",
        "Partial",
        "Shaded"
    };
    private string[] hardinessList = 
    {
        "1a", 
        "1b", 
        "2a", 
        "2b", 
        "3a",
        "3b",
        "4a",
        "4b",
        "5a",
        "5b",
        "6a",
        "6b",
        "7a",
        "7b",
        "8a", 
        "8b",
        "9a",
        "9b",
        "10a",
        "10b",
        "11a",
        "11b",
        "12a",
        "12b",
        "13a",
        "13b"
    };

    private Picker<string> stringPicker = new Picker<string>();
    private Picker<int> intPicker = new Picker<int>();
     public PlantBuilder()
    {
        
    }

    public Plant BuildPlant()
    {
        Console.WriteLine("Flowing or Harvestable: ");
        string plantType = stringPicker.GetUserBoolChoice("Flowering", "Harvestable") ? "Flowering" : "Harvestable";
        Console.WriteLine("Name of plant: ");
        string plantName = Console.ReadLine();
        Console.WriteLine("Plant's hardiness zone number: ");
        string hardinessZone = stringPicker.GetUserChoice(hardinessList);
        Console.WriteLine("Spacing: "); // add more here like width and depth, probably more questions
        int spacing = int.Parse(Console.ReadLine());
        Console.WriteLine("Sun amount needed");
        string sunLevel = stringPicker.GetUserChoice(sunLevels);
        Console.WriteLine("Type of soil it needs: ");
        string soilType = stringPicker.GetUserChoice(soilTypes);
        Console.WriteLine("Perinial?: ");
        bool perinial = stringPicker.GetUserBoolChoice("Y", "N");
        Console.WriteLine("Frost tolerant?: ");
        bool frostTolerant = stringPicker.GetUserBoolChoice("Y", "N");
        Console.WriteLine("Crop rotation family: ");
        string plantRotationFamily = stringPicker.GetUserChoice(rotationFamilies);
        Console.WriteLine("Type out it's planting and growth needs ");
        string sowAndPlant = Console.ReadLine();
        List<string> beneficiaries = BuildList(true);
        List<string> benefactors = BuildList(false);
        List<string> mutual = MutualList(ref beneficiaries, ref benefactors);
        Plant newPlant;
        switch (plantType)
        {   
            case "Harvestable":
                newPlant = new Harvestable(plantName, hardinessZone, spacing, sunLevel, soilType, perinial, frostTolerant, plantRotationFamily, sowAndPlant, beneficiaries, benefactors, mutual);
                break;
            case "Flowering":
                newPlant = new Flowering(plantName, hardinessZone, spacing, sunLevel, soilType, perinial, frostTolerant, plantRotationFamily, sowAndPlant, beneficiaries, benefactors, mutual);
                break;
            case "Plant":
                newPlant = new Plant(plantName, hardinessZone, spacing, sunLevel, soilType, perinial, frostTolerant, plantRotationFamily, sowAndPlant, beneficiaries, benefactors, mutual);
                break;
            default:
                throw new InvalidOperationException($"Unknown goal type: {plantType}");  
        }
         return newPlant;
    }
    // private void BuildDictioanry(bool b)
    // {   
  
    //     Dictionary<string, Plant> companionPlants = new Dictionary();
    //     Console.WriteLine(b ? "Add all plants that help the plant you're creating." : "Add all the plants that this plant helps");
    //     Console.WriteLine("Include duplicates\nType \"done\" when you've added them all");
    //     string answer = Console.ReadLine().ToUpper();
    //     do
    //     {
            
    //         if (choice.Equals(typeof(bool)))
    //         {
    //             return Y.ToUpper() == choice;//return true if it's a Yes and false if it's a No 
    //         }
    //         Console.WriteLine("Invalid choice. Please try again.");
    //     }while (answer != "Done");
    // }
    private List<string> BuildList(bool b)
    {   
  
        List<string> companionPlants = new List<string>();
        Console.WriteLine(b ? "Add all plants that help the plant you're creating." : "Add all the plants that the plant you're creating helps");
        Console.WriteLine("Include duplicates\nType \"done\" when you've added them all");
        string answer = Console.ReadLine().ToUpper();
        while (answer != "Done")
        {   
            companionPlants.Add(answer);
            answer = Console.ReadLine().ToUpper();
        };
        return companionPlants;
    }
    private List<string> MutualList(ref List<string> listA, ref List<string> listB)
    {
        var intersect = listA.Intersect(listB).ToList();
        listA = listA.Except(intersect).ToList();
        listB = listB.Except(intersect).ToList();
        
        return intersect;
    }
    
}