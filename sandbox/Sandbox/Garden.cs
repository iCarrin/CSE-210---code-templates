using Newtonsoft.Json;
[JsonConverter(typeof(GardenConverter))]
class Garden 
{
    
    [JsonProperty]
    public string name;

    [JsonProperty]
    public double area;

    [JsonProperty]
    public string sunExposure;

    [JsonProperty]
    public int growingZone;

    [JsonProperty]
    public Dictionary<string, Plant> plantsInGarden;

    [JsonProperty] // This property doesn't need to be serialized
    private Dictionary<string, Plant> catalog;

    
        
    Picker<string> picker = new Picker<string>();
    Picker<Plant> plantPicker = new Picker<Plant>();
    

    public Garden(string name, double area, string sunExposure, int growingZone, Dictionary<string, Plant> plantsInGarden, Dictionary<string, Plant> catalogNew) 
    {
        this.name = name;
        this.area = area;
        this.sunExposure = sunExposure;
        this.growingZone = growingZone;
        this.plantsInGarden = plantsInGarden ?? new Dictionary<string, Plant>();
        // catalog = OrganizePlants(catalogNew);
        catalog = catalogNew;
    }

    public string GetName()
    {
        return name;
    }
    // public SortedDictionary<string, Plant> OrganizePlants(Dictionary<string,Plant> catalogToSort)
    // {
    //     SortedDictionary<string, Plant> results = new SortedDictionary<string,Plant>();
    //     int orderNum = 0;
    //     var values = catalogToSort.Values.ToList();
    //     foreach (Plant p in values)
    //     {
    //         if (p.Spacing > area)
    //         {
    //             values.Remove(p);
    //             values.Add(p);
    //         }
    //         else 
    //         {
    //             orderNum++;
    //         }
    //     }
    //     foreach(var p in values)
    //     {
    //         results.Add(p.ToString(), p);
    //     }
    //     return results;
    //     // foreach (Plant p in catalog)
    //     // {
    //     //     if (p.HardinessZone > area)
    //     //     {
    //     //         catalog.Remove(p);
    //     //         catalog.Add(p);
    //     //     }
    //     //     else 
    //     //     {
    //     //         orderNum++;
    //     //     }
    //     // }

    // }this is a method to be built out later.
    

    public void FindMatch()
    {
        if (plantsInGarden.Count != 0)
        {
            List<string> cat;
            Console.WriteLine("Find a match for a plant currently in the garden?");
            bool where = picker.GetUserBoolChoice("Y", "N");
            Console.WriteLine("What plant are you considering?"); 
            Plant matchA = plantPicker.GetUserChoice(where ? plantsInGarden.Values : catalog.Values);
            cat = matchA.beneficiaries.Concat(matchA.benefactors).ToList();
            matchA.PrintAllLists(cat);
            AddPlant();
        }

    }

    public void AddPlant()
    {
        Console.WriteLine("What plant do you want to add?");
        while (true)
        {
            string plantName = Console.ReadLine().ToLower();
                       
            //if that word is in the list return that word
            if (catalog.Keys.Contains(plantName))
            {
                plantsInGarden.Add(plantName,catalog[plantName]);
                break;
            }
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    public void RemovePlant()
    {
         Console.WriteLine("What plant do you want to remove?");
        while (true)
            {
                string plantName = Console.ReadLine().ToLower();
                        
                //if that word is in the list return that word
                if (catalog.Keys.Contains(plantName))
                {
                    plantsInGarden.Remove(plantName);
                    break;
                }
                Console.WriteLine("Invalid choice. Please try again.");
            }
    }

    // public void UpdateGardenSize()
    // {
    //     Console.WriteLine("What's the new width?");
    //     out double width = double.Parse(Console.ReadLine());
    //     Console.WriteLine("What's the new height?");
    //     out double height = double.Parse(Console.ReadLine());
    //     out double area = width * height;
    // } method for latter
}
