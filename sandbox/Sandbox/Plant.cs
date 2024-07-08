using Newtonsoft.Json;
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
    private Dictionary<string, Plant> beneficiaries;
    private Dictionary<string, Plant> benefactors;

    public Plant()
    {
        //walks a user through adding a plant
    }
    // public Plant(SoilType soilNeeds, Sunlight sunNeeds, bool perinial, bool frostTolerant, int spacing, string plantRotationFamily, string sowAndPlant, List<string> beneficiaries, List<string> benefactors)
    // {
    //     this.soilNeeds = soilNeeds;
    //     this.sunNeeds = sunNeeds;
    //     this.perinial = perinial;
    //     this.frostTolerant = frostTolerant;
    //     this.spacing = spacing;
    //     this.plantRotationFamily = plantRotationFamily;
    //     this.SowAndPlant = sowAndPlant;
    //     this.beneficiaries = = new List<string>(beneficiaries);
    //     this.benefactors = = new List<string>(benefactors);
    //     //this is for Json to rebuild the plant with
    // }
    public Dictionary<string, Plant> GetCompanionList(Dictionary<string, Plant> sortedDict)
    {
        Dictioanry<string, Plant> sortedBeneficiaries = beneficiaries
            .OrderBy(plantRotationFamily => sortedDict.Keys.ToList().IndexOf(plantRotationFamily.Key))
            .ToDictionary(pair => pair.Key, pair)
    }

    
}