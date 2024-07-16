using Newtonsoft.Json;
// using System.Runtime.CompilerServices;

class Plant
{
    //open intergrated terminal dotnet add package Newtonsoft.Json
        // it just works
        //but you can write a serilizer and deseriliser converters 
        //a seperate constructor can call it;s own constructor from its own class
    [JsonProperty]
    private string plantName { get; } 
    [JsonProperty]
    private (int, char) hardinessZone { get;}
    [JsonProperty]
    private int spacing { get; } 
    [JsonProperty]
    private string sunLevel; 
    [JsonProperty]
    private string soilType;     
    [JsonProperty]
    private bool perinial { get; } 
    [JsonProperty]
    private bool frostTolerant { get; } 
    [JsonProperty]
    private string plantRotationFamily { get; } 
    [JsonProperty]
    private string sowAndPlant  { get; }
    // public Dictionary<string, Plant> beneficiaries = new Dictionary<string, Plant>();
    // public Dictionary<string, Plant> benefactors = new Dictionary<string, Plant>();
    [JsonProperty]
    private List<string> beneficiaries;
    [JsonProperty]
    private List<string> benefactors;
    [JsonProperty]
    private List<string> mutual;

    public Plant(string name, (int, char) hardinessZone, int spacing, string sunLevel, string soilType, bool perinial, bool frostTolerant, string plantRotationFamily, string sowAndPlant, List<string> beneficiaries, List<string> benefactors, List<string> mutual)
    {
        plantName = name;
        this.hardinessZone = hardinessZone;
        this.spacing = spacing;
        this.sunLevel = sunLevel;
        this.soilType = soilType;
        this.perinial = perinial;
        this.frostTolerant = frostTolerant;
        this.plantRotationFamily = plantRotationFamily;
        this.sowAndPlant = sowAndPlant;
        this.beneficiaries = beneficiaries;
        this.benefactors = benefactors;
        this.mutual = mutual;
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
    public void PrintAllLists(List<string> referanceList)
    {
        if (mutual.Count != 0) 
        {
            var mutual = SortSmallList(referanceList, mutual);
            Console.WriteLine($"Mutualy beneficial plants: {string.Join(", ", mutual)}")
            
            
        };
        if (beneficiaries.Count != 0) 
        {
            var beneficiaries = SortSmallList(referanceList, beneficiaries)
            Console.WriteLine($"Plants that help {plantName}: ")
            
            for (int i = 0; i < beneficiaries.Count; i+5)
            {
                Console.Write(beneficiaries[i]" ");
                Console.Write(beneficiaries[i+1]" ");
                Console.Write(beneficiaries[i+2]" ");
                Console.Write(beneficiaries[i+3]" ");
                Console.Write(beneficiaries[i+4]" ");
                Console.WriteLine();  
            }

            
        };
        if (benefactors.Count != 0) 
        {
            Console.WriteLine($"Plants that {plantName} helps \n{SortSmallList(referanceList, mutual)}");
            for (int i = 0; i < benefactors.Count; i+5)
            {
                Console.Write(benefactors[i]" ");
                Console.Write(benefactors[i+1]" ");
                Console.Write(benefactors[i+2]" ");
                Console.Write(benefactors[i+3]" ");
                Console.Write(benefactors[i+4]" ");
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
        return $"{plantName}: {plantRotationFamily}: {hardinessZone}";
        
    }

   
        public void PrintPlantInfo()
    {
        Console.WriteLine($"Plant Name: {plantName}");
        Console.WriteLine($"Hardiness Zone: {hardinessZone.Item1} - {hardinessZone.Item2}");
        Console.WriteLine($"Spacing: {spacing} inches");
        Console.WriteLine($"Sun Level: {sunLevel}");
        Console.WriteLine($"Soil Type: {soilType}");
        Console.WriteLine($"Perennial: {(perinial ? "Yes" : "No")}");
        Console.WriteLine($"Frost Tolerant: {(frostTolerant ? "Yes" : "No")}");
        Console.WriteLine($"Plant Rotation Family: {plantRotationFamily}");
        Console.WriteLine($"Sow and Plant: {sowAndPlant}");

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

        Console.WriteLine("Mutual:");
        if (mutual != null && mutual.Any())
        {
            foreach (var mutualPlant in mutual)
            {
                Console.WriteLine($"  - {mutualPlant}");
            }
        }
        else { Console.WriteLine("  None"); }
    }
    {
    // public /*Dictionary<string, Plant> string*/ void GetCompanionList(Dictionary<string, Plant> sortedDict)
    // {
    //     var sortedKeys = sortedDict.Keys.ToList();

    //     var sortedBeneficiaries = beneficiaries
    //         .OrderBy(pair => sortedKeys.IndexOf(pair.Key))
    //         .ToDictionary(pair => pair.Key, pair => pair.Value);

    //     var sortedBenefactors = benefactors
    //         .OrderBy(pair => sortedKeys.IndexOf(pair.Key))
    //         .ToDictionary(pair => pair.Key, pair => pair.Value);

    //     var intersect = sortedBenefactors.Keys.Intersect(sortedBeneficiaries.Keys).ToList();
    //     var mutual = new Dictionary<string, Plant>();


    
    // public /*Dictionary<string, Plant> string*/ void GetCompanionList(Dictionary<string, Plant> sortedDict)
    // {
    //     var sortedKeys = sortedDict.Keys.ToList();

    //     var sortedBeneficiaries = beneficiaries
    //         .OrderBy(pair => sortedKeys.IndexOf(pair.Key))
    //         .ToDictionary(pair => pair.Key, pair => pair.Value);

    //     var sortedBenefactors = benefactors
    //         .OrderBy(pair => sortedKeys.IndexOf(pair.Key))
    //         .ToDictionary(pair => pair.Key, pair => pair.Value);

    //     var intersect = sortedBenefactors.Keys.Intersect(sortedBeneficiaries.Keys).ToList();
    //     var mutual = new Dictionary<string, Plant>();

    //     foreach (string s in intersect)
    //         {
    //             mutual.Add(s, sortedBenefactors[s]);
    //             sortedBenefactors.Remove(s);
    //             sortedBeneficiaries.Remove(s);
    //         }
    //     public Dictionary<string, Plant> wholeHelpers = new Dictionary<string, Plant> 
    //     (
    //         mutual.Union(sortedBeneficiaries).Union(sortedBenefactors)
    //     );
        // string wholeList =  $"Plants that both help this plant and that this plant helps: \n{string.Join(", ", mutual.Keys)}\n" +
                            // $"Plants that help this plant: \n{string.Join(", ", sortedBenefactors.Keys)}\n" +
                            // $"Plants that this plant can help: \n{string.Join(", ", sortedBeneficiaries.Keys)}";
        // return wholeList;
        // from here make a seprate dictioanry to house the sameies and write all three to a list tyype things and return that.
        
    //     Console.WriteLine($"Plants that both help this plant and that this plant helps: \n{DisplayDict(mutual)}\nPlants that help this plant: \n{DisplayDict(sortedBeneficiaries)}\nPlants that this plant can help: \n{DisplayDict(sortedBenefactors)}");
    // }
    }
    
    
}