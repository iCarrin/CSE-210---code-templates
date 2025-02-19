class GardenBuilder
{
    Dictionary<string, Plant> plantCatalog;
    private string[] sunLevels = 
    {
        "FullSun",
        "Partial",
        "Shaded"
    };
    Picker<string> stringPicker = new ();
    Picker<int> intPicker = new ();

    public GardenBuilder(Dictionary<string, Plant> catalogNew)
    {
        plantCatalog = catalogNew;
    }
    public Garden Create()
    {
        Console.WriteLine("Name of new garden: ");
        string name = Console.ReadLine();
        Console.WriteLine("Area of garden in square inches");  
        double area = double.Parse(Console.ReadLine());
        Console.WriteLine("Sun exposure of garden:");
        string sunExposure = stringPicker.GetUserChoice(sunLevels);
        Console.WriteLine("What is the garden's hardiness zone?");
        int growingZone = intPicker.GetUserNumberChoice(1,12); 
        Dictionary<string, Plant> plantsInGarden = null; 
        

        Garden newPlot = new Garden(name, area, sunExposure, growingZone, plantsInGarden, plantCatalog);
        return newPlot;
    }
}