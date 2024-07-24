
class Perennial : Plant
{
    private int hardinessZone;
    
    Picker<int> intPicker = new();
    public Perennial() : base()
    {

    }
    public Perennial(string name, double spacing, string sunLevel, string soilType,  bool frostTolerant, string plantRotationFamily, string sowAndPlant, string harvestTime, List<string> beneficiaries, List<string> benefacotrs, string notes, int hardinessZone) 
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
     public override string PlantInfoToString()
    
    { //this is actually realy cool I didn't conenect that I could call the base method even inside this child's overridden method. This just turned 15-30 minuets of work into 15-30 seconds.
        return base.PlantInfoToString() + "~~" + hardinessZone.ToString();
    }
}