using Newtonsoft.Json;
[JsonConverter(typeof(GardenConverter))]
class Garden 
{

    [JsonProperty]
    private string name;
    [JsonProperty]
    private double area;
    [JsonProperty]
    private string sunExposure;
    [JsonProperty]
    private int growingZone;
    [JsonProperty]
    private List<string> plantNames;
    private Dictionary<string, Plant> plantsInGarden;
    private Dictionary<string, Plant> catalog;   
    private Picker<string> picker = new Picker<string>();
    private Picker<Plant> plantPicker = new Picker<Plant>();
    

    public Garden(string name, double area, string sunExposure, int growingZone, Dictionary<string, Plant> plantsInGarden, Dictionary<string, Plant> catalogNew) 
    {
        this.name = name;
        this.area = area;
        this.sunExposure = sunExposure;
        this.growingZone = growingZone;
        this.plantsInGarden = plantsInGarden ?? new Dictionary<string, Plant>();
        //catalog = OrganizePlants(catalogNew);
        catalog = catalogNew;
       
        plantNames = this.plantsInGarden.Keys.ToList();
        
        
    }

    public string GetName()
    {
        return name;
    }
    public void PopCatalog(Dictionary<string, Plant> catalog)
    {
        this.catalog = catalog;
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
            
            Console.WriteLine("Are you finding a match for a plant currently in the garden?");
            bool where = picker.GetUserBoolChoice("Y", "N");
            Console.WriteLine("What plant are you considering?"); 
            Plant matchA = plantPicker.GetUserPlantChoice(where ? plantsInGarden : catalog);
            bool which = picker.GetUserBoolChoice("beneficiar", "Benefactor");
            string matchFinal;
            if (which == true)
            {
                
                matchFinal = picker.GetUserChoice(matchA.Benefs(true));
            }
            else
            {
                matchFinal = picker.GetUserChoice(matchA.Benefs(false));
            }
            if (catalog.ContainsKey(matchFinal))
            {
                plantsInGarden.Add(matchFinal, catalog[matchFinal]);
                plantNames.Add(matchFinal);
            }
            else
            {
                Console.WriteLine("That plant has a typo in it's name or it hasn't been created.");
                Thread.Sleep(2000);
            }
            
        }

    }

    public void AddPlant()
    {
        Console.WriteLine("What plant do you want to add?");
        Plant toAdd = plantPicker.GetUserPlantChoice(catalog);
        plantsInGarden.Add(toAdd.GetName(), toAdd);
        plantNames.Add(toAdd.GetName());
        
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
