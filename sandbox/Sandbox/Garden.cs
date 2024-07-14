class Garden 
{
    public string Name { get; set; }
    public double Area { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }
    public string SunExposure { get; set; }
    public string GrowingZone { get; set; }
    // public int SoilPH { get; set; }
    public string SoilType { get; set; }
    public List<Plant> PlantsInGarden { get; set; }
    public List<Plant> PlantsList { get; set; }

    

    public void OrganizePlants()
    {
        // Implementation
    }

    public void FindMatch(string plantName)
    {
        // Implementation
    }

    public void AddPlant(string plantName)
    {
        // Implementation
    }

    public void RemovePlant(string plantName)
    {
        // Implementation
    }

    public void UpdateGardenSize(double newWidth, double newHeight)
    {
        // Implementation
    }
}
