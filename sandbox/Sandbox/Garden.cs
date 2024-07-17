using System;
using System.Collections.Generic;
class Garden 
{
    public string name; // { get; set; }
    public double area; // { get; set; }
    public double height; // { get; set; }
    public double width; // { get; set; }
    public string sunExposure; // { get; set; }
    public string growingZone; // { get; set; }
    // public int SoilPH; // { get; set; }
    public string soilType; // { get; set; }
    public List<Plant> plantsInGarden; // { get; set; }
    public List<Plant> catalog; // { get; set; }
    Picker<string> picker = new Picker<string>();
    Picker<Plant> plantPicker = new Picker<Plant>();
    public Garden(string name, double area, double height, double width, string sunExposure, string growingZone, List<Plant> plantsInGarden, List<Plant> catalog) 
    {
        this.name = name;
        this.area = area;
        this.height = height;
        this.width = width;
        this.sunExposure = sunExposure;
        this.growingZone = growingZone;
        this.plantsInGarden = plantsInGarden;
        this.catalog = catalog;
        

    }

    public void OrganizePlants()
    {
        int orderNum = 0;
        foreach (Plant p in catalog)
        {
            if (p.Spacing > area)
            {
                catalog.Remove(p);
                catalog.Add(p);
            }
            else 
            {
                orderNum++;
            }
        }
        // foreach (Plant p in catalog)
        // {
        //     if (p.HardinessZone > area)
        //     {
        //         catalog.Remove(p);
        //         catalog.Add(p);
        //     }
        //     else 
        //     {
        //         orderNum++;
        //     }
        // }

    }
    

    public void FindMatch(string plantName)
    {
        Console.WriteLine("What plant are you considering?");
        Plant choice = plantPicker.GetUserChoice(plantsInGarden);
        choice.

    }

    public void AddPlant(string plantName)
    {
        Console.WriteLine("What plant do you want to add?");
        plantsInGarden.Add(plantPicker.GetUserChoice(catalog));
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
