class Vegitable : Plant
{
    private string harvestTime;
    public Vegitable(string name, int spacing, string sunLevel, string soilType, bool perinial, bool frostTolerant, string plantRotationFamily, string sowAndPlant, List<string> beneficiaries, List<string> benefactors, List<string> mutual) 
    : base(name, spacing, sunLevel, soilType, perinial, frostTolerant, plantRotationFamily,sowAndPlant, beneficiaries, benefactors, mutual)
    {
        Console.WriteLine("When can you harvest this plant? ");
        harvestTime = Console.ReadLine();
    }
}