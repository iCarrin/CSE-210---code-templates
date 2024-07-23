using Newtonsoft.Json;

abstract class Plant
{
    //open intergrated terminal dotnet add package Newtonsoft.Json
        // it just works
        //but you can write a serilizer and deseriliser converters 
        //a seperate constructor can call it;s own constructor from its own class
[JsonProperty]
public string plantName;

[JsonProperty]
public double spacing;

[JsonProperty]
public string sunLevel;

[JsonProperty]
public string soilType;

[JsonProperty]
public bool frostTolerant;

[JsonProperty]
public string plantRotationFamily;

[JsonProperty]
public string sowAndPlant;

[JsonProperty]
public string harvestTime;

[JsonProperty]
public List<string> beneficiaries;

[JsonProperty]
public List<string> benefactors;

[JsonProperty]
public string notes;

    public Plant()
    {

    }
    public Plant(string name, double spacing, string sunLevel, string soilType, bool frostTolerant, string plantRotationFamily, string sowAndPlant, string harvestTime, List<string> beneficiaries, List<string> benefactors, string notes)
    {
        plantName = name;
        this.spacing = spacing;
        this.sunLevel = sunLevel;
        this.soilType = soilType;
        this.frostTolerant = frostTolerant;
        this.plantRotationFamily = plantRotationFamily;
        this.sowAndPlant = sowAndPlant;
        this.harvestTime = harvestTime;
        this.beneficiaries = beneficiaries;
        this.benefactors = benefactors;
        this.notes = notes;
       
    }
   
    
    // public double GetSpacing()
    // {
    //     return spacing;
    // }
    public void PrintAllLists(List<string> referanceList)
    {
       
        if (beneficiaries.Count != 0) 
        {
            _ = SortSmallList(referanceList, beneficiaries);
            Console.WriteLine($"Plants that help {plantName}: ");
            
            for (int i = 0; i < beneficiaries.Count;)
            {
                Console.Write($"{beneficiaries[i]} ");
                i++;
                Console.Write($"{beneficiaries[i+1]} ");
                i++;
                Console.Write($"{beneficiaries[i+2]} ");
                i++;
                Console.Write($"{beneficiaries[i+3]} ");
                i++;
                Console.Write($"{beneficiaries[i+4]} ");
                i++;
                Console.WriteLine();  
            }

            
        };
        if (benefactors.Count != 0) 
        {
            _ = SortSmallList(referanceList, beneficiaries);
            Console.WriteLine($"Plants that {plantName} helps \n{SortSmallList(referanceList, benefactors)}");
            for (int i = 0; i < benefactors.Count;)
            {
                Console.Write($"{benefactors[i]} ");
                i++;
                Console.Write($"{benefactors[i+1]} ");
                i++;
                Console.Write($"{benefactors[i+2]} ");
                i++;
                Console.Write($"{benefactors[i+3]} ");
                i++;
                Console.Write($"{benefactors[i+4]} ");
                i++;
                Console.WriteLine();  
            }
        };
    }
    private List<string> SortSmallList(List<string> referanceList, List<string> toSort)
    {
         var sortedList = toSort
            .OrderBy(referanceList.IndexOf)
            .ToList();
        return sortedList;
    }

    public override string ToString()
    {
        return plantName;
        
    }
 
   
    // public string PrintPlantInfo()
    // {
        // Console.WriteLine($"Plant Name: {plantName}");
        // Console.WriteLine($"Spacing: {spacing} SQ inches");
        // Console.WriteLine($"Sun Level: {sunLevel}");
        // Console.WriteLine($"Soil Type: {soilType}");
        // Console.WriteLine($"Frost Tolerant: {(frostTolerant ? "Yes" : "No")}");
        // Console.WriteLine($"Plant Rotation Family: {plantRotationFamily}");
        // Console.WriteLine($"Sow and Plant: {sowAndPlant}");
        // Console.WriteLine($"How to harvest: {harvestTime}");
        // Console.WriteLine($"Notes: {notes}");
        // Console.WriteLine();
        // Console.WriteLine();
        
        
        // if (beneficiaries != null && beneficiaries.Any())
        // {
        //     foreach (var Beneficiary in beneficiaries)
        //     {
        //         Console.WriteLine($"  - {Beneficiary}");
        //     }
        // }
        // else { Console.WriteLine("  None"); }

        // Console.WriteLine("benefactors:");
        // if (benefactors != null && benefactors.Any())
        // {
        //     foreach (var Benefactor in benefactors)
        //     {
        //         Console.WriteLine($"  - {Benefactor}");
        //     }
        // }
        // else { Console.WriteLine("  None"); }
        
        
    //   }    

    public string PlantInfoToString()
    
    {
            string bigBenefic = "";
            foreach (var Beneficiary in beneficiaries)
            {
                bigBenefic += $"{Beneficiary}";
            }
            string bigBenefact = "";
            foreach (var Benefactor in benefactors)
            {
                bigBenefact += $"|{Benefactor}";
            }
        
        return plantName + "~~" + spacing + "~~" + sunLevel + "~~" + soilType + "~~" + frostTolerant + "~~" + plantRotationFamily + "~~" + sowAndPlant + "~~" + harvestTime + "~~" + bigBenefic + "~~" + bigBenefact + "~~" + notes;
    }
}