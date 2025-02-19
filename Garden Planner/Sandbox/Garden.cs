using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
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
    private /*OrderedDictionary*/Dictionary<string, Plant> catalog;   
    private Picker<string> picker = new Picker<string>();
    private Picker<Plant> plantPicker = new Picker<Plant>();
    

    public Garden(string name, double area, string sunExposure, int growingZone, Dictionary<string, Plant> plantsInGarden, Dictionary<string, Plant> catalogNew) 
    {
        this.name = name;
        this.area = area;
        this.sunExposure = sunExposure;
        this.growingZone = growingZone;
        this.plantsInGarden = plantsInGarden ?? new Dictionary<string, Plant>();
        
        catalog = catalogNew;
       
        plantNames = this.plantsInGarden.Keys.ToList();
        
        
    }

    public void PopCatalog(Dictionary<string, Plant> catalog)
    {
        this.catalog = catalog;
    }
    
    public void DisplayPlantsInGarden()
    {
        int column = 0;
        
        for (int i = 0; i < plantNames.Count;i++)
        {
            
            Console.Write($"{i+1}. {plantNames[i]} ");
            column++;
            if (column > 5)
            {
                column = 0;
                Console.WriteLine();
            } 
        }
        Console.ReadLine();
    }
    public string GetName()
    {
        return name;
    }
    // public void OrganizePlants(Dictionary<string,Plant> catalogToSort)
    // {
    //     foreach (KeyValuePair<string,Plant> p in catalogToSort)
    //             {
    //                 Console.WriteLine(p.Value.PlantName);
    //             }
        
    //     int orderNum = 0;
    //     List<Plant> values = catalogToSort.Values.ToList();
    //     List<Plant> toMove = new List<Plant>();
    //     foreach (Plant p in values)
    //             {
    //                 Console.WriteLine(p.PlantName);
    //             }

    //     foreach (Plant p in values)
    //     {
    //         if (p.Spacing > area)
    //         {
    //             toMove.Add(p);
    //         }
    //         else 
    //         {
    //             orderNum++;
    //         }
    //     }
    //     foreach (Plant p in toMove)
    //     {
    //         values.Remove(p);
    //         values.Add(p);
    //     }
    //     toMove.Clear();
    //     for(int i = 0; i < orderNum; i++)
    //     {
    //         if ( values[i] is Perennial perennial)
    //         {   
    //             if (perennial.HardinessZone > growingZone)
    //             {
    //                 toMove.Add(perennial);
    //                 values.RemoveAt(i);
    //                 i--;       
    //             }
    //         }
    //     }
    //     foreach (Plant p in toMove)
    //     {
    //         values.Add(p);
    //     }
    //     var results = new OrderedDictionary();
    //     foreach(Plant p in values)
    //     {
    //         results.Add(p.PlantName, p);
    //     }
    //     catalog = results;
    // }
    

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
            if (catalog.Keys.Contains(matchFinal))
            {
                plantsInGarden.Add(matchFinal, (Plant)catalog[matchFinal]);
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
                string plantName = picker.GetUserChoice(plantNames);
                        
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
