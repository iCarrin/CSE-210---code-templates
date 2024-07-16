class Flowering : Plant
{
    private string floweringTime;
    
    public Flowering(string name, string hardinessZone,int spacing, string sunLevel, string soilType, bool perinial, bool frostTolerant, string plantRotationFamily, string sowAndPlant, string floweringTime, List<string> beneficiaries, List<string> benefactors, List<string> mutual) 
    : base(name, hardinessZone, spacing, sunLevel, soilType, perinial, frostTolerant, plantRotationFamily,sowAndPlant, beneficiaries, benefactors, mutual)
    {
        
        this.floweringTime = floweringTime;
    }
    public Flowering(string name, string hardinessZone, int spacing, string sunLevel, string soilType, bool perinial, bool frostTolerant, string plantRotationFamily, string sowAndPlant, List<string> beneficiaries, List<string> benefactors, List<string> mutual) 
    : base(name, hardinessZone, spacing, sunLevel, soilType, perinial, frostTolerant, plantRotationFamily,sowAndPlant, beneficiaries, benefactors, mutual)
    {
        Console.WriteLine("What time of year does this plant flower?");
        floweringTime = Console.ReadLine();
    }
}

