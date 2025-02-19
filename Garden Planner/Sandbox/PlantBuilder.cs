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
        "Solanaceae",
        "Miscellaneous"
    };

    private string[] sunLevels = 
    {
        "FullSun",
        "Partial",
        "Shaded"
    };
   

    private Picker<string> stringPicker = new Picker<string>();
    public PlantBuilder()
    {
        
    }

    public Plant BuildPlant()
    {
        Console.WriteLine("Perennial or Annual: ");
        string plantType = stringPicker.GetUserBoolChoice("Perennial", "Annual") ? "Perennial" : "Annual";
        Console.WriteLine("Name of plant: ");
        string plantName = Console.ReadLine();
        Console.WriteLine("Square inch spacing: "); 
        double spacing = double.Parse(Console.ReadLine());
        Console.WriteLine("Sun amount needed\nAs bright as ");
        string sunLevel = stringPicker.GetUserChoice(sunLevels);
        Console.WriteLine("to as shadded as ");
        sunLevel += " to " + stringPicker.GetUserChoice(sunLevels);
        Console.WriteLine("Type of soil it needs: ");
        string soilType = Console.ReadLine();
        Console.WriteLine("Frost tolerant?: ");
        bool frostTolerant = stringPicker.GetUserBoolChoice("Y", "N");
        Console.WriteLine("Crop rotation family: ");
        string plantRotationFamily = stringPicker.GetUserChoice(rotationFamilies);
        Console.WriteLine("Type out it's planting and growth needs ");
        string sowAndPlant = Console.ReadLine();
        Console.WriteLine("When and how should this plant be harvested or picked? ");
        string harvestTime = Console.ReadLine();
        List<string> beneficiaries = BuildList(true);
        List<string> benefactors = BuildList(false);
        Console.WriteLine("Any additional notes on this plant: ");
        string notes = Console.ReadLine();
       
        Plant newPlant;
        switch (plantType)
        {   
            case "Annual":
                newPlant = new Annual(plantName, spacing, sunLevel, soilType, frostTolerant, plantRotationFamily, sowAndPlant, harvestTime, beneficiaries, benefactors, notes);
                break;
            case "Perennial":
                newPlant = new Perennial(plantName, spacing, sunLevel, soilType, frostTolerant, plantRotationFamily, sowAndPlant, harvestTime, beneficiaries, benefactors, notes);
                break;
           
            default:
                throw new InvalidOperationException($"Unknown goal type: {plantType}");  
        }
         return newPlant;
    }
       private List<string> BuildList(bool b)
    {   
  
        List<string> companionPlants = new List<string>();
        Console.WriteLine(b ? "Add all plants that help the plant you're creating." : "Add all the plants that the plant you're creating helps");
        Console.WriteLine("Include duplicates\nType \"done\" when you've added them all");
        string answer = Console.ReadLine().ToUpper();
        while (answer != "DONE")
        {   
            companionPlants.Add(answer);
            answer = Console.ReadLine().ToUpper();
        };
        return companionPlants;
    }
    
    
}