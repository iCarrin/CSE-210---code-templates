using Newtonsoft.Json;
class Perennial : Plant
{
    [JsonProperty]
    private int hardinessZone;
    public int HardinessZone
    {
        get;
    }
    Picker<int> intPicker = new();
    public Perennial() : base()
    {

    }
    public Perennial(string name, int hardinessZone, double spacing, string sunLevel, string soilType,  bool frostTolerant, string plantRotationFamily, string sowAndPlant, string harvestTime, List<string> beneficiaries, List<string> benefacotrs, string notes) 
    : base(name, spacing, sunLevel, soilType, frostTolerant, plantRotationFamily,sowAndPlant, harvestTime, beneficiaries, benefacotrs, notes )
    {
        
        this.hardinessZone = hardinessZone;
    }
    public Perennial(string name, double spacing, string sunLevel, string soilType, bool frostTolerant, string plantRotationFamily, string sowAndPlant, string harvestTime, List<string> beneficiaries, List<string> benefacotrs, string notes) 
    : base(name, spacing, sunLevel, soilType,  frostTolerant, plantRotationFamily,sowAndPlant, harvestTime, beneficiaries, benefacotrs, notes )
    {
        Console.WriteLine("What's the coldest hardiness zone can this plant survive over the winter in?");
        hardinessZone = intPicker.GetUserNumberChoice(1,12);
    }
}