class Flower : Plant
{
    private string floweringTime;
    public Flower(string name, int spacing, string sunLevel, string soilType, bool perinial, bool frostTolerant, string plantRotationFamily, string sowAndPlant, List<string> beneficiaries, List<string> benefactors, List<string> mutual) 
    : base(name, spacing, sunLevel, soilType, perinial, frostTolerant, plantRotationFamily,sowAndPlant, beneficiaries, benefactors, mutual)
    {
        Console.WriteLine("What time of year does this plant flower?");
        floweringTime = Console.ReadLine();
    }
}