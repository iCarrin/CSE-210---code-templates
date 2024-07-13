using Newtonsoft.Json;
// using System.Runtime.CompilerServices;

class Plant
{
    //open intergrated terminal dotnet add package Newtonsoft.Json
        // it just works
        //but you can write a serilizer and deseriliser converters 
        //a seperate constructor can call it;s own constructor from its own class

    private bool perinial { get; }
    private bool frostTolerant { get; }
    private int spacing { get; }
    private string plantName { get; }
    private string plantRotationFamily { get; }
    private string SowAndPlant  { get; }
    private string soilType;
    private string sunLevel;
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

    public Dictionary<string, Plant> beneficiaries = new Dictionary<string, Plant>();
    public Dictionary<string, Plant> benefactors = new Dictionary<string, Plant>();
    private Picker<string> stringPicker = new Picker<string>();

    public Plant()
    {
        Console.WriteLine("Name of Plant: ");
        plantName = Console.ReadLine();
        Console.WriteLine("Crop Rotation Family: ");
        plantRotationFamily = Console.ReadLine();
        Console.WriteLine("Type of soil it needs: ");
        soilType = stringPicker.GetUserChoice(soilTypes);
        Console.WriteLine("Sun amount needed");
        sunLevel = stringPicker.GetUserChoice(sunLevels);
        Console.WriteLine("Plant rotation family: ");
        sunLevel = stringPicker.GetUserChoice(sunLevels);  
    }
    public string DisplayDict (Dictionary<string, Plant> dict)//kind of a temporary things to test the dictionary sorter
    {
        string list = "";
        foreach (var key in dict.Keys)
        {
           list += $"{key} \n";
        }
        return list;
    }
    
    public /*Dictionary<string, Plant> string*/ void GetCompanionList(Dictionary<string, Plant> sortedDict)
    {
        var sortedKeys = sortedDict.Keys.ToList();

        var sortedBeneficiaries = beneficiaries
            .OrderBy(pair => sortedKeys.IndexOf(pair.Key))
            .ToDictionary(pair => pair.Key, pair => pair.Value);

        var sortedBenefactors = benefactors
            .OrderBy(pair => sortedKeys.IndexOf(pair.Key))
            .ToDictionary(pair => pair.Key, pair => pair.Value);

        var intersect = sortedBenefactors.Keys.Intersect(sortedBeneficiaries.Keys).ToList();
        var mutual = new Dictionary<string, Plant>();

        foreach (string s in intersect)
            {
                mutual.Add(s, sortedBenefactors[s]);
                sortedBenefactors.Remove(s);
                sortedBeneficiaries.Remove(s);
            }
        // public Dictionary<string, Plant> wholeHelpers = new Dictionary<string, Plant> 
        // (
        //     mutual.Union(sortedBeneficiaries).Union(sortedBenefactors)
        // );
        // string wholeList =  $"Plants that both help this plant and that this plant helps: \n{string.Join(", ", mutual.Keys)}\n" +
                            // $"Plants that help this plant: \n{string.Join(", ", sortedBenefactors.Keys)}\n" +
                            // $"Plants that this plant can help: \n{string.Join(", ", sortedBeneficiaries.Keys)}";
        // return wholeList;
        // from here make a seprate dictioanry to house the sameies and write all three to a list tyype things and return that.
        
        Console.WriteLine($"Plants that both help this plant and that this plant helps: \n{DisplayDict(mutual)}\nPlants that help this plant: \n{DisplayDict(sortedBeneficiaries)}\nPlants that this plant can help: \n{DisplayDict(sortedBenefactors)}");
    }

    
}