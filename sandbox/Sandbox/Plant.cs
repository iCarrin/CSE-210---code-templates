// using Newtonsoft.Json;
using System.Runtime.CompilerServices;

class Plant
{

    private SoilType soilNeeds { get; }
    private Sunlight sunNeeds { get; }
    private bool perinial { get; }
    private bool frostTolerant { get; }
    private int spacing { get; }
    private string plantName { get; }
    private string plantRotationFamily { get; }
    private string SowAndPlant  { get; }
    public Dictionary<string, Plant> beneficiaries = new Dictionary<string, Plant>();
    // {
        // { "Asparagus", new Plant("tomato")},
        // { "Basil", new Plant("tomato")},
        // { "Beans", new Plant("tomato")},
        // { "Borage", new Plant("tomato")},
        // { "Calendula", new Plant("tomato")},
        // { "Marigold", new Plant("tomato")}
    // };
    public Dictionary<string, Plant> benefactors = new Dictionary<string, Plant>();
    // {
    //     { "Asparagus", new Plant("tomato")},
    //     { "Collards", new Plant("tomato")}
    // };

    public Plant(string whatItHelps)
    {
        this.plantName = whatItHelps;
        //walks a user through adding a plant
    }
    public string DisplayDict (Dictionary<string, Plant> dict)
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