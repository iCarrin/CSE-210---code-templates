using Newtonsoft.Json;

class Harvestable : Plant
{
    [JsonProperty]
    private string harvestTime;// { get; }
    
    public Harvestable(string name, /*string hardinessZone,*/ int spacing, /*string sunLevel, string soilType, bool perinial, bool frostTolerant, string plantRotationFamily, string sowAndPlant,*/string harvestTime, List<string> beneficiaries, List<string> benefactors, List<string> mutual) 
    : base(name, /*hardinessZone,*/ spacing, /*sunLevel, soilType, perinial, frostTolerant, plantRotationFamily,sowAndPlant,*/ beneficiaries, benefactors, mutual)
    {
        this.harvestTime = harvestTime;
    }
    
    public Harvestable(string name,/* string hardinessZone,*/ int spacing, /*string sunLevel, string soilType, bool perinial, bool frostTolerant, string plantRotationFamily, string sowAndPlant,*/ List<string> beneficiaries, List<string> benefactors, List<string> mutual) 
    : base(name, /*hardinessZone,*/ spacing, /*sunLevel, soilType, perinial, frostTolerant, plantRotationFamily,sowAndPlant,*/ beneficiaries, benefactors, mutual)
    {
        Console.WriteLine("When can you harvest this plant? ");
        harvestTime = Console.ReadLine();
    }
}