using Newtonsoft.Json;
// using System.Runtime.CompilerServices;
[JsonConverter(typeof(PlantConverter))]
abstract class Plant
{
    //open intergrated terminal dotnet add package Newtonsoft.Json
        // it just works
        //but you can write a serilizer and deseriliser converters 
        //a seperate constructor can call it;s own constructor from its own class
    [JsonProperty]
    private string plantName; //{ get; } 
    // [JsonProperty]
    // private string hardinessZone; //{ get;}
    // public string HardinessZone
    // {get;}
    [JsonProperty]
    private int spacing; //{ get; } 
    public int Spacing
    {get;}
    // [JsonProperty]
    // private string sunLevel; //{ get; }
    // [JsonProperty]
    // private string soilType; //{ get; }  
    // [JsonProperty]
    // private bool perinial; //{ get; } 
    // [JsonProperty]
    // private bool frostTolerant; //{ get; } 
    // [JsonProperty]
    // private string plantRotationFamily; //{ get; } 
    // [JsonProperty]
    // private string sowAndPlant ; //{ get; }

    [JsonProperty]
    private List<string> beneficiaries;
    [JsonProperty]
    private List<string> benefactors;
    [JsonProperty]
    private List<string> mutual;

    public Plant()
    {

    }
    public Plant(string name, /*string hardinessZone,*/ int spacing, /*tring sunLevel, string soilType, bool perinial, bool frostTolerant, string plantRotationFamily, string sowAndPlant, */List<string> beneficiaries, List<string> benefactors, List<string> mutual)
    {
        plantName = name;
        // this.hardinessZone = hardinessZone;
        this.spacing = spacing;
        // this.sunLevel = sunLevel;
        // this.soilType = soilType;
        // this.perinial = perinial;
        // this.frostTolerant = frostTolerant;
        // this.plantRotationFamily = plantRotationFamily;
        // this.sowAndPlant = sowAndPlant;
        this.beneficiaries = beneficiaries;
        this.benefactors = benefactors;
        // this.mutual = mutual;
    }
    // public string DisplayDict (Dictionary<string, Plant> dict)//kind of a temporary things to test the dictionary sorter
    // {
    //     string list = "";
    //     foreach (var key in dict.Keys)
    //     {
    //        list += $"{key} \n";
    //     }
    //     return list;
    // }
    
    public int GetSpacing()
    {
        return spacing;
    }
    public void PrintAllLists(List<string> referanceList)
    {
        // if (mutual.Count != 0) 
        // {
        //     var mutualSort = SortSmallList(referanceList, mutual);
        //     Console.WriteLine($"Mutualy beneficial plants: {string.Join(", ", mutual)}");
            
            
        // };
        if (beneficiaries.Count != 0) 
        {
            var beneficiariesSort = SortSmallList(referanceList, beneficiaries);
            Console.WriteLine($"Plants that help {plantName}: ");
            
            for (int i = 0; i < beneficiaries.Count;)
            {
                Console.Write($"{beneficiaries[i]} ");
                i++;
                Console.Write($"{beneficiaries[i+1]} ");
                i++;
                Console.Write($"{beneficiaries[i+2]} ");
                i++;
                Console.Write($"{beneficiaries[i+3]} ");
                i++;
                Console.Write($"{beneficiaries[i+4]} ");
                i++;
                Console.WriteLine();  
            }

            
        };
        if (benefactors.Count != 0) 
        {
            var benefactorsSort = SortSmallList(referanceList, beneficiaries);
            Console.WriteLine($"Plants that {plantName} helps \n{SortSmallList(referanceList, benefactors)}");
            for (int i = 0; i < benefactors.Count;)
            {
                Console.Write($"{benefactors[i]} ");
                i++;
                Console.Write($"{benefactors[i+1]} ");
                i++;
                Console.Write($"{benefactors[i+2]} ");
                i++;
                Console.Write($"{benefactors[i+3]} ");
                i++;
                Console.Write($"{benefactors[i+4]} ");
                i++;
                Console.WriteLine();  
            }
        };
    }
    private List<string> SortSmallList(List<string> referanceList, List<string> toSort)
    {
         var sortedList = toSort
            .OrderBy(item => referanceList.IndexOf(item))
            .ToList();
        return sortedList;
    }

    public override string ToString()
    {
        return plantName;
        
    }

   
    public void PrintPlantInfo()
    {
        Console.WriteLine($"Plant Name: {plantName}");
        // Console.WriteLine($"Hardiness Zone: {hardinessZone}");
        Console.WriteLine($"Spacing: {spacing} SQ inches");
        // Console.WriteLine($"Sun Level: {sunLevel}");
        // Console.WriteLine($"Soil Type: {soilType}");
        // Console.WriteLine($"Perennial: {(perinial ? "Yes" : "No")}");
        // Console.WriteLine($"Frost Tolerant: {(frostTolerant ? "Yes" : "No")}");
        // Console.WriteLine($"Plant Rotation Family: {plantRotationFamily}");
        // Console.WriteLine($"Sow and Plant: {sowAndPlant}");

        Console.WriteLine("Beneficiaries:");
        if (beneficiaries != null && beneficiaries.Any())
        {
            foreach (var beneficiary in beneficiaries)
            {
                Console.WriteLine($"  - {beneficiary}");
            }
        }
        else { Console.WriteLine("  None"); }

        Console.WriteLine("Benefactors:");
        if (benefactors != null && benefactors.Any())
        {
            foreach (var benefactor in benefactors)
            {
                Console.WriteLine($"  - {benefactor}");
            }
        }
        else { Console.WriteLine("  None"); }

    //     Console.WriteLine("Mutual:");
    //     if (mutual != null && mutual.Any())
    //     {
    //         foreach (var mutualPlant in mutual)
    //         {
    //             Console.WriteLine($"  - {mutualPlant}");
    //         }
    //     }
    //     else { Console.WriteLine("  None"); }
    // }
    }    
}